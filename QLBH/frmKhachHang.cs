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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLBH


{
    public partial class frmKhachHang : Form
    {
        string sCon = "Data Source=PAOCHOUZ\\BAOCHAU;Initial Catalog=QLBH;Integrated Security=True;Encrypt=True";
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy giá trị từng ô và gán vào các TextBox
            txtMaKH.Text = dataGridView1.Rows[e.RowIndex].Cells["MAKH"].Value.ToString();
            txtTenKH.Text = dataGridView1.Rows[e.RowIndex].Cells["HOTEN"].Value.ToString();

            // Không cho sửa mã KH vì là khóa chính
            txtMaKH.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }

            // Bước 2 - lấy dữ liệu về
            string sQuery = "SELECT * FROM KHACHHANG";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "KhachHang");

            dataGridView1.DataSource = ds.Tables["KhachHang"];

            // Bước 3
            con.Close();
        }

        private void btnLuuKhachHang_Click(object sender, EventArgs e)
        {
            // Bước 1 - kết nối DB
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            // === BƯỚC 2: CHUẨN BỊ DỮ LIỆU ===
            // === BƯỚC 2: CHUẨN BỊ DỮ LIỆU VÀ KIỂM TRA ===
            string sMaKH = txtMaKH.Text.Trim();
            string sTenKH = txtTenKH.Text.Trim();

            if (sMaKH == "" || sTenKH == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã KH và Họ tên!");
                con.Close();
                return;
            }

            if (sMaKH.Length != 10 || !sMaKH.StartsWith("KH") || !sMaKH.Substring(2).All(char.IsDigit))
            {
                MessageBox.Show("Mã khách hàng phải có 10 ký tự, bắt đầu bằng 'KH' và 8 ký tự sau phải là số!");
                con.Close();
                return;
            }


            // === KIỂM TRA MÃ KHÁCH HÀNG ĐÃ TỒN TẠI CHƯA ===
            SqlCommand checkCmd = new SqlCommand("SELECT 1 FROM KHACHHANG WHERE MAKH = @makh", con);
            checkCmd.Parameters.AddWithValue("@makh", sMaKH);

            var exists = checkCmd.ExecuteScalar();
            if (exists != null)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!");
                con.Close();
                return;
            }


            // === THÊM MỚI KHÁCH HÀNG ===
            string sQuery = "INSERT INTO KHACHHANG (MAKH, HOTEN) VALUES (@makh, @hoten)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@makh", sMaKH);
            cmd.Parameters.AddWithValue("@hoten", sTenKH);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm khách hàng thành công!");
                frmKhachHang_Load(sender, e); // load lại dữ liệu
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm mới khách hàng!");
            }
            finally
            {
                con.Close(); // BƯỚC 3
            }
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            // Bước 1: Kết nối CSDL
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
                return;
            }

            // Bước 2: Lấy giá trị
            string sMaKH = txtMaKH.Text;
            string sTenKH = txtTenKH.Text;

            // Câu lệnh cập nhật
            string sQuery = "UPDATE KHACHHANG SET HOTEN = @tenkh WHERE MAKH = @makh";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@makh", sMaKH);
            cmd.Parameters.AddWithValue("@tenkh", sTenKH);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                frmKhachHang_Load(sender, e); // Load lại dữ liệu sau khi cập nhật
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật!");
            }

            con.Close(); // Bước 3
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                // Bước 1: Kết nối CSDL
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
                    return;
                }

                // Bước 2: Lấy mã khách hàng từ TextBox
                string sMaKH = txtMaKH.Text;

                // Kiểm tra rỗng
                if (sMaKH == "")
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
                    con.Close();
                    return;
                }

                // Câu lệnh xóa dữ liệu
                string sQuery = "DELETE FROM KHACHHANG WHERE MAKH = @makh";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@makh", sMaKH);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa khách hàng thành công!");
                    frmKhachHang_Load(sender, e); // Load lại dữ liệu
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình xóa!");
                }

                con.Close(); // Bước 3: Đóng kết nối
            }

        }

        private void btnTimKiemKhachHang_Click(object sender, EventArgs e)
        {
            // Bước 1: Kết nối CSDL
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open(); // Mở kết nối
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
                return;
            }

            // === BƯỚC 2: TẠO CÂU TRUY VẤN VÀ TÌM KIẾM ===
            string tuKhoa = txtTenKH.Text.Trim();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng cần tìm!");
                con.Close(); // Đừng quên đóng kết nối nếu dừng ở đây
                return;
            }

            string sQuery = "SELECT * FROM KHACHHANG WHERE HOTEN LIKE @tuKhoa";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@tuKhoa", "%" + tuKhoa + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng nào!");
            }

            // Bước 3: Đóng kết nối
            con.Close();
        }

        private void btn_Huy_KhachHang_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy nhập thông tin không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                LoadDataKhachHang();
                ClearFormKhachHang();
            }
        }

        private void LoadDataKhachHang()
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string sQuery = "SELECT MAKH, HOTEN FROM KHACHHANG";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "KhachHang");
                        dataGridView1.DataSource = ds.Tables["KhachHang"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
                }
            }
        }

        private void ClearFormKhachHang()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtMaKH.Enabled = true;
            txtMaKH.Focus();
        }

    }
}









