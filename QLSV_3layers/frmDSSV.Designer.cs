namespace QLSV_3layers
{
    partial class frmDSSV
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
            dgvSinhVien = new DataGridView();
            label1 = new Label();
            txtTuKhoa = new TextBox();
            btnLammoi = new Button();
            btnThemmoi = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AllowUserToDeleteRows = false;
            dgvSinhVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(0, 68);
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(1051, 454);
            dgvSinhVien.TabIndex = 0;
            dgvSinhVien.CellContentClick += dgvSinhVien_CellContentClick;
            dgvSinhVien.CellContentDoubleClick += dgvSinhVien_CellContentDoubleClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(372, 32);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "Từ khóa:";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTuKhoa.Location = new Point(456, 25);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(213, 27);
            txtTuKhoa.TabIndex = 2;
            txtTuKhoa.TextChanged += txtTuKhoa_TextChanged;
            // 
            // btnLammoi
            // 
            btnLammoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLammoi.Location = new Point(688, 24);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(94, 29);
            btnLammoi.TabIndex = 3;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = true;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // btnThemmoi
            // 
            btnThemmoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemmoi.Location = new Point(801, 23);
            btnThemmoi.Name = "btnThemmoi";
            btnThemmoi.Size = new Size(94, 29);
            btnThemmoi.TabIndex = 4;
            btnThemmoi.Text = "Thêm mới";
            btnThemmoi.UseVisualStyleBackColor = true;
            btnThemmoi.Click += btnThemmoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.Location = new Point(912, 23);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmDSSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 522);
            Controls.Add(btnXoa);
            Controls.Add(btnThemmoi);
            Controls.Add(btnLammoi);
            Controls.Add(txtTuKhoa);
            Controls.Add(label1);
            Controls.Add(dgvSinhVien);
            Name = "frmDSSV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách sinh viên";
            Load += frmDSSV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSinhVien;
        private Label label1;
        private TextBox txtTuKhoa;
        private Button btnLammoi;
        private Button btnThemmoi;
        private Button btnXoa;
    }
}