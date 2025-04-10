namespace QLSV_3layers
{
    partial class frmDsMHDaDky
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
            dgvDSMHDky = new DataGridView();
            label1 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnDkyMoi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDSMHDky).BeginInit();
            SuspendLayout();
            // 
            // dgvDSMHDky
            // 
            dgvDSMHDky.AllowUserToAddRows = false;
            dgvDSMHDky.AllowUserToDeleteRows = false;
            dgvDSMHDky.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSMHDky.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSMHDky.Dock = DockStyle.Bottom;
            dgvDSMHDky.Location = new Point(0, 101);
            dgvDSMHDky.MultiSelect = false;
            dgvDSMHDky.Name = "dgvDSMHDky";
            dgvDSMHDky.ReadOnly = true;
            dgvDSMHDky.RowHeadersWidth = 51;
            dgvDSMHDky.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSMHDky.Size = new Size(1147, 349);
            dgvDSMHDky.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(508, 58);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 1;
            label1.Text = "Từ khóa";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(576, 51);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(232, 27);
            txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(814, 51);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(147, 29);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnDkyMoi
            // 
            btnDkyMoi.Location = new Point(967, 51);
            btnDkyMoi.Name = "btnDkyMoi";
            btnDkyMoi.Size = new Size(158, 29);
            btnDkyMoi.TabIndex = 4;
            btnDkyMoi.Text = "Đăng ký mới";
            btnDkyMoi.UseVisualStyleBackColor = true;
            btnDkyMoi.Click += btnDkyMoi_Click;
            // 
            // frmDsMHDaDky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 450);
            Controls.Add(btnDkyMoi);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            Controls.Add(dgvDSMHDky);
            Name = "frmDsMHDaDky";
            Text = "Danh sách môn học đã đăng ký";
            Load += frmDsMHDaDky_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSMHDky).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDSMHDky;
        private Label label1;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnDkyMoi;
    }
}