namespace QLBH
{
    partial class frmNhanVien
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            txtMaNV = new TextBox();
            txtTenNV = new TextBox();
            txtSDT_NV = new TextBox();
            txtDiaChi_NV = new TextBox();
            button4 = new Button();
            button5 = new Button();
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
            label1.Location = new Point(100, 80);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(97, 132);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên Nhân Viên";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(97, 188);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 2;
            label3.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(97, 241);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 3;
            label4.Text = "Địa Chỉ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(68, 304);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(99, 49);
            button1.TabIndex = 4;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnLuuNhanVien_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(224, 304);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(99, 49);
            button2.TabIndex = 5;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnSuaNhanVien_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Font = new Font("Segoe UI", 12F);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(385, 304);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(100, 49);
            button3.TabIndex = 6;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnXoaNhanVien_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonShadow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(68, 378);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(739, 278);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaNV.Location = new Point(361, 78);
            txtMaNV.Margin = new Padding(3, 4, 3, 4);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(275, 30);
            txtMaNV.TabIndex = 0;
            // 
            // txtTenNV
            // 
            txtTenNV.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenNV.Location = new Point(361, 130);
            txtTenNV.Margin = new Padding(3, 4, 3, 4);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(425, 30);
            txtTenNV.TabIndex = 1;
            // 
            // txtSDT_NV
            // 
            txtSDT_NV.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSDT_NV.Location = new Point(361, 186);
            txtSDT_NV.Margin = new Padding(3, 4, 3, 4);
            txtSDT_NV.Name = "txtSDT_NV";
            txtSDT_NV.Size = new Size(275, 30);
            txtSDT_NV.TabIndex = 2;
            // 
            // txtDiaChi_NV
            // 
            txtDiaChi_NV.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaChi_NV.Location = new Point(361, 241);
            txtDiaChi_NV.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi_NV.Name = "txtDiaChi_NV";
            txtDiaChi_NV.Size = new Size(425, 30);
            txtDiaChi_NV.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Font = new Font("Segoe UI", 12F);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(698, 304);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(113, 49);
            button4.TabIndex = 8;
            button4.Text = "Tìm Kiếm";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.Font = new Font("Segoe UI", 12F);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(548, 304);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(100, 49);
            button5.TabIndex = 9;
            button5.Text = "Hủy";
            button5.UseVisualStyleBackColor = false;
            button5.Click += btn_Huy_NV_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(292, 20);
            label5.Name = "label5";
            label5.Size = new Size(326, 41);
            label5.TabIndex = 15;
            label5.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(872, 685);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(txtDiaChi_NV);
            Controls.Add(txtSDT_NV);
            Controls.Add(txtTenNV);
            Controls.Add(txtMaNV);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtSDT_NV;
        private System.Windows.Forms.TextBox txtDiaChi_NV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private Label label5;
    }
}