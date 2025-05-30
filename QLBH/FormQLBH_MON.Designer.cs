namespace WindowsFormsAppQLBH_MON
{
    partial class FormQLBH_MON
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
            lbl_MAMON = new Label();
            text_MAMON = new TextBox();
            lbl_TENMON = new Label();
            text_TENMON = new TextBox();
            lbl_GIABAN = new Label();
            text_GIABAN = new TextBox();
            lbl_DONVI = new Label();
            text_DONVI = new TextBox();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            DataGridView_MON = new DataGridView();
            lbl_BANGTEN = new Label();
            btn_TimKiem = new Button();
            btn_Huy = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView_MON).BeginInit();
            SuspendLayout();
            // 
            // lbl_MAMON
            // 
            lbl_MAMON.AutoSize = true;
            lbl_MAMON.BackColor = Color.Transparent;
            lbl_MAMON.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_MAMON.Location = new Point(47, 104);
            lbl_MAMON.Margin = new Padding(5, 0, 5, 0);
            lbl_MAMON.Name = "lbl_MAMON";
            lbl_MAMON.Size = new Size(91, 28);
            lbl_MAMON.TabIndex = 0;
            lbl_MAMON.Text = "Mã Món";
            // 
            // text_MAMON
            // 
            text_MAMON.Location = new Point(217, 104);
            text_MAMON.Margin = new Padding(5, 6, 5, 6);
            text_MAMON.Name = "text_MAMON";
            text_MAMON.Size = new Size(301, 31);
            text_MAMON.TabIndex = 0;
            // 
            // lbl_TENMON
            // 
            lbl_TENMON.AutoSize = true;
            lbl_TENMON.BackColor = Color.Transparent;
            lbl_TENMON.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_TENMON.Location = new Point(47, 167);
            lbl_TENMON.Margin = new Padding(5, 0, 5, 0);
            lbl_TENMON.Name = "lbl_TENMON";
            lbl_TENMON.Size = new Size(94, 28);
            lbl_TENMON.TabIndex = 0;
            lbl_TENMON.Text = "Tên Món";
            // 
            // text_TENMON
            // 
            text_TENMON.Location = new Point(217, 167);
            text_TENMON.Margin = new Padding(5, 6, 5, 6);
            text_TENMON.Name = "text_TENMON";
            text_TENMON.Size = new Size(301, 31);
            text_TENMON.TabIndex = 1;
            // 
            // lbl_GIABAN
            // 
            lbl_GIABAN.AutoSize = true;
            lbl_GIABAN.BackColor = Color.Transparent;
            lbl_GIABAN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_GIABAN.Location = new Point(639, 101);
            lbl_GIABAN.Margin = new Padding(5, 0, 5, 0);
            lbl_GIABAN.Name = "lbl_GIABAN";
            lbl_GIABAN.Size = new Size(85, 28);
            lbl_GIABAN.TabIndex = 0;
            lbl_GIABAN.Text = "Giá Bán";
            // 
            // text_GIABAN
            // 
            text_GIABAN.Location = new Point(809, 101);
            text_GIABAN.Margin = new Padding(5, 6, 5, 6);
            text_GIABAN.Name = "text_GIABAN";
            text_GIABAN.Size = new Size(170, 31);
            text_GIABAN.TabIndex = 2;
            // 
            // lbl_DONVI
            // 
            lbl_DONVI.AutoSize = true;
            lbl_DONVI.BackColor = Color.Transparent;
            lbl_DONVI.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_DONVI.Location = new Point(639, 167);
            lbl_DONVI.Margin = new Padding(5, 0, 5, 0);
            lbl_DONVI.Name = "lbl_DONVI";
            lbl_DONVI.Size = new Size(77, 28);
            lbl_DONVI.TabIndex = 0;
            lbl_DONVI.Text = "Đơn Vị";
            // 
            // text_DONVI
            // 
            text_DONVI.Location = new Point(809, 167);
            text_DONVI.Margin = new Padding(5, 6, 5, 6);
            text_DONVI.Name = "text_DONVI";
            text_DONVI.Size = new Size(170, 31);
            text_DONVI.TabIndex = 3;
            // 
            // btn_Them
            // 
            btn_Them.BackColor = SystemColors.ButtonFace;
            btn_Them.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Them.Location = new Point(86, 232);
            btn_Them.Margin = new Padding(5, 6, 5, 6);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(112, 47);
            btn_Them.TabIndex = 4;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Sua.Location = new Point(260, 232);
            btn_Sua.Margin = new Padding(5, 6, 5, 6);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(112, 47);
            btn_Sua.TabIndex = 5;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Xoa.Location = new Point(444, 232);
            btn_Xoa.Margin = new Padding(5, 6, 5, 6);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(112, 47);
            btn_Xoa.TabIndex = 6;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // DataGridView_MON
            // 
            DataGridView_MON.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_MON.Location = new Point(47, 310);
            DataGridView_MON.Margin = new Padding(5, 6, 5, 6);
            DataGridView_MON.Name = "DataGridView_MON";
            DataGridView_MON.RowHeadersWidth = 51;
            DataGridView_MON.Size = new Size(932, 342);
            DataGridView_MON.TabIndex = 0;
            // 
            // lbl_BANGTEN
            // 
            lbl_BANGTEN.AutoSize = true;
            lbl_BANGTEN.BackColor = Color.Transparent;
            lbl_BANGTEN.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_BANGTEN.Location = new Point(369, 22);
            lbl_BANGTEN.Margin = new Padding(5, 0, 5, 0);
            lbl_BANGTEN.Name = "lbl_BANGTEN";
            lbl_BANGTEN.Size = new Size(232, 41);
            lbl_BANGTEN.TabIndex = 12;
            lbl_BANGTEN.Text = "QUẢN LÝ MÓN";
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TimKiem.Location = new Point(843, 232);
            btn_TimKiem.Margin = new Padding(5, 6, 5, 6);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(112, 47);
            btn_TimKiem.TabIndex = 13;
            btn_TimKiem.Text = "Tìm Kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // btn_Huy
            // 
            btn_Huy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Huy.Location = new Point(639, 232);
            btn_Huy.Margin = new Padding(5, 6, 5, 6);
            btn_Huy.Name = "btn_Huy";
            btn_Huy.Size = new Size(112, 47);
            btn_Huy.TabIndex = 14;
            btn_Huy.Text = "Hủy";
            btn_Huy.UseVisualStyleBackColor = true;
            btn_Huy.Click += btn_Huy_Click;
            // 
            // FormQLBH_MON
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1019, 677);
            Controls.Add(btn_Huy);
            Controls.Add(btn_TimKiem);
            Controls.Add(lbl_BANGTEN);
            Controls.Add(DataGridView_MON);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(text_DONVI);
            Controls.Add(lbl_DONVI);
            Controls.Add(text_GIABAN);
            Controls.Add(lbl_GIABAN);
            Controls.Add(text_TENMON);
            Controls.Add(lbl_TENMON);
            Controls.Add(text_MAMON);
            Controls.Add(lbl_MAMON);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormQLBH_MON";
            Text = " QLBH_MON";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)DataGridView_MON).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MAMON;
        private System.Windows.Forms.TextBox text_MAMON;
        private System.Windows.Forms.Label lbl_TENMON;
        private System.Windows.Forms.TextBox text_TENMON;
        private System.Windows.Forms.Label lbl_GIABAN;
        private System.Windows.Forms.TextBox text_GIABAN;
        private System.Windows.Forms.Label lbl_DONVI;
        private System.Windows.Forms.TextBox text_DONVI;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView DataGridView_MON;
        private System.Windows.Forms.Label lbl_BANGTEN;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Huy;
    }
}

