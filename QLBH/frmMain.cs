using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhapHang;
using QLBH;
using UngDungQLBH;
using WindowsFormsAppQLBH_LOHANG;
using WindowsFormsAppQLBH_MON;
using WindowsFormsAppQLBH_NGUYENLIEU;
using static Azure.Core.HttpHeader;

namespace QLBH
{
    public partial class frmMain : Form
    {
        private string connectionString;
        private string tenDN;
        private string role;
        public frmMain(string connStr, string tenDN, string role)
        {
            InitializeComponent();
            this.connectionString = connStr;
            this.tenDN = tenDN;
            this.role = role;

            this.Text = $"QLBH - Người dùng: {tenDN} | Quyền: {role}";
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Ẩn hết các chức năng trước
            NhanVienToolStripMenuItem.Visible = false;
            NhaCungCapToolStripMenuItem.Visible = false;
            KhachHangToolStripMenuItem.Visible = false;
            MonToolStripMenuItem.Visible = false;
            NguyenLieuToolStripMenuItem.Visible = false;
            LoHangToolStripMenuItem.Visible = false;
            CongNoToolStripMenuItem.Visible = false;
            TongNoToolStripMenuItem.Visible = false;
            TraNoToolStripMenuItem.Visible = false;
            DonBanToolStripMenuItem.Visible = false;
            DonNhanToolStripMenuItem.Visible = false;

            // Bật menu tùy theo quyền
            if (role == "BANHANG")
            {
                DonBanToolStripMenuItem.Visible = true;
                NhanVienToolStripMenuItem.Visible = true;
                KhachHangToolStripMenuItem.Visible = true;
                MonToolStripMenuItem.Visible = true;
            }
            else if (role == "QUANLYKHO")
            {
                DonNhanToolStripMenuItem.Visible = true;
                NguyenLieuToolStripMenuItem.Visible = true;
                LoHangToolStripMenuItem.Visible = true;
                NhanVienToolStripMenuItem.Visible = true;
                NhaCungCapToolStripMenuItem.Visible = true;
            }
            else if (role == "QUANLYNO")
            {
                CongNoToolStripMenuItem.Visible = true;
                TongNoToolStripMenuItem.Visible = true;
                TraNoToolStripMenuItem.Visible = true;
                NhanVienToolStripMenuItem.Visible = true;
                NhaCungCapToolStripMenuItem.Visible = true;
                DonNhanToolStripMenuItem.Visible = true;
            }
            else if (role == "KETOANTRUONG")
            {
                NhanVienToolStripMenuItem.Visible = true;
                NhaCungCapToolStripMenuItem.Visible = true;
                KhachHangToolStripMenuItem.Visible = true;
                MonToolStripMenuItem.Visible = true;
                NguyenLieuToolStripMenuItem.Visible = true;
                LoHangToolStripMenuItem.Visible = true;
                CongNoToolStripMenuItem.Visible = true;
                TongNoToolStripMenuItem.Visible = true;
                TraNoToolStripMenuItem.Visible = true;
                DonBanToolStripMenuItem.Visible = true;
                DonNhanToolStripMenuItem.Visible = true;
            }
            else if (role == "QUANTRI")
            {
                NhanVienToolStripMenuItem.Visible = true;
                NhaCungCapToolStripMenuItem.Visible = true;
                KhachHangToolStripMenuItem.Visible = true;
                MonToolStripMenuItem.Visible = true;
                NguyenLieuToolStripMenuItem.Visible = true;
                LoHangToolStripMenuItem.Visible = true;
                CongNoToolStripMenuItem.Visible = true;
                TongNoToolStripMenuItem.Visible = true;
                TraNoToolStripMenuItem.Visible = true;
                DonBanToolStripMenuItem.Visible = true;
                DonNhanToolStripMenuItem.Visible = true;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void NhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien nhanvien = new frmNhanVien();
            nhanvien.MdiParent = this;
            nhanvien.Show();
        }

        private void NhaCungCapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap ncc = new frmNhaCungCap();
            ncc.MdiParent = this;
            ncc.Show();
        }

        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang khachhang = new frmKhachHang();
            khachhang.MdiParent = this;
            khachhang.Show();
        }

        private void TongNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTONGNO tn = new frmTONGNO();
            tn.MdiParent = this;
            tn.Show();
        }

        private void CongNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCONGNO cn = new frmCONGNO();
            cn.MdiParent = this;
            cn.Show();
        }

        private void TraNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraNo tn = new frmTraNo();
            tn.MdiParent = this;
            tn.Show();
        }

        private void DonBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBan_Them b = new frmBan_Them();
            b.MdiParent = this;
            b.Show();
        }
        private void DonNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhan nhan = new frmNhan();
            nhan.MdiParent = this;
            nhan.Show();
        }

        private void MonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLBH_MON m = new FormQLBH_MON();
            m.MdiParent = this;
            m.Show();
        }

        private void NguyenLieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLBH_NGUYENLIEU m = new FormQLBH_NGUYENLIEU();
            m.MdiParent = this;
            m.Show();
        }

        private void LoHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLOHANG lh = new FormLOHANG();
            lh.MdiParent = this;
            lh.Show();
        }

        private void DangXuattToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Mở lại form đăng nhập
                frmDangNhap dangNhap = new frmDangNhap();
                dangNhap.Show();

                // Đóng form hiện tại
                this.Close();
            }
        }
    }
}
