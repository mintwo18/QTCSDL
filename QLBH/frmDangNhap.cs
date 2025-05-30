using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            string tenDN = textBox_TenDangNhap.Text.Trim();
            string matKhau = textBox_MatKhau.Text.Trim();

            // Tạo connection string từ user nhập
            string connStr = $"Server=PAOCHOUZ\\BAOCHAU;Database=QLBH;User ID={tenDN};Password={matKhau};";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // Kiểm tra người dùng thuộc role nào
                    SqlCommand cmd = new SqlCommand(@"
                SELECT 
                    IS_MEMBER('BANHANG') AS IsBanHang,
                    IS_MEMBER('QUANLYKHO') AS IsQuanLyKho,
                    IS_MEMBER('QUANLYNO') AS IsQuanLyNo,
                    IS_MEMBER('KETOANTRUONG') AS IsKeToanTruong,
                    IS_MEMBER('QUANTRI') AS IsQuanTri
            ", conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    string role = "Unknown";
                    if (reader.Read())
                    {
                        if (reader.GetInt32(4) == 1) role = "QUANTRI";
                        else if (reader.GetInt32(3) == 1) role = "KETOANTRUONG";
                        else if (reader.GetInt32(2) == 1) role = "QUANLYNO";
                        else if (reader.GetInt32(1) == 1) role = "QUANLYKHO";
                        else if (reader.GetInt32(0) == 1) role = "BANHANG";
                    }
                    reader.Close();

                    if (role == "Unknown")
                    {
                        MessageBox.Show("Tài khoản không thuộc bất kỳ nhóm quyền nào. Vui lòng liên hệ quản trị viên.");
                        return;
                    }

                    MessageBox.Show($"Đăng nhập thành công dưới quyền: {role}");

                    frmMain main = new frmMain(connStr, tenDN, role);
                    this.Hide();
                    main.Show();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đăng nhập thất bại!\n" + ex.Message);
            }
        }
    }
}
