namespace QLSV_3layers
{
    partial class frmLopHoc
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
            cbbGiaoVien = new ComboBox();
            cbbMonHoc = new ComboBox();
            label2 = new Label();
            btnHuy = new Button();
            btnLuu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 132);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Môn học";
            // 
            // cbbGiaoVien
            // 
            cbbGiaoVien.FormattingEnabled = true;
            cbbGiaoVien.Location = new Point(130, 73);
            cbbGiaoVien.Name = "cbbGiaoVien";
            cbbGiaoVien.Size = new Size(334, 28);
            cbbGiaoVien.TabIndex = 1;
            // 
            // cbbMonHoc
            // 
            cbbMonHoc.FormattingEnabled = true;
            cbbMonHoc.Location = new Point(130, 124);
            cbbMonHoc.Name = "cbbMonHoc";
            cbbMonHoc.Size = new Size(334, 28);
            cbbMonHoc.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 81);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Giáo viên";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(317, 213);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(139, 213);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // frmLopHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 265);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            Controls.Add(cbbMonHoc);
            Controls.Add(label2);
            Controls.Add(cbbGiaoVien);
            Controls.Add(label1);
            Name = "frmLopHoc";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmLopHoc";
            Load += frmLopHoc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbbGiaoVien;
        private ComboBox cbbMonHoc;
        private Label label2;
        private Button button1;
        private Button btnHuy;
        private Button btnLuu;
    }
}