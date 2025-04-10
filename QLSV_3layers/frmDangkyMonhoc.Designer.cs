namespace QLSV_3layers
{
    partial class frmDangkyMonhoc
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
            dgvDSLH = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDSLH).BeginInit();
            SuspendLayout();
            // 
            // dgvDSLH
            // 
            dgvDSLH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSLH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSLH.Dock = DockStyle.Bottom;
            dgvDSLH.Location = new Point(0, 119);
            dgvDSLH.MultiSelect = false;
            dgvDSLH.Name = "dgvDSLH";
            dgvDSLH.RowHeadersWidth = 51;
            dgvDSLH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSLH.Size = new Size(800, 331);
            dgvDSLH.TabIndex = 0;
            dgvDSLH.CellDoubleClick += dgvDSLH_CellDoubleClick;
            // 
            // frmDangkyMonhoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDSLH);
            Name = "frmDangkyMonhoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách lớp học";
            Load += frmDangkyMonhoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSLH).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDSLH;
    }
}