namespace QLSV_3layers
{
    partial class frmMonHoc
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
            txtTenMH = new TextBox();
            txtSoTC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // txtTenMH
            // 
            txtTenMH.Location = new Point(115, 33);
            txtTenMH.Name = "txtTenMH";
            txtTenMH.Size = new Size(184, 27);
            txtTenMH.TabIndex = 0;
            // 
            // txtSoTC
            // 
            txtSoTC.Location = new Point(405, 33);
            txtSoTC.Name = "txtSoTC";
            txtSoTC.Size = new Size(55, 27);
            txtSoTC.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 36);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên môn học";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 36);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Số TC";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(486, 31);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(596, 31);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += button2_Click;
            // 
            // frmMonHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 87);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSoTC);
            Controls.Add(txtTenMH);
            Name = "frmMonHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMonHoc";
            Load += frmMonHoc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenMH;
        private TextBox txtSoTC;
        private Label label1;
        private Label label2;
        private Button btnLuu;
        private Button btnHuy;
    }
}