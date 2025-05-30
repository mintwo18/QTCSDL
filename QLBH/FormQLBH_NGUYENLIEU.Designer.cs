namespace WindowsFormsAppQLBH_NGUYENLIEU
{
    partial class FormQLBH_NGUYENLIEU
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
            lbl_MANL = new Label();
            txt_MANL = new TextBox();
            lbl_TENNL = new Label();
            txt_TENNL = new TextBox();
            lbl_DONVI = new Label();
            txt_DONVI = new TextBox();
            lbl_SLTONKHO = new Label();
            txt_SLTONKHO = new TextBox();
            lbl_BANGTEN = new Label();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            DataGridViewNGUYENLIEU = new DataGridView();
            btn_TimKiem = new Button();
            btn_Huy = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewNGUYENLIEU).BeginInit();
            SuspendLayout();
            // 
            // lbl_MANL
            // 
            lbl_MANL.AutoSize = true;
            lbl_MANL.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_MANL.Location = new Point(36, 106);
            lbl_MANL.Margin = new Padding(5, 0, 5, 0);
            lbl_MANL.Name = "lbl_MANL";
            lbl_MANL.Size = new Size(167, 28);
            lbl_MANL.TabIndex = 0;
            lbl_MANL.Text = "Mã Nguyên Liệu";
            // 
            // txt_MANL
            // 
            txt_MANL.Location = new Point(305, 103);
            txt_MANL.Margin = new Padding(5, 6, 5, 6);
            txt_MANL.Name = "txt_MANL";
            txt_MANL.Size = new Size(282, 31);
            txt_MANL.TabIndex = 0;
            // 
            // lbl_TENNL
            // 
            lbl_TENNL.AutoSize = true;
            lbl_TENNL.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_TENNL.Location = new Point(36, 163);
            lbl_TENNL.Margin = new Padding(5, 0, 5, 0);
            lbl_TENNL.Name = "lbl_TENNL";
            lbl_TENNL.Size = new Size(170, 28);
            lbl_TENNL.TabIndex = 0;
            lbl_TENNL.Text = "Tên Nguyên Liệu";
            // 
            // txt_TENNL
            // 
            txt_TENNL.Location = new Point(305, 163);
            txt_TENNL.Margin = new Padding(5, 6, 5, 6);
            txt_TENNL.Name = "txt_TENNL";
            txt_TENNL.Size = new Size(282, 31);
            txt_TENNL.TabIndex = 1;
            // 
            // lbl_DONVI
            // 
            lbl_DONVI.AutoSize = true;
            lbl_DONVI.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_DONVI.Location = new Point(674, 103);
            lbl_DONVI.Margin = new Padding(5, 0, 5, 0);
            lbl_DONVI.Name = "lbl_DONVI";
            lbl_DONVI.Size = new Size(77, 28);
            lbl_DONVI.TabIndex = 0;
            lbl_DONVI.Text = "Đơn Vị";
            // 
            // txt_DONVI
            // 
            txt_DONVI.Location = new Point(901, 103);
            txt_DONVI.Margin = new Padding(5, 6, 5, 6);
            txt_DONVI.Name = "txt_DONVI";
            txt_DONVI.Size = new Size(164, 31);
            txt_DONVI.TabIndex = 2;
            // 
            // lbl_SLTONKHO
            // 
            lbl_SLTONKHO.AutoSize = true;
            lbl_SLTONKHO.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_SLTONKHO.Location = new Point(674, 167);
            lbl_SLTONKHO.Margin = new Padding(5, 0, 5, 0);
            lbl_SLTONKHO.Name = "lbl_SLTONKHO";
            lbl_SLTONKHO.Size = new Size(182, 28);
            lbl_SLTONKHO.TabIndex = 0;
            lbl_SLTONKHO.Text = "Số lượng Tồn Kho";
            // 
            // txt_SLTONKHO
            // 
            txt_SLTONKHO.Location = new Point(901, 164);
            txt_SLTONKHO.Margin = new Padding(5, 6, 5, 6);
            txt_SLTONKHO.Name = "txt_SLTONKHO";
            txt_SLTONKHO.Size = new Size(164, 31);
            txt_SLTONKHO.TabIndex = 3;
            // 
            // lbl_BANGTEN
            // 
            lbl_BANGTEN.AutoSize = true;
            lbl_BANGTEN.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_BANGTEN.Location = new Point(365, 24);
            lbl_BANGTEN.Margin = new Padding(5, 0, 5, 0);
            lbl_BANGTEN.Name = "lbl_BANGTEN";
            lbl_BANGTEN.Size = new Size(352, 41);
            lbl_BANGTEN.TabIndex = 0;
            lbl_BANGTEN.Text = "QUẢN LÝ NGUYÊN LIỆU";
            // 
            // btn_Them
            // 
            btn_Them.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Them.Location = new Point(52, 232);
            btn_Them.Margin = new Padding(5, 6, 5, 6);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(107, 44);
            btn_Them.TabIndex = 4;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            btn_Sua.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Sua.Location = new Point(256, 231);
            btn_Sua.Margin = new Padding(5, 6, 5, 6);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(107, 44);
            btn_Sua.TabIndex = 5;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Xoa.Location = new Point(480, 231);
            btn_Xoa.Margin = new Padding(5, 6, 5, 6);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(107, 44);
            btn_Xoa.TabIndex = 6;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // DataGridViewNGUYENLIEU
            // 
            DataGridViewNGUYENLIEU.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewNGUYENLIEU.Location = new Point(36, 310);
            DataGridViewNGUYENLIEU.Margin = new Padding(5, 6, 5, 6);
            DataGridViewNGUYENLIEU.Name = "DataGridViewNGUYENLIEU";
            DataGridViewNGUYENLIEU.RowHeadersWidth = 51;
            DataGridViewNGUYENLIEU.Size = new Size(1029, 274);
            DataGridViewNGUYENLIEU.TabIndex = 0;
            DataGridViewNGUYENLIEU.TabStop = false;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TimKiem.Location = new Point(865, 229);
            btn_TimKiem.Margin = new Padding(5, 6, 5, 6);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(107, 44);
            btn_TimKiem.TabIndex = 7;
            btn_TimKiem.Text = "Tìm Kiếm ";
            btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // btn_Huy
            // 
            btn_Huy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Huy.Location = new Point(674, 232);
            btn_Huy.Margin = new Padding(5, 6, 5, 6);
            btn_Huy.Name = "btn_Huy";
            btn_Huy.Size = new Size(107, 43);
            btn_Huy.TabIndex = 8;
            btn_Huy.Text = "Hủy";
            btn_Huy.UseVisualStyleBackColor = true;
            btn_Huy.Click += btn_Huy_Click;
            // 
            // FormQLBH_NGUYENLIEU
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1100, 606);
            Controls.Add(btn_Huy);
            Controls.Add(btn_TimKiem);
            Controls.Add(DataGridViewNGUYENLIEU);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(lbl_BANGTEN);
            Controls.Add(txt_SLTONKHO);
            Controls.Add(lbl_SLTONKHO);
            Controls.Add(txt_DONVI);
            Controls.Add(lbl_DONVI);
            Controls.Add(txt_TENNL);
            Controls.Add(lbl_TENNL);
            Controls.Add(txt_MANL);
            Controls.Add(lbl_MANL);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormQLBH_NGUYENLIEU";
            Text = "QLBH_NGUYENLIEU";
            Load += FormQLBH_NGUYENLIEU_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewNGUYENLIEU).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MANL;
        private System.Windows.Forms.TextBox txt_MANL;
        private System.Windows.Forms.Label lbl_TENNL;
        private System.Windows.Forms.TextBox txt_TENNL;
        private System.Windows.Forms.Label lbl_DONVI;
        private System.Windows.Forms.TextBox txt_DONVI;
        private System.Windows.Forms.Label lbl_SLTONKHO;
        private System.Windows.Forms.TextBox txt_SLTONKHO;
        private System.Windows.Forms.Label lbl_BANGTEN;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView DataGridViewNGUYENLIEU;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Huy;
    }
}


