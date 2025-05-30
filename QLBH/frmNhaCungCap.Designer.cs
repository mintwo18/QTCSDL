namespace QLBH
{
    partial class frmNhaCungCap
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
            label4 = new Label();
            txtMaNCC = new TextBox();
            txtTenNCC = new TextBox();
            txtSDT_NCC = new TextBox();
            txtDiaChi_NCC = new TextBox();
            button1 = new Button();
            button2 = new Button();
            Xóa = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(58, 83);
            label1.Name = "label1";
            label1.Size = new Size(182, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã Nhà Cung Cấp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(58, 142);
            label2.Name = "label2";
            label2.Size = new Size(185, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên Nhà Cung Cấp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(58, 202);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 2;
            label3.Text = "Số Điện Thoại";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(58, 261);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 3;
            label4.Text = "Địa Chỉ";
            // 
            // txtMaNCC
            // 
            txtMaNCC.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaNCC.Location = new Point(356, 81);
            txtMaNCC.Margin = new Padding(3, 4, 3, 4);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(271, 30);
            txtMaNCC.TabIndex = 0;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenNCC.Location = new Point(356, 140);
            txtTenNCC.Margin = new Padding(3, 4, 3, 4);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(474, 30);
            txtTenNCC.TabIndex = 1;
            // 
            // txtSDT_NCC
            // 
            txtSDT_NCC.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSDT_NCC.Location = new Point(356, 200);
            txtSDT_NCC.Margin = new Padding(3, 4, 3, 4);
            txtSDT_NCC.Name = "txtSDT_NCC";
            txtSDT_NCC.Size = new Size(271, 30);
            txtSDT_NCC.TabIndex = 2;
            // 
            // txtDiaChi_NCC
            // 
            txtDiaChi_NCC.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaChi_NCC.Location = new Point(356, 259);
            txtDiaChi_NCC.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi_NCC.Name = "txtDiaChi_NCC";
            txtDiaChi_NCC.Size = new Size(471, 30);
            txtDiaChi_NCC.TabIndex = 3;
            txtDiaChi_NCC.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(58, 315);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(99, 49);
            button1.TabIndex = 8;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnLuuNhaCungCap_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(222, 315);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(99, 49);
            button2.TabIndex = 9;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnSuaNhaCungCap_Click;
            // 
            // Xóa
            // 
            Xóa.BackColor = SystemColors.ButtonHighlight;
            Xóa.Font = new Font("Segoe UI", 12F);
            Xóa.ForeColor = SystemColors.ActiveCaptionText;
            Xóa.Location = new Point(383, 315);
            Xóa.Margin = new Padding(3, 4, 3, 4);
            Xóa.Name = "Xóa";
            Xóa.Size = new Size(99, 49);
            Xóa.TabIndex = 10;
            Xóa.Text = "Xóa";
            Xóa.UseVisualStyleBackColor = false;
            Xóa.Click += btnXoaNhaCungCap_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonShadow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 386);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(815, 286);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Font = new Font("Segoe UI", 12F);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(710, 314);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(120, 50);
            button3.TabIndex = 12;
            button3.Text = "Tìm Kiếm";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnTimKiemNhaCungCap_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Font = new Font("Segoe UI", 12F);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(552, 315);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(99, 49);
            button4.TabIndex = 13;
            button4.Text = "Hủy";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btn_Huy_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(246, 18);
            label5.Name = "label5";
            label5.Size = new Size(384, 41);
            label5.TabIndex = 14;
            label5.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 685);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(Xóa);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDiaChi_NCC);
            Controls.Add(txtSDT_NCC);
            Controls.Add(txtTenNCC);
            Controls.Add(txtMaNCC);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmNhaCungCap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNhaCungCap";
            Load += frmNhaCungCap_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtSDT_NCC;
        private System.Windows.Forms.TextBox txtDiaChi_NCC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Xóa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Label label5;
    }
}