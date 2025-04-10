namespace QLSV_3layers
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
            cbbLoaiTaiKhoan = new ComboBox();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangnhap = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 49);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Loại tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 105);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 158);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // cbbLoaiTaiKhoan
            // 
            cbbLoaiTaiKhoan.FormattingEnabled = true;
            cbbLoaiTaiKhoan.Items.AddRange(new object[] { "Quản trị viên", "Giáo viên", "Sinh viên" });
            cbbLoaiTaiKhoan.Location = new Point(165, 46);
            cbbLoaiTaiKhoan.Name = "cbbLoaiTaiKhoan";
            cbbLoaiTaiKhoan.Size = new Size(333, 28);
            cbbLoaiTaiKhoan.TabIndex = 3;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(165, 102);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(333, 27);
            txtTenDangNhap.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(165, 155);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(333, 27);
            txtMatKhau.TabIndex = 5;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Location = new Point(178, 226);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(94, 29);
            btnDangnhap.TabIndex = 6;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(354, 226);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnDangnhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(cbbLoaiTaiKhoan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmDangNhap";
            Load += frmDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbbLoaiTaiKhoan;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Button btnDangnhap;
        private Button btnThoat;
    }
}