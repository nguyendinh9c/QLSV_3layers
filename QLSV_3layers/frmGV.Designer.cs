namespace QLSV_3layers
{
    partial class frmGV
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
            txtTen = new TextBox();
            txtTendem = new TextBox();
            txtHo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            mtbNgaysinh = new MaskedTextBox();
            rbtNu = new RadioButton();
            rbtNam = new RadioButton();
            label5 = new Label();
            label4 = new Label();
            txtDienthoai = new TextBox();
            txtEmail = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtDiachi = new TextBox();
            label7 = new Label();
            btnHuy = new Button();
            btnLuu = new Button();
            SuspendLayout();
            // 
            // txtTen
            // 
            txtTen.Location = new Point(138, 137);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(345, 27);
            txtTen.TabIndex = 15;
            // 
            // txtTendem
            // 
            txtTendem.Location = new Point(138, 93);
            txtTendem.Name = "txtTendem";
            txtTendem.Size = new Size(345, 27);
            txtTendem.TabIndex = 14;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(138, 50);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(345, 27);
            txtHo.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 140);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 12;
            label3.Text = "Tên :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 93);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 11;
            label2.Text = "Tên đệm :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 46);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 10;
            label1.Text = "Họ :";
            // 
            // mtbNgaysinh
            // 
            mtbNgaysinh.Location = new Point(138, 238);
            mtbNgaysinh.Mask = "00/00/0000";
            mtbNgaysinh.Name = "mtbNgaysinh";
            mtbNgaysinh.Size = new Size(191, 27);
            mtbNgaysinh.TabIndex = 26;
            mtbNgaysinh.ValidatingType = typeof(DateTime);
            // 
            // rbtNu
            // 
            rbtNu.AutoSize = true;
            rbtNu.Location = new Point(326, 188);
            rbtNu.Name = "rbtNu";
            rbtNu.Size = new Size(50, 24);
            rbtNu.TabIndex = 25;
            rbtNu.Text = "Nữ";
            rbtNu.UseVisualStyleBackColor = true;
            // 
            // rbtNam
            // 
            rbtNam.AutoSize = true;
            rbtNam.Checked = true;
            rbtNam.Location = new Point(166, 188);
            rbtNam.Name = "rbtNam";
            rbtNam.Size = new Size(62, 24);
            rbtNam.TabIndex = 24;
            rbtNam.TabStop = true;
            rbtNam.Text = "Nam";
            rbtNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 190);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 23;
            label5.Text = "Giới tính :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 238);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 22;
            label4.Text = "Ngày sinh :";
            // 
            // txtDienthoai
            // 
            txtDienthoai.Location = new Point(138, 271);
            txtDienthoai.Name = "txtDienthoai";
            txtDienthoai.Size = new Size(345, 27);
            txtDienthoai.TabIndex = 32;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(138, 304);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(345, 27);
            txtEmail.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 271);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 30;
            label9.Text = "Điện thoại :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 304);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 29;
            label8.Text = "Email: ";
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(138, 337);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(345, 27);
            txtDiachi.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 337);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 27;
            label7.Text = "Địa chỉ :";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(298, 390);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 34;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(138, 390);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 33;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // frmGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 494);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtDienthoai);
            Controls.Add(txtEmail);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtDiachi);
            Controls.Add(label7);
            Controls.Add(mtbNgaysinh);
            Controls.Add(rbtNu);
            Controls.Add(rbtNam);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtTen);
            Controls.Add(txtTendem);
            Controls.Add(txtHo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmGV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGV";
            Load += frmGV_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTen;
        private TextBox txtTendem;
        private TextBox txtHo;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox mtbNgaysinh;
        private RadioButton rbtNu;
        private RadioButton rbtNam;
        private Label label5;
        private Label label4;
        private TextBox txtDienthoai;
        private TextBox txtEmail;
        private Label label9;
        private Label label8;
        private TextBox txtDiachi;
        private Label label7;
        private Button btnHuy;
        private Button btnLuu;
    }
}