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
    public partial class frmNhanVien : Form
    {
        string sCon = "Data Source=PAOCHOUZ\\BAOCHAU;Initial Catalog=QLBH;Integrated Security=True;Encrypt=True";
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
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
            string sQuery = "SELECT * FROM NHANVIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "NhanVien");

            dataGridView1.DataSource = ds.Tables["NhanVien"];

            // Bước 3
            con.Close();
        }

        private void btnLuuNhanVien_Click(object sender, EventArgs e)
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
            string sMaNV = txtMaNV.Text.Trim();
            string sTenNV = txtTenNV.Text.Trim();
            string sSDT = txtSDT_NV.Text.Trim();
            string sDiaChi = txtDiaChi_NV.Text.Trim();

            // Kiểm tra rỗng
            if (sMaNV == "" || sTenNV == "" || sSDT == "" || sDiaChi == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên!");
                con.Close();
                return;
            }
            // Kiểm tra định dạng mã nhân viên: NV + 8 số
            if (sMaNV.Length != 10 || !sMaNV.StartsWith("NV") || !sMaNV.Substring(2).All(char.IsDigit))
            {
                MessageBox.Show("Mã nhân viên phải có 10 ký tự, bắt đầu bằng 'NV' và 8 ký tự sau phải là số!");
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

            // === BƯỚC 3: KIỂM TRA MÃ NHÂN VIÊN ĐÃ TỒN TẠI CHƯA ===
            SqlCommand checkCmd = new SqlCommand("SELECT 1 FROM NHANVIEN WHERE MANV = @manv", con);
            checkCmd.Parameters.AddWithValue("@manv", sMaNV);

            var exists = checkCmd.ExecuteScalar();
            if (exists != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                con.Close();
                return;
            }

            // === BƯỚC 4: THÊM MỚI NHÂN VIÊN ===
            string sQuery = "INSERT INTO NHANVIEN (MANV, TENNV, SDT_NV, DIACHI_NV) VALUES (@manv, @ten, @sdt, @dc)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@manv", sMaNV);
            cmd.Parameters.AddWithValue("@ten", sTenNV);
            cmd.Parameters.AddWithValue("@sdt", sSDT);
            cmd.Parameters.AddWithValue("@dc", sDiaChi);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm nhân viên thành công!");
                frmNhanVien_Load(sender, e); // load lại dữ liệu
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm mới nhân viên!");
            }
            finally
            {
                con.Close(); // BƯỚC 5: ĐÓNG KẾT NỐI
            }
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
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
            string sMaNV = txtMaNV.Text;
            string sTenNV = txtTenNV.Text;
            string sSDT = txtSDT_NV.Text;
            string sDiaChi = txtDiaChi_NV.Text;

            // Câu lệnh cập nhật
            string sQuery = "UPDATE NHANVIEN SET TENNV = @ten, SDT_NV = @sdt, DIACHI_NV = @dc WHERE MANV = @manv";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@manv", sMaNV);
            cmd.Parameters.AddWithValue("@ten", sTenNV);
            cmd.Parameters.AddWithValue("@sdt", sSDT);
            cmd.Parameters.AddWithValue("@dc", sDiaChi);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                frmNhanVien_Load(sender, e); // Load lại dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật!");
            }

            con.Close(); // Bước 3
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
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

                // Bước 2: Lấy mã nhân viên từ TextBox
                string sMaNV = txtMaNV.Text;

                if (sMaNV == "")
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                    con.Close();
                    return;
                }

                // Xóa nhân viên
                string sQuery = "DELETE FROM NHANVIEN WHERE MANV = @manv";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@manv", sMaNV);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa nhân viên thành công!");
                    frmNhanVien_Load(sender, e); // Load lại dữ liệu
                }
                catch
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình xóa!");
                }

                con.Close(); // Bước 3
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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
            string tuKhoa = txtTenNV.Text.Trim();      // dùng để tìm theo tên
            string sdt = txtSDT_NV.Text.Trim();        // dùng để tìm theo số điện thoại

            if (string.IsNullOrEmpty(tuKhoa) && string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập tên hoặc số điện thoại nhân viên cần tìm!");
                con.Close(); // Đừng quên đóng kết nối nếu dừng ở đây
                return;
            }

            string sQuery = "SELECT * FROM NHANVIEN WHERE 1=1";

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                sQuery += " AND TENNV LIKE @tuKhoa";
            }

            if (!string.IsNullOrEmpty(sdt))
            {
                sQuery += " AND SDT_NV LIKE @sdt";
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
                MessageBox.Show("Không tìm thấy nhân viên nào!");
            }

            // Bước 3: Đóng kết nối
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy giá trị từ dòng đang chọn và đổ vào các TextBox
            txtMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
            txtTenNV.Text = dataGridView1.Rows[e.RowIndex].Cells["TENNV"].Value.ToString();
            txtSDT_NV.Text = dataGridView1.Rows[e.RowIndex].Cells["SDT_NV"].Value.ToString();
            txtDiaChi_NV.Text = dataGridView1.Rows[e.RowIndex].Cells["DIACHI_NV"].Value.ToString();

            // Khóa mã nhân viên để không được sửa (khóa chính)
            txtMaNV.Enabled = false;
        }

        private void btn_Huy_NV_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy nhập thông tin không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                LoadDataNhanVien();
                ClearFormNhanVien();
            }
        }

        private void LoadDataNhanVien()
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string sQuery = "SELECT MANV, TENNV, SDT_NV, DIACHI_NV FROM NHANVIEN";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "NhanVien");
                        dataGridView1.DataSource = ds.Tables["NhanVien"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
                }
            }
        }

        private void ClearFormNhanVien()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT_NV.Clear();
            txtDiaChi_NV.Clear();
            txtMaNV.Enabled = true;
            txtMaNV.Focus();
        }

    }

}


