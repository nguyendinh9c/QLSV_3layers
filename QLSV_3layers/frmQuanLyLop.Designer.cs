namespace QLSV_3layers
{
    partial class frmQuanLyLop
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
            dgvKQHT = new DataGridView();
            btnTraCuu = new Button();
            txtTuKhoa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKQHT).BeginInit();
            SuspendLayout();
            // 
            // dgvKQHT
            // 
            dgvKQHT.AllowUserToAddRows = false;
            dgvKQHT.AllowUserToDeleteRows = false;
            dgvKQHT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKQHT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKQHT.Dock = DockStyle.Bottom;
            dgvKQHT.Location = new Point(0, 73);
            dgvKQHT.MultiSelect = false;
            dgvKQHT.Name = "dgvKQHT";
            dgvKQHT.ReadOnly = true;
            dgvKQHT.RowHeadersWidth = 51;
            dgvKQHT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKQHT.Size = new Size(800, 377);
            dgvKQHT.TabIndex = 7;
            dgvKQHT.CellDoubleClick += dgvKQHT_CellDoubleClick;
            // 
            // btnTraCuu
            // 
            btnTraCuu.Location = new Point(654, 12);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(134, 29);
            btnTraCuu.TabIndex = 6;
            btnTraCuu.Text = "Tra cứu điểm";
            btnTraCuu.UseVisualStyleBackColor = true;
            btnTraCuu.Click += btnTraCuu_Click;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Location = new Point(360, 13);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(272, 27);
            txtTuKhoa.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 16);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 4;
            label1.Text = "Tìm Kiếm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 16);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // frmQuanLyLop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(dgvKQHT);
            Controls.Add(btnTraCuu);
            Controls.Add(txtTuKhoa);
            Controls.Add(label1);
            Name = "frmQuanLyLop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý lớp";
            Load += frmQuanLyLop_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKQHT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKQHT;
        private Button btnTraCuu;
        private TextBox txtTuKhoa;
        private Label label1;
        private Label label2;
    }
}