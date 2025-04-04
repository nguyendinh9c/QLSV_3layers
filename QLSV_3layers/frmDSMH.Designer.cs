namespace QLSV_3layers
{
    partial class frmDSMH
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
            dgvDSMH = new DataGridView();
            label1 = new Label();
            txtTimkiem = new TextBox();
            btnTimkiem = new Button();
            btnThemmoi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDSMH).BeginInit();
            SuspendLayout();
            // 
            // dgvDSMH
            // 
            dgvDSMH.AllowUserToAddRows = false;
            dgvDSMH.AllowUserToDeleteRows = false;
            dgvDSMH.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDSMH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSMH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSMH.Location = new Point(0, 115);
            dgvDSMH.MultiSelect = false;
            dgvDSMH.Name = "dgvDSMH";
            dgvDSMH.ReadOnly = true;
            dgvDSMH.RowHeadersWidth = 51;
            dgvDSMH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSMH.Size = new Size(800, 335);
            dgvDSMH.TabIndex = 0;
            dgvDSMH.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(328, 60);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 1;
            label1.Text = "Từ khóa";
            label1.Click += label1_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimkiem.Location = new Point(396, 57);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(176, 27);
            txtTimkiem.TabIndex = 2;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimkiem.Location = new Point(587, 56);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(94, 29);
            btnTimkiem.TabIndex = 3;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // btnThemmoi
            // 
            btnThemmoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemmoi.Location = new Point(687, 57);
            btnThemmoi.Name = "btnThemmoi";
            btnThemmoi.Size = new Size(94, 29);
            btnThemmoi.TabIndex = 4;
            btnThemmoi.Text = "Thêm mới";
            btnThemmoi.UseVisualStyleBackColor = true;
            btnThemmoi.Click += btnThemmoi_Click;
            // 
            // frmDSMH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThemmoi);
            Controls.Add(btnTimkiem);
            Controls.Add(txtTimkiem);
            Controls.Add(label1);
            Controls.Add(dgvDSMH);
            Name = "frmDSMH";
            Text = "Danh sách môn học";
            Load += frmDSMH_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSMH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDSMH;
        private Label label1;
        private TextBox txtTimkiem;
        private Button btnTimkiem;
        private Button btnThemmoi;
    }
}