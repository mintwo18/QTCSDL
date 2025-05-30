namespace NhapHang
{
    partial class frmCONGNO
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lbMACN = new Label();
            txtMACN = new TextBox();
            lbMDDH = new Label();
            txtMADDH = new TextBox();
            lbSTN = new Label();
            lbSTT = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtSOTIENNO = new TextBox();
            dataGridViewCONGNO = new DataGridView();
            lbQLCN = new Label();
            txtSOTIENTRA = new TextBox();
            dtpNGAYNO = new DateTimePicker();
            lbNN = new Label();
            lbPTTT = new Label();
            chkTIENMAT = new CheckBox();
            chkCHUYENKHOAN = new CheckBox();
            btnTimKiem = new Button();
            btnHuy = new Button();
            lbSOTIENTRATHEM = new Label();
            txtSOTIENTRATHEM = new TextBox();
            btnThanhToanThem = new Button();
            btnKiemTraHanTra = new Button();
            btnXoaDuLieuCu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCONGNO).BeginInit();
            SuspendLayout();
            // 
            // lbMACN
            // 
            lbMACN.AutoSize = true;
            lbMACN.FlatStyle = FlatStyle.System;
            lbMACN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMACN.ForeColor = SystemColors.ActiveCaptionText;
            lbMACN.Location = new Point(31, 86);
            lbMACN.Margin = new Padding(4, 0, 4, 0);
            lbMACN.Name = "lbMACN";
            lbMACN.Size = new Size(131, 28);
            lbMACN.TabIndex = 0;
            lbMACN.Text = "Mã Công Nợ";
            // 
            // txtMACN
            // 
            txtMACN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMACN.Location = new Point(201, 88);
            txtMACN.Margin = new Padding(4, 5, 4, 5);
            txtMACN.Name = "txtMACN";
            txtMACN.Size = new Size(270, 34);
            txtMACN.TabIndex = 0;
            // 
            // lbMDDH
            // 
            lbMDDH.AutoSize = true;
            lbMDDH.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMDDH.Location = new Point(27, 142);
            lbMDDH.Margin = new Padding(4, 0, 4, 0);
            lbMDDH.Name = "lbMDDH";
            lbMDDH.Size = new Size(93, 28);
            lbMDDH.TabIndex = 2;
            lbMDDH.Text = "Mã DDH";
            // 
            // txtMADDH
            // 
            txtMADDH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMADDH.Location = new Point(201, 144);
            txtMADDH.Margin = new Padding(4, 5, 4, 5);
            txtMADDH.Name = "txtMADDH";
            txtMADDH.Size = new Size(269, 34);
            txtMADDH.TabIndex = 1;
            // 
            // lbSTN
            // 
            lbSTN.AutoSize = true;
            lbSTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSTN.Location = new Point(27, 202);
            lbSTN.Margin = new Padding(4, 0, 4, 0);
            lbSTN.Name = "lbSTN";
            lbSTN.Size = new Size(117, 28);
            lbSTN.TabIndex = 4;
            lbSTN.Text = "Số Tiền Nợ";
            // 
            // lbSTT
            // 
            lbSTT.AutoSize = true;
            lbSTT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSTT.Location = new Point(27, 267);
            lbSTT.Margin = new Padding(4, 0, 4, 0);
            lbSTT.Name = "lbSTT";
            lbSTT.Size = new Size(117, 28);
            lbSTT.TabIndex = 5;
            lbSTT.Text = "Số Tiền Trả";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(57, 333);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(107, 45);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(273, 332);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(107, 47);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(512, 332);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(107, 47);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtSOTIENNO
            // 
            txtSOTIENNO.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSOTIENNO.Location = new Point(201, 204);
            txtSOTIENNO.Margin = new Padding(4, 5, 4, 5);
            txtSOTIENNO.Name = "txtSOTIENNO";
            txtSOTIENNO.Size = new Size(270, 34);
            txtSOTIENNO.TabIndex = 2;
            // 
            // dataGridViewCONGNO
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCONGNO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCONGNO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCONGNO.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCONGNO.Location = new Point(37, 416);
            dataGridViewCONGNO.Margin = new Padding(4);
            dataGridViewCONGNO.Name = "dataGridViewCONGNO";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewCONGNO.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCONGNO.RowHeadersWidth = 51;
            dataGridViewCONGNO.Size = new Size(820, 260);
            dataGridViewCONGNO.TabIndex = 10;
            dataGridViewCONGNO.CellClick += dataGridView1_CellClick;
            // 
            // lbQLCN
            // 
            lbQLCN.AutoSize = true;
            lbQLCN.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbQLCN.Location = new Point(408, 22);
            lbQLCN.Margin = new Padding(4, 0, 4, 0);
            lbQLCN.Name = "lbQLCN";
            lbQLCN.Size = new Size(297, 41);
            lbQLCN.TabIndex = 11;
            lbQLCN.Text = "QUẢN LÝ CÔNG NỢ";
            // 
            // txtSOTIENTRA
            // 
            txtSOTIENTRA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSOTIENTRA.Location = new Point(200, 269);
            txtSOTIENTRA.Name = "txtSOTIENTRA";
            txtSOTIENTRA.Size = new Size(270, 34);
            txtSOTIENTRA.TabIndex = 3;
            // 
            // dtpNGAYNO
            // 
            dtpNGAYNO.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNGAYNO.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNGAYNO.Location = new Point(781, 80);
            dtpNGAYNO.Name = "dtpNGAYNO";
            dtpNGAYNO.Size = new Size(289, 34);
            dtpNGAYNO.TabIndex = 4;
            // 
            // lbNN
            // 
            lbNN.AutoSize = true;
            lbNN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNN.Location = new Point(599, 86);
            lbNN.Name = "lbNN";
            lbNN.Size = new Size(97, 28);
            lbNN.TabIndex = 14;
            lbNN.Text = "Ngày Nợ";
            // 
            // lbPTTT
            // 
            lbPTTT.AutoSize = true;
            lbPTTT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPTTT.Location = new Point(599, 142);
            lbPTTT.Name = "lbPTTT";
            lbPTTT.Size = new Size(60, 28);
            lbPTTT.TabIndex = 15;
            lbPTTT.Text = "PTTT";
            // 
            // chkTIENMAT
            // 
            chkTIENMAT.AutoSize = true;
            chkTIENMAT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTIENMAT.Location = new Point(781, 141);
            chkTIENMAT.Name = "chkTIENMAT";
            chkTIENMAT.Size = new Size(109, 32);
            chkTIENMAT.TabIndex = 5;
            chkTIENMAT.Text = "Tiền mặt";
            chkTIENMAT.UseVisualStyleBackColor = true;
            chkTIENMAT.CheckedChanged += chkTIENMAT_CheckedChanged;
            // 
            // chkCHUYENKHOAN
            // 
            chkCHUYENKHOAN.AutoSize = true;
            chkCHUYENKHOAN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkCHUYENKHOAN.Location = new Point(939, 141);
            chkCHUYENKHOAN.Name = "chkCHUYENKHOAN";
            chkCHUYENKHOAN.Size = new Size(158, 32);
            chkCHUYENKHOAN.TabIndex = 6;
            chkCHUYENKHOAN.Text = "Chuyển khoản";
            chkCHUYENKHOAN.UseVisualStyleBackColor = true;
            chkCHUYENKHOAN.CheckedChanged += chkCHUYENKHOAN_CheckedChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimKiem.Location = new Point(956, 332);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(106, 47);
            btnTimKiem.TabIndex = 16;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(752, 332);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(107, 47);
            btnHuy.TabIndex = 17;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // lbSOTIENTRATHEM
            // 
            lbSOTIENTRATHEM.AutoSize = true;
            lbSOTIENTRATHEM.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSOTIENTRATHEM.Location = new Point(599, 202);
            lbSOTIENTRATHEM.Name = "lbSOTIENTRATHEM";
            lbSOTIENTRATHEM.Size = new Size(176, 28);
            lbSOTIENTRATHEM.TabIndex = 18;
            lbSOTIENTRATHEM.Text = "Số Tiền Trả Thêm";
            // 
            // txtSOTIENTRATHEM
            // 
            txtSOTIENTRATHEM.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSOTIENTRATHEM.Location = new Point(781, 204);
            txtSOTIENTRATHEM.Name = "txtSOTIENTRATHEM";
            txtSOTIENTRATHEM.Size = new Size(289, 30);
            txtSOTIENTRATHEM.TabIndex = 19;
            // 
            // btnThanhToanThem
            // 
            btnThanhToanThem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThanhToanThem.Location = new Point(721, 258);
            btnThanhToanThem.Name = "btnThanhToanThem";
            btnThanhToanThem.Size = new Size(206, 47);
            btnThanhToanThem.TabIndex = 20;
            btnThanhToanThem.Text = "Thanh toán thêm";
            btnThanhToanThem.UseVisualStyleBackColor = true;
            btnThanhToanThem.Click += btnThanhToanThem_Click;
            // 
            // btnKiemTraHanTra
            // 
            btnKiemTraHanTra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKiemTraHanTra.Location = new Point(873, 470);
            btnKiemTraHanTra.Name = "btnKiemTraHanTra";
            btnKiemTraHanTra.Size = new Size(209, 53);
            btnKiemTraHanTra.TabIndex = 21;
            btnKiemTraHanTra.Text = "Kiểm tra hạn trả nợ";
            btnKiemTraHanTra.UseVisualStyleBackColor = true;
            btnKiemTraHanTra.Click += btnKiemTraHanTra_Click;
            // 
            // btnXoaDuLieuCu
            // 
            btnXoaDuLieuCu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoaDuLieuCu.Location = new Point(925, 554);
            btnXoaDuLieuCu.Name = "btnXoaDuLieuCu";
            btnXoaDuLieuCu.Size = new Size(107, 50);
            btnXoaDuLieuCu.TabIndex = 22;
            btnXoaDuLieuCu.Text = "Xóa DL cũ";
            btnXoaDuLieuCu.UseVisualStyleBackColor = true;
            btnXoaDuLieuCu.Click += btnXoaDuLieuCu_Click;
            // 
            // frmCONGNO
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1110, 690);
            Controls.Add(btnXoaDuLieuCu);
            Controls.Add(btnKiemTraHanTra);
            Controls.Add(btnThanhToanThem);
            Controls.Add(txtSOTIENTRATHEM);
            Controls.Add(lbSOTIENTRATHEM);
            Controls.Add(btnHuy);
            Controls.Add(btnTimKiem);
            Controls.Add(chkCHUYENKHOAN);
            Controls.Add(chkTIENMAT);
            Controls.Add(lbPTTT);
            Controls.Add(lbNN);
            Controls.Add(dtpNGAYNO);
            Controls.Add(txtSOTIENTRA);
            Controls.Add(lbQLCN);
            Controls.Add(dataGridViewCONGNO);
            Controls.Add(txtSOTIENNO);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(lbSTT);
            Controls.Add(lbSTN);
            Controls.Add(txtMADDH);
            Controls.Add(lbMDDH);
            Controls.Add(txtMACN);
            Controls.Add(lbMACN);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmCONGNO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Công Nợ";
            Load += frmCONGNO_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCONGNO).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMACN;
        private System.Windows.Forms.TextBox txtMACN;
        private System.Windows.Forms.Label lbMDDH;
        private System.Windows.Forms.TextBox txtMADDH;
        private System.Windows.Forms.Label lbSTN;
        private System.Windows.Forms.Label lbSTT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtSOTIENNO;
        private System.Windows.Forms.DataGridView dataGridViewCONGNO;
        private System.Windows.Forms.Label lbQLCN;
        private System.Windows.Forms.TextBox txtSOTIENTRA;
        private System.Windows.Forms.DateTimePicker dtpNGAYNO;
        private System.Windows.Forms.Label lbNN;
        private System.Windows.Forms.Label lbPTTT;
        private System.Windows.Forms.CheckBox chkTIENMAT;
        private System.Windows.Forms.CheckBox chkCHUYENKHOAN;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lbSOTIENTRATHEM;
        private System.Windows.Forms.TextBox txtSOTIENTRATHEM;
        private System.Windows.Forms.Button btnThanhToanThem;
        private System.Windows.Forms.Button btnKiemTraHanTra;
        private System.Windows.Forms.Button btnXoaDuLieuCu;
    }
}

