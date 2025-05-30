namespace QLBH
{
    partial class frmDangNhap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_TenDangNhap = new TextBox();
            textBox_MatKhau = new TextBox();
            button_DangNhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 25);
            label1.Name = "label1";
            label1.Size = new Size(200, 41);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 100);
            label2.Name = "label2";
            label2.Size = new Size(158, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 162);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu";
            // 
            // textBox_TenDangNhap
            // 
            textBox_TenDangNhap.Location = new Point(291, 97);
            textBox_TenDangNhap.Name = "textBox_TenDangNhap";
            textBox_TenDangNhap.Size = new Size(262, 31);
            textBox_TenDangNhap.TabIndex = 3;
            // 
            // textBox_MatKhau
            // 
            textBox_MatKhau.Location = new Point(291, 162);
            textBox_MatKhau.Name = "textBox_MatKhau";
            textBox_MatKhau.PasswordChar = '*';
            textBox_MatKhau.Size = new Size(262, 31);
            textBox_MatKhau.TabIndex = 4;
            // 
            // button_DangNhap
            // 
            button_DangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_DangNhap.Location = new Point(248, 223);
            button_DangNhap.Name = "button_DangNhap";
            button_DangNhap.Size = new Size(133, 47);
            button_DangNhap.TabIndex = 5;
            button_DangNhap.Text = "Đăng Nhập";
            button_DangNhap.UseVisualStyleBackColor = true;
            button_DangNhap.Click += button_DangNhap_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 305);
            Controls.Add(button_DangNhap);
            Controls.Add(textBox_MatKhau);
            Controls.Add(textBox_TenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDangNhap";
            Text = "frmDangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_TenDangNhap;
        private TextBox textBox_MatKhau;
        private Button button_DangNhap;
    }
}