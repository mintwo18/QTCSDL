using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QLBH
{
    public partial class frmNhaCungCap : Form
    {
        string sCon = "Data Source=PAOCHOUZ\\BAOCHAU;Initial Catalog=QLBH;Integrated Security=True;Encrypt=True";
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
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
            string sQuery = "SELECT * FROM NHACUNGCAP";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "NhaCungCap");

            dataGridView1.DataSource = ds.Tables["NhaCungCap"];

            // Bước 3
            con.Close();
        }

        private void btnLuuNhaCungCap_Click(object sender, EventArgs e)
        {
            // === BƯỚC 1: KẾT NỐI CƠ SỞ DỮ LIỆU ===
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
                return;
            }

            // === BƯỚC 2: CHUẨN BỊ DỮ LIỆU VÀ KIỂM TRA ===
            string sMaNCC = txtMaNCC.Text.Trim();
            string sTenNCC = txtTenNCC.Text.Trim();
            string sSDT = txtSDT_NCC.Text.Trim();
            string sDiaChi = txtDiaChi_NCC.Text.Trim();

            // Kiểm tra rỗng
            if (sMaNCC == "" || sTenNCC == "" || sSDT == "" || sDiaChi == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà cung cấp!");
                con.Close();
                return;
            }

            // Kiểm tra định dạng mã nhà cung cấp: NCC + 7 số
            if (sMaNCC.Length != 10 || !sMaNCC.StartsWith("NCC") || !sMaNCC.Substring(3).All(char.IsDigit))
            {
                MessageBox.Show("Mã NCC phải có 10 ký tự, bắt đầu bằng 'NCC' và 7 ký tự sau phải là số!");
                con.Close();
                return;
            }


            // Kiểm tra số điện thoại: đúng 10 số
            if (sSDT.Length != 10 || !sSDT.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải đúng 10 chữ số!");
                con.Close();
                return;
            }

            // === BƯỚC 3: KIỂM TRA MÃ NCC ĐÃ TỒN TẠI CHƯA ===
            SqlCommand checkCmd = new SqlCommand("SELECT 1 FROM NHACUNGCAP WHERE MANCC = @mancc", con);
            checkCmd.Parameters.AddWithValue("@mancc", sMaNCC);

            var exists = checkCmd.ExecuteScalar();
            if (exists != null)
            {
                MessageBox.Show("Mã nhà cung cấp đã tồn tại!");
                con.Close();
                return;
            }

            // === BƯỚC 4: THÊM MỚI NHÀ CUNG CẤP ===
            string sQuery = "INSERT INTO NHACUNGCAP (MANCC, TENNCC, SDT_NCC, DIACHI_NCC) VALUES (@mancc, @ten, @sdt, @dc)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@mancc", sMaNCC);
            cmd.Parameters.AddWithValue("@ten", sTenNCC);
            cmd.Parameters.AddWithValue("@sdt", sSDT);
            cmd.Parameters.AddWithValue("@dc", sDiaChi);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm nhà cung cấp thành công!");
                frmNhaCungCap_Load(sender, e); // load lại dữ liệu
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm mới nhà cung cấp!");
            }
            finally
            {
                con.Close(); // BƯỚC 5: ĐÓNG KẾT NỐI
            }
        }

        private void btnSuaNhaCungCap_Click(object sender, EventArgs e)
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

            // Bước 2: Lấy giá trị từ các TextBox
            string sMaNCC = txtMaNCC.Text;
            string sTenNCC = txtTenNCC.Text;
            string sSDT = txtSDT_NCC.Text;
            string sDiaChi = txtDiaChi_NCC.Text;

            // Câu lệnh cập nhật dữ liệu
            string sQuery = "UPDATE NHACUNGCAP SET TENNCC = @ten, SDT_NCC = @sdt, DIACHI_NCC = @dc WHERE MANCC = @mancc";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@mancc", sMaNCC);
            cmd.Parameters.AddWithValue("@ten", sTenNCC);
            cmd.Parameters.AddWithValue("@sdt", sSDT);
            cmd.Parameters.AddWithValue("@dc", sDiaChi);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                frmNhaCungCap_Load(sender, e); // Load lại bảng sau khi sửa
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật!");
            }

            con.Close(); // Bước 3: Đóng kết nối
        }

        private void btnXoaNhaCungCap_Click(object sender, EventArgs e)
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
                catch
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
                    return;
                }

                // Bước 2: Lấy mã NCC từ TextBox
                string sMaNCC = txtMaNCC.Text;

                if (sMaNCC == "")
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa!");
                    con.Close();
                    return;
                }

                // Xóa NCC
                string sQuery = "DELETE FROM NHACUNGCAP WHERE MANCC = @mancc";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@mancc", sMaNCC);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa nhà cung cấp thành công!");
                    frmNhaCungCap_Load(sender, e); // Load lại dữ liệu
                }
                catch
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình xóa!");
                }

                con.Close(); // Bước 3
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemNhaCungCap_Click(object sender, EventArgs e)
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
            string tuKhoa = txtTenNCC.Text.Trim();     // dùng để tìm theo tên NCC
            string sdt = txtSDT_NCC.Text.Trim();       // dùng để tìm theo SDT NCC

            if (string.IsNullOrEmpty(tuKhoa) && string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập tên hoặc số điện thoại nhà cung cấp cần tìm!");
                con.Close(); // Đóng kết nối nếu không nhập gì
                return;
            }

            string sQuery = "SELECT * FROM NHACUNGCAP WHERE 1=1";

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                sQuery += " AND TENNCC LIKE @tuKhoa";
            }

            if (!string.IsNullOrEmpty(sdt))
            {
                sQuery += " AND SDT_NCC LIKE @sdt";
            }

            SqlCommand cmd = new SqlCommand(sQuery, con);

            if (!string.IsNullOrEmpty(tuKhoa))
                cmd.Parameters.AddWithValue("@tuKhoa", "%" + tuKhoa + "%");

            if (!string.IsNullOrEmpty(sdt))
                cmd.Parameters.AddWithValue("@sdt", "%" + sdt + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp nào!");
            }

            // Bước 3: Đóng kết nối
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Lấy dữ liệu từ dòng chọn và đưa lên TextBox
            txtMaNCC.Text = dataGridView1.Rows[e.RowIndex].Cells["MANCC"].Value.ToString();
            txtTenNCC.Text = dataGridView1.Rows[e.RowIndex].Cells["TENNCC"].Value.ToString();
            txtSDT_NCC.Text = dataGridView1.Rows[e.RowIndex].Cells["SDT_NCC"].Value.ToString();
            txtDiaChi_NCC.Text = dataGridView1.Rows[e.RowIndex].Cells["DIACHI_NCC"].Value.ToString();

            // Khóa mã NCC không cho người dùng sửa
            txtMaNCC.Enabled = false;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy nhập thông tin không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                LoadData();
                ClearForm();
            }
        }

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string sQuery = "SELECT MaNCC, TenNCC, SDT_NCC, DiaChi_NCC FROM NhaCungCap";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "NhaCungCap");
                        // Thay 'dgvNhap' bằng tên DataGridView thực tế (ví dụ: dataGridView1)
                        dataGridView1.DataSource = ds.Tables["NhaCungCap"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
                }
            }
        }

        private void ClearForm()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtSDT_NCC.Clear();
            txtDiaChi_NCC.Clear();
            txtMaNCC.Enabled = true;
            txtMaNCC.Focus();
        }
    }
}



