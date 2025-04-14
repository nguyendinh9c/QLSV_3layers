
namespace QLSV_3layers
{
    partial class frmChamDiemSinhVien
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
            dgvChamDiemSinhVien = new DataGridView();
            label1 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnChamDienm = new Button();
            btnLuu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChamDiemSinhVien).BeginInit();
            SuspendLayout();
            // 
            // dgvChamDiemSinhVien
            // 
            dgvChamDiemSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChamDiemSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamDiemSinhVien.Dock = DockStyle.Bottom;
            dgvChamDiemSinhVien.Location = new Point(0, 127);
            dgvChamDiemSinhVien.Name = "dgvChamDiemSinhVien";
            dgvChamDiemSinhVien.RowHeadersWidth = 51;
            dgvChamDiemSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChamDiemSinhVien.Size = new Size(800, 323);
            dgvChamDiemSinhVien.TabIndex = 0;
            dgvChamDiemSinhVien.CellDoubleClick += dgvChamDiemSinhVien_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 15);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(216, 12);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(251, 27);
            txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(483, 11);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnChamDienm
            // 
            btnChamDienm.Location = new Point(581, 10);
            btnChamDienm.Name = "btnChamDienm";
            btnChamDienm.Size = new Size(94, 29);
            btnChamDienm.TabIndex = 8;
            btnChamDienm.Text = "Chấm điểm";
            btnChamDienm.UseVisualStyleBackColor = true;
            btnChamDienm.Click += btnChamDienm_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(681, 10);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // frmChamDiemSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLuu);
            Controls.Add(btnChamDienm);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            Controls.Add(dgvChamDiemSinhVien);
            Name = "frmChamDiemSinhVien";
            Text = "frmChamDiemSinhVien";
            Load += frmChamDiemSinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChamDiemSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvChamDiemSinhVien;
        private Label label1;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnChamDienm;
        private Button btnLuu;
    }
}