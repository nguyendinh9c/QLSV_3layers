namespace QLSV_3layers
{
    partial class frmKetQuaHocTap
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
            txtTuKhoa = new TextBox();
            btnTraCuu = new Button();
            dgvKQHT = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKQHT).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 31);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Tìm Kiếm";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Location = new Point(360, 28);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(272, 27);
            txtTuKhoa.TabIndex = 1;
            // 
            // btnTraCuu
            // 
            btnTraCuu.Location = new Point(654, 27);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(134, 29);
            btnTraCuu.TabIndex = 2;
            btnTraCuu.Text = "Tra cứu điểm";
            btnTraCuu.UseVisualStyleBackColor = true;
            btnTraCuu.Click += btnTraCuu_Click;
            // 
            // dgvKQHT
            // 
            dgvKQHT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKQHT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKQHT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKQHT.Location = new Point(0, 77);
            dgvKQHT.MultiSelect = false;
            dgvKQHT.Name = "dgvKQHT";
            dgvKQHT.RowHeadersWidth = 51;
            dgvKQHT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKQHT.Size = new Size(800, 292);
            dgvKQHT.TabIndex = 3;
            // 
            // frmKetQuaHocTap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 369);
            Controls.Add(dgvKQHT);
            Controls.Add(btnTraCuu);
            Controls.Add(txtTuKhoa);
            Controls.Add(label1);
            Name = "frmKetQuaHocTap";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kết quả học tập";
            Load += frmKetQuaHocTap_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKQHT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTuKhoa;
        private Button btnTraCuu;
        private DataGridView dgvKQHT;
    }
}