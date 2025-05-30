namespace WindowsFormsAppQLBH_LOHANG
{
    partial class FormLOHANG
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
            lbl_MALH = new Label();
            txt_MALH = new TextBox();
            lbl_HSD = new Label();
            DateTime_HSD = new DateTimePicker();
            lbl_GIANHAN = new Label();
            txt_GIANHAN = new TextBox();
            lbl_MANL = new Label();
            txt_MANL = new TextBox();
            lbl_BANGTEN = new Label();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            DataGridView_LOHANG = new DataGridView();
            DataGridView_ThongBaoHetHan = new DataGridView();
            btn_ThongBao = new Button();
            btn_Huy = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView_LOHANG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_ThongBaoHetHan).BeginInit();
            SuspendLayout();
            // 
            // lbl_MALH
            // 
            lbl_MALH.AutoSize = true;
            lbl_MALH.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_MALH.Location = new Point(78, 92);
            lbl_MALH.Margin = new Padding(5, 0, 5, 0);
            lbl_MALH.Name = "lbl_MALH";
            lbl_MALH.Size = new Size(126, 28);
            lbl_MALH.TabIndex = 0;
            lbl_MALH.Text = "Mã Lô Hàng";
            // 
            // txt_MALH
            // 
            txt_MALH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_MALH.Location = new Point(368, 86);
            txt_MALH.Margin = new Padding(5, 6, 5, 6);
            txt_MALH.Name = "txt_MALH";
            txt_MALH.Size = new Size(354, 34);
            txt_MALH.TabIndex = 0;
            // 
            // lbl_HSD
            // 
            lbl_HSD.AutoSize = true;
            lbl_HSD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_HSD.Location = new Point(78, 153);
            lbl_HSD.Margin = new Padding(5, 0, 5, 0);
            lbl_HSD.Name = "lbl_HSD";
            lbl_HSD.Size = new Size(137, 28);
            lbl_HSD.TabIndex = 0;
            lbl_HSD.Text = "Hạn Sử Dụng";
            // 
            // DateTime_HSD
            // 
            DateTime_HSD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateTime_HSD.Location = new Point(368, 148);
            DateTime_HSD.Margin = new Padding(5, 6, 5, 6);
            DateTime_HSD.Name = "DateTime_HSD";
            DateTime_HSD.Size = new Size(354, 34);
            DateTime_HSD.TabIndex = 1;
            // 
            // lbl_GIANHAN
            // 
            lbl_GIANHAN.AutoSize = true;
            lbl_GIANHAN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_GIANHAN.Location = new Point(78, 217);
            lbl_GIANHAN.Margin = new Padding(5, 0, 5, 0);
            lbl_GIANHAN.Name = "lbl_GIANHAN";
            lbl_GIANHAN.Size = new Size(100, 28);
            lbl_GIANHAN.TabIndex = 0;
            lbl_GIANHAN.Text = "Giá Nhận";
            // 
            // txt_GIANHAN
            // 
            txt_GIANHAN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_GIANHAN.Location = new Point(368, 214);
            txt_GIANHAN.Margin = new Padding(5, 6, 5, 6);
            txt_GIANHAN.Name = "txt_GIANHAN";
            txt_GIANHAN.Size = new Size(354, 34);
            txt_GIANHAN.TabIndex = 2;
            // 
            // lbl_MANL
            // 
            lbl_MANL.AutoSize = true;
            lbl_MANL.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_MANL.Location = new Point(78, 283);
            lbl_MANL.Margin = new Padding(5, 0, 5, 0);
            lbl_MANL.Name = "lbl_MANL";
            lbl_MANL.Size = new Size(167, 28);
            lbl_MANL.TabIndex = 0;
            lbl_MANL.Text = "Mã Nguyên Liệu";
            // 
            // txt_MANL
            // 
            txt_MANL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_MANL.Location = new Point(368, 280);
            txt_MANL.Margin = new Padding(5, 6, 5, 6);
            txt_MANL.Name = "txt_MANL";
            txt_MANL.Size = new Size(354, 34);
            txt_MANL.TabIndex = 3;
            // 
            // lbl_BANGTEN
            // 
            lbl_BANGTEN.AutoSize = true;
            lbl_BANGTEN.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_BANGTEN.Location = new Point(240, 18);
            lbl_BANGTEN.Margin = new Padding(5, 0, 5, 0);
            lbl_BANGTEN.Name = "lbl_BANGTEN";
            lbl_BANGTEN.Size = new Size(290, 41);
            lbl_BANGTEN.TabIndex = 0;
            lbl_BANGTEN.Text = "QUẢN LÝ LÔ HÀNG";
            // 
            // btn_Them
            // 
            btn_Them.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Them.Location = new Point(34, 351);
            btn_Them.Margin = new Padding(5, 6, 5, 6);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(107, 48);
            btn_Them.TabIndex = 4;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            btn_Sua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Sua.Location = new Point(190, 351);
            btn_Sua.Margin = new Padding(5, 6, 5, 6);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(107, 48);
            btn_Sua.TabIndex = 5;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Xoa.Location = new Point(335, 351);
            btn_Xoa.Margin = new Padding(5, 6, 5, 6);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(107, 48);
            btn_Xoa.TabIndex = 6;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // DataGridView_LOHANG
            // 
            DataGridView_LOHANG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_LOHANG.Location = new Point(34, 437);
            DataGridView_LOHANG.Margin = new Padding(5, 6, 5, 6);
            DataGridView_LOHANG.Name = "DataGridView_LOHANG";
            DataGridView_LOHANG.RowHeadersWidth = 51;
            DataGridView_LOHANG.Size = new Size(725, 306);
            DataGridView_LOHANG.TabIndex = 0;
            DataGridView_LOHANG.TabStop = false;
            DataGridView_LOHANG.CellContentClick += DataGridView_LOHANG_CellContentClick;
            // 
            // DataGridView_ThongBaoHetHan
            // 
            DataGridView_ThongBaoHetHan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_ThongBaoHetHan.Location = new Point(34, 437);
            DataGridView_ThongBaoHetHan.Margin = new Padding(5, 6, 5, 6);
            DataGridView_ThongBaoHetHan.Name = "DataGridView_ThongBaoHetHan";
            DataGridView_ThongBaoHetHan.RowHeadersWidth = 51;
            DataGridView_ThongBaoHetHan.Size = new Size(725, 306);
            DataGridView_ThongBaoHetHan.TabIndex = 7;
            // 
            // btn_ThongBao
            // 
            btn_ThongBao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ThongBao.Location = new Point(636, 351);
            btn_ThongBao.Margin = new Padding(5, 6, 5, 6);
            btn_ThongBao.Name = "btn_ThongBao";
            btn_ThongBao.Size = new Size(123, 48);
            btn_ThongBao.TabIndex = 7;
            btn_ThongBao.Text = "TB Hết Hạn";
            btn_ThongBao.UseVisualStyleBackColor = true;
            // 
            // btn_Huy
            // 
            btn_Huy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Huy.Location = new Point(487, 351);
            btn_Huy.Margin = new Padding(5, 6, 5, 6);
            btn_Huy.Name = "btn_Huy";
            btn_Huy.Size = new Size(107, 48);
            btn_Huy.TabIndex = 8;
            btn_Huy.Text = "Hủy";
            btn_Huy.UseVisualStyleBackColor = true;
            btn_Huy.Click += btn_Huy_Click;
            // 
            // FormLOHANG
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(808, 760);
            Controls.Add(btn_Huy);
            Controls.Add(btn_ThongBao);
            Controls.Add(DataGridView_ThongBaoHetHan);
            Controls.Add(DataGridView_LOHANG);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(lbl_BANGTEN);
            Controls.Add(txt_MANL);
            Controls.Add(lbl_MANL);
            Controls.Add(txt_GIANHAN);
            Controls.Add(lbl_GIANHAN);
            Controls.Add(DateTime_HSD);
            Controls.Add(lbl_HSD);
            Controls.Add(txt_MALH);
            Controls.Add(lbl_MALH);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormLOHANG";
            Text = "QLBH_LOHANG";
            ((System.ComponentModel.ISupportInitialize)DataGridView_LOHANG).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_ThongBaoHetHan).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MALH;
        private System.Windows.Forms.TextBox txt_MALH;
        private System.Windows.Forms.Label lbl_HSD;
        private System.Windows.Forms.DateTimePicker DateTime_HSD;
        private System.Windows.Forms.Label lbl_GIANHAN;
        private System.Windows.Forms.TextBox txt_GIANHAN;
        private System.Windows.Forms.Label lbl_MANL;
        private System.Windows.Forms.TextBox txt_MANL;
        private System.Windows.Forms.Label lbl_BANGTEN;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView DataGridView_LOHANG;
        private System.Windows.Forms.DataGridView DataGridView_ThongBaoHetHan;
        private System.Windows.Forms.Button btn_ThongBao;
        private System.Windows.Forms.Button btn_Huy;
    }
}

