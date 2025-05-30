namespace NhapHang
{
    partial class frmTONGNO
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lbMANCC = new Label();
            txtMANCC = new TextBox();
            lbTONGNO = new Label();
            txtTONGNO = new TextBox();
            lbNOCU = new Label();
            txtNOCU = new TextBox();
            lbQLTN = new Label();
            dataGridViewTONGNO = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnHuy = new Button();
            btnTimKiem = new Button();
            dataGridViewThongKe = new DataGridView();
            btnThongKeNo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTONGNO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewThongKe).BeginInit();
            SuspendLayout();
            // 
            // lbMANCC
            // 
            lbMANCC.AutoSize = true;
            lbMANCC.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbMANCC.Location = new Point(32, 96);
            lbMANCC.Margin = new Padding(4, 0, 4, 0);
            lbMANCC.Name = "lbMANCC";
            lbMANCC.Size = new Size(87, 28);
            lbMANCC.TabIndex = 0;
            lbMANCC.Text = "Mã NCC\r\n";
            // 
            // txtMANCC
            // 
            txtMANCC.Font = new Font("Segoe UI", 10.8F);
            txtMANCC.Location = new Point(203, 96);
            txtMANCC.Margin = new Padding(4, 5, 4, 5);
            txtMANCC.Name = "txtMANCC";
            txtMANCC.Size = new Size(238, 31);
            txtMANCC.TabIndex = 1;
            // 
            // lbTONGNO
            // 
            lbTONGNO.AutoSize = true;
            lbTONGNO.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbTONGNO.Location = new Point(32, 170);
            lbTONGNO.Margin = new Padding(4, 0, 4, 0);
            lbTONGNO.Name = "lbTONGNO";
            lbTONGNO.Size = new Size(95, 28);
            lbTONGNO.TabIndex = 2;
            lbTONGNO.Text = "Tổng Nợ";
            // 
            // txtTONGNO
            // 
            txtTONGNO.Font = new Font("Segoe UI", 10.8F);
            txtTONGNO.Location = new Point(203, 170);
            txtTONGNO.Margin = new Padding(4, 5, 4, 5);
            txtTONGNO.Name = "txtTONGNO";
            txtTONGNO.Size = new Size(238, 31);
            txtTONGNO.TabIndex = 3;
            // 
            // lbNOCU
            // 
            lbNOCU.AutoSize = true;
            lbNOCU.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbNOCU.Location = new Point(32, 244);
            lbNOCU.Margin = new Padding(4, 0, 4, 0);
            lbNOCU.Name = "lbNOCU";
            lbNOCU.Size = new Size(71, 28);
            lbNOCU.TabIndex = 4;
            lbNOCU.Text = "Nợ Cũ";
            // 
            // txtNOCU
            // 
            txtNOCU.Font = new Font("Segoe UI", 10.8F);
            txtNOCU.Location = new Point(203, 244);
            txtNOCU.Margin = new Padding(4, 5, 4, 5);
            txtNOCU.Name = "txtNOCU";
            txtNOCU.Size = new Size(238, 31);
            txtNOCU.TabIndex = 5;
            // 
            // lbQLTN
            // 
            lbQLTN.AutoSize = true;
            lbQLTN.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbQLTN.Location = new Point(327, 22);
            lbQLTN.Margin = new Padding(4, 0, 4, 0);
            lbQLTN.Name = "lbQLTN";
            lbQLTN.Size = new Size(297, 41);
            lbQLTN.TabIndex = 6;
            lbQLTN.Text = "QUẢN LÝ TỔNG NỢ";
            // 
            // dataGridViewTONGNO
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTONGNO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTONGNO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewTONGNO.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTONGNO.Location = new Point(479, 79);
            dataGridViewTONGNO.Margin = new Padding(4);
            dataGridViewTONGNO.Name = "dataGridViewTONGNO";
            dataGridViewTONGNO.RowHeadersWidth = 51;
            dataGridViewTONGNO.Size = new Size(447, 358);
            dataGridViewTONGNO.TabIndex = 7;
            dataGridViewTONGNO.CellContentClick += dataGridView1_CellClick;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F);
            btnThem.Location = new Point(24, 319);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(114, 48);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 12F);
            btnSua.Location = new Point(181, 320);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(114, 47);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F);
            btnXoa.Location = new Point(327, 320);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(114, 47);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 12F);
            btnHuy.Location = new Point(181, 389);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(114, 47);
            btnHuy.TabIndex = 11;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 12F);
            btnTimKiem.Location = new Point(24, 390);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(114, 47);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dataGridViewThongKe
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewThongKe.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewThongKe.Location = new Point(24, 478);
            dataGridViewThongKe.Name = "dataGridViewThongKe";
            dataGridViewThongKe.RowHeadersWidth = 51;
            dataGridViewThongKe.Size = new Size(902, 233);
            dataGridViewThongKe.TabIndex = 13;
            // 
            // btnThongKeNo
            // 
            btnThongKeNo.Font = new Font("Segoe UI", 12F);
            btnThongKeNo.Location = new Point(327, 388);
            btnThongKeNo.Name = "btnThongKeNo";
            btnThongKeNo.Size = new Size(132, 48);
            btnThongKeNo.TabIndex = 14;
            btnThongKeNo.Text = "Thống kê nợ";
            btnThongKeNo.UseVisualStyleBackColor = true;
            btnThongKeNo.Click += btnThongKeNo_Click;
            // 
            // frmTONGNO
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(951, 723);
            Controls.Add(btnThongKeNo);
            Controls.Add(dataGridViewThongKe);
            Controls.Add(btnTimKiem);
            Controls.Add(btnHuy);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dataGridViewTONGNO);
            Controls.Add(lbQLTN);
            Controls.Add(txtNOCU);
            Controls.Add(lbNOCU);
            Controls.Add(txtTONGNO);
            Controls.Add(lbTONGNO);
            Controls.Add(txtMANCC);
            Controls.Add(lbMANCC);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmTONGNO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý tổng nợ";
            Load += frmTONGNO_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTONGNO).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewThongKe).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMANCC;
        private System.Windows.Forms.TextBox txtMANCC;
        private System.Windows.Forms.Label lbTONGNO;
        private System.Windows.Forms.TextBox txtTONGNO;
        private System.Windows.Forms.Label lbNOCU;
        private System.Windows.Forms.TextBox txtNOCU;
        private System.Windows.Forms.Label lbQLTN;
        private System.Windows.Forms.DataGridView dataGridViewTONGNO;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewThongKe;
        private System.Windows.Forms.Button btnThongKeNo;
    }
}