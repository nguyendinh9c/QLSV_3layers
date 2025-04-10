namespace QLSV_3layers
{
    partial class frmDSDiemThi
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
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnThem = new Button();
            cbbMonHoc = new ComboBox();
            dgvDiemThi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDiemThi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Môn học :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(344, 43);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Từ khóa : ";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.Location = new Point(412, 39);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(263, 27);
            txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.Location = new Point(681, 39);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.Location = new Point(790, 39);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cbbMonHoc
            // 
            cbbMonHoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbMonHoc.FormattingEnabled = true;
            cbbMonHoc.Location = new Point(92, 40);
            cbbMonHoc.Name = "cbbMonHoc";
            cbbMonHoc.Size = new Size(235, 28);
            cbbMonHoc.TabIndex = 5;
            // 
            // dgvDiemThi
            // 
            dgvDiemThi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDiemThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiemThi.Location = new Point(12, 89);
            dgvDiemThi.Name = "dgvDiemThi";
            dgvDiemThi.RowHeadersWidth = 51;
            dgvDiemThi.Size = new Size(898, 349);
            dgvDiemThi.TabIndex = 6;
            // 
            // frmDSDiemThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(922, 450);
            Controls.Add(dgvDiemThi);
            Controls.Add(cbbMonHoc);
            Controls.Add(btnThem);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDSDiemThi";
            Text = "frmDSDiemThi";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvDiemThi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnThem;
        private ComboBox cbbMonHoc;
        private DataGridView dgvDiemThi;
    }
}