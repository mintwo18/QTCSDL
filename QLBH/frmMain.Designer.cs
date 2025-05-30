namespace QLBH
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            QuanLyToolStripMenuItem = new ToolStripMenuItem();
            NhanVienToolStripMenuItem = new ToolStripMenuItem();
            NhaCungCapToolStripMenuItem = new ToolStripMenuItem();
            KhachHangToolStripMenuItem = new ToolStripMenuItem();
            MonToolStripMenuItem = new ToolStripMenuItem();
            NguyenLieuToolStripMenuItem = new ToolStripMenuItem();
            LoHangToolStripMenuItem = new ToolStripMenuItem();
            QuanLyTraNoToolStripMenuItem = new ToolStripMenuItem();
            TongNoToolStripMenuItem = new ToolStripMenuItem();
            CongNoToolStripMenuItem = new ToolStripMenuItem();
            TraNoToolStripMenuItem = new ToolStripMenuItem();
            DonNhanToolStripMenuItem = new ToolStripMenuItem();
            DonBanToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            DangXuatToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // QuanLyToolStripMenuItem
            // 
            QuanLyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NhanVienToolStripMenuItem, NhaCungCapToolStripMenuItem, KhachHangToolStripMenuItem, MonToolStripMenuItem, NguyenLieuToolStripMenuItem, LoHangToolStripMenuItem });
            QuanLyToolStripMenuItem.Name = "QuanLyToolStripMenuItem";
            QuanLyToolStripMenuItem.Size = new Size(90, 29);
            QuanLyToolStripMenuItem.Text = "Quản Lý";
            // 
            // NhanVienToolStripMenuItem
            // 
            NhanVienToolStripMenuItem.Name = "NhanVienToolStripMenuItem";
            NhanVienToolStripMenuItem.Size = new Size(213, 30);
            NhanVienToolStripMenuItem.Text = "Nhân Viên";
            NhanVienToolStripMenuItem.Click += NhanVienToolStripMenuItem_Click;
            // 
            // NhaCungCapToolStripMenuItem
            // 
            NhaCungCapToolStripMenuItem.Name = "NhaCungCapToolStripMenuItem";
            NhaCungCapToolStripMenuItem.Size = new Size(213, 30);
            NhaCungCapToolStripMenuItem.Text = "Nhà Cung Cấp";
            NhaCungCapToolStripMenuItem.Click += NhaCungCapToolStripMenuItem_Click;
            // 
            // KhachHangToolStripMenuItem
            // 
            KhachHangToolStripMenuItem.Name = "KhachHangToolStripMenuItem";
            KhachHangToolStripMenuItem.Size = new Size(213, 30);
            KhachHangToolStripMenuItem.Text = "Khách Hàng";
            KhachHangToolStripMenuItem.Click += KhachHangToolStripMenuItem_Click;
            // 
            // MonToolStripMenuItem
            // 
            MonToolStripMenuItem.Name = "MonToolStripMenuItem";
            MonToolStripMenuItem.Size = new Size(213, 30);
            MonToolStripMenuItem.Text = "Món";
            MonToolStripMenuItem.Click += MonToolStripMenuItem_Click;
            // 
            // NguyenLieuToolStripMenuItem
            // 
            NguyenLieuToolStripMenuItem.Name = "NguyenLieuToolStripMenuItem";
            NguyenLieuToolStripMenuItem.Size = new Size(213, 30);
            NguyenLieuToolStripMenuItem.Text = "Nguyên Liệu";
            NguyenLieuToolStripMenuItem.Click += NguyenLieuToolStripMenuItem_Click;
            // 
            // LoHangToolStripMenuItem
            // 
            LoHangToolStripMenuItem.Name = "LoHangToolStripMenuItem";
            LoHangToolStripMenuItem.Size = new Size(213, 30);
            LoHangToolStripMenuItem.Text = "Lô Hàng";
            LoHangToolStripMenuItem.Click += LoHangToolStripMenuItem_Click;
            // 
            // QuanLyTraNoToolStripMenuItem
            // 
            QuanLyTraNoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TongNoToolStripMenuItem, CongNoToolStripMenuItem, TraNoToolStripMenuItem });
            QuanLyTraNoToolStripMenuItem.Name = "QuanLyTraNoToolStripMenuItem";
            QuanLyTraNoToolStripMenuItem.Size = new Size(98, 29);
            QuanLyTraNoToolStripMenuItem.Text = "Công Nợ";
            // 
            // TongNoToolStripMenuItem
            // 
            TongNoToolStripMenuItem.Name = "TongNoToolStripMenuItem";
            TongNoToolStripMenuItem.Size = new Size(224, 30);
            TongNoToolStripMenuItem.Text = "Tổng Nợ";
            TongNoToolStripMenuItem.Click += TongNoToolStripMenuItem_Click;
            // 
            // CongNoToolStripMenuItem
            // 
            CongNoToolStripMenuItem.Name = "CongNoToolStripMenuItem";
            CongNoToolStripMenuItem.Size = new Size(224, 30);
            CongNoToolStripMenuItem.Text = "Công Nợ";
            CongNoToolStripMenuItem.Click += CongNoToolStripMenuItem_Click;
            // 
            // TraNoToolStripMenuItem
            // 
            TraNoToolStripMenuItem.Name = "TraNoToolStripMenuItem";
            TraNoToolStripMenuItem.Size = new Size(224, 30);
            TraNoToolStripMenuItem.Text = "Trả Nợ";
            TraNoToolStripMenuItem.Click += TraNoToolStripMenuItem_Click;
            // 
            // DonNhanToolStripMenuItem
            // 
            DonNhanToolStripMenuItem.Name = "DonNhanToolStripMenuItem";
            DonNhanToolStripMenuItem.Size = new Size(107, 29);
            DonNhanToolStripMenuItem.Text = "Đơn Nhận";
            DonNhanToolStripMenuItem.Click += DonNhanToolStripMenuItem_Click;
            // 
            // DonBanToolStripMenuItem
            // 
            DonBanToolStripMenuItem.Name = "DonBanToolStripMenuItem";
            DonBanToolStripMenuItem.Size = new Size(94, 29);
            DonBanToolStripMenuItem.Text = "Đơn Bán";
            DonBanToolStripMenuItem.Click += DonBanToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { QuanLyToolStripMenuItem, QuanLyTraNoToolStripMenuItem, DonNhanToolStripMenuItem, DonBanToolStripMenuItem, DangXuatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1138, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // DangXuatToolStripMenuItem
            // 
            DangXuatToolStripMenuItem.Name = "DangXuatToolStripMenuItem";
            DangXuatToolStripMenuItem.Size = new Size(110, 29);
            DangXuatToolStripMenuItem.Text = "Đăng Xuất";
            DangXuatToolStripMenuItem.Click += DangXuattToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 668);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "frmMain";
            FormClosed += frmMain_FormClosed;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem QuanLyToolStripMenuItem;
        private ToolStripMenuItem NhanVienToolStripMenuItem;
        private ToolStripMenuItem NhaCungCapToolStripMenuItem;
        private ToolStripMenuItem KhachHangToolStripMenuItem;
        private ToolStripMenuItem MonToolStripMenuItem;
        private ToolStripMenuItem NguyenLieuToolStripMenuItem;
        private ToolStripMenuItem LoHangToolStripMenuItem;
        private ToolStripMenuItem QuanLyTraNoToolStripMenuItem;
        private ToolStripMenuItem TongNoToolStripMenuItem;
        private ToolStripMenuItem CongNoToolStripMenuItem;
        private ToolStripMenuItem TraNoToolStripMenuItem;
        private ToolStripMenuItem DonNhanToolStripMenuItem;
        private ToolStripMenuItem DonBanToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem DangXuatToolStripMenuItem;
    }
}