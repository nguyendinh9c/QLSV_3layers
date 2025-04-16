namespace QLSV_3layers
{
    partial class frmDsLopHoc
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
            dgvLopHoc = new DataGridView();
            btnThem = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label2 = new Label();
            btnXuatRaWord = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLopHoc).BeginInit();
            SuspendLayout();
            // 
            // dgvLopHoc
            // 
            dgvLopHoc.AllowUserToAddRows = false;
            dgvLopHoc.AllowUserToDeleteRows = false;
            dgvLopHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLopHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLopHoc.Dock = DockStyle.Bottom;
            dgvLopHoc.Location = new Point(0, 100);
            dgvLopHoc.MultiSelect = false;
            dgvLopHoc.Name = "dgvLopHoc";
            dgvLopHoc.ReadOnly = true;
            dgvLopHoc.RowHeadersWidth = 51;
            dgvLopHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLopHoc.Size = new Size(993, 350);
            dgvLopHoc.TabIndex = 13;
            dgvLopHoc.CellContentClick += dgvLopHoc_CellContentClick;
            dgvLopHoc.CellDoubleClick += dgvLopHoc_CellDoubleClick;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.Location = new Point(903, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(72, 29);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.Location = new Point(794, 26);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(72, 29);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.Location = new Point(525, 26);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(241, 27);
            txtTimKiem.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(457, 30);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 8;
            label2.Text = "Từ khóa : ";
            // 
            // btnXuatRaWord
            // 
            btnXuatRaWord.Location = new Point(287, 26);
            btnXuatRaWord.Name = "btnXuatRaWord";
            btnXuatRaWord.Size = new Size(154, 29);
            btnXuatRaWord.TabIndex = 14;
            btnXuatRaWord.Text = "Xuất ra word";
            btnXuatRaWord.UseVisualStyleBackColor = true;
            btnXuatRaWord.Click += btnXuatRaWord_Click;
            // 
            // frmDsLopHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 450);
            Controls.Add(btnXuatRaWord);
            Controls.Add(dgvLopHoc);
            Controls.Add(btnThem);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label2);
            Name = "frmDsLopHoc";
            Text = "frmDsLopHoc";
            Load += frmDsLopHoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLopHoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLopHoc;
        private Button btnThem;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label2;
        private Button btnXuatRaWord;
    }
}