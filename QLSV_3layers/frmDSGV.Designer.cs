namespace QLSV_3layers
{
    partial class frmDSGV
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
            dgvDSGV = new DataGridView();
            magiaovien = new DataGridViewTextBoxColumn();
            hoten = new DataGridViewTextBoxColumn();
            ngaysinh = new DataGridViewTextBoxColumn();
            gt = new DataGridViewTextBoxColumn();
            dienthoai = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            diachi = new DataGridViewTextBoxColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnTimkiem = new Button();
            btnThemmoi = new Button();
            txtTimkiem = new TextBox();
            label1 = new Label();
            btnXuatRaWord = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDSGV).BeginInit();
            SuspendLayout();
            // 
            // dgvDSGV
            // 
            dgvDSGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDSGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSGV.Columns.AddRange(new DataGridViewColumn[] { magiaovien, hoten, ngaysinh, gt, dienthoai, email, diachi, btnDelete });
            dgvDSGV.Location = new Point(0, 117);
            dgvDSGV.MultiSelect = false;
            dgvDSGV.Name = "dgvDSGV";
            dgvDSGV.RowHeadersWidth = 51;
            dgvDSGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSGV.Size = new Size(1056, 333);
            dgvDSGV.TabIndex = 0;
            dgvDSGV.CellClick += dgvDSGV_CellClick;
            dgvDSGV.CellDoubleClick += dgvDSGV_CellDoubleClick;
            // 
            // magiaovien
            // 
            magiaovien.DataPropertyName = "magiaovien";
            magiaovien.HeaderText = "Mã GV";
            magiaovien.MinimumWidth = 6;
            magiaovien.Name = "magiaovien";
            // 
            // hoten
            // 
            hoten.DataPropertyName = "hoten";
            hoten.HeaderText = "Họ và tên";
            hoten.MinimumWidth = 6;
            hoten.Name = "hoten";
            // 
            // ngaysinh
            // 
            ngaysinh.DataPropertyName = "ngaysinh";
            ngaysinh.HeaderText = "Ngày sinh";
            ngaysinh.MinimumWidth = 6;
            ngaysinh.Name = "ngaysinh";
            // 
            // gt
            // 
            gt.DataPropertyName = "gt";
            gt.HeaderText = "Giới tính";
            gt.MinimumWidth = 6;
            gt.Name = "gt";
            // 
            // dienthoai
            // 
            dienthoai.DataPropertyName = "dienthoai";
            dienthoai.HeaderText = "Điện thoại";
            dienthoai.MinimumWidth = 6;
            dienthoai.Name = "dienthoai";
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            // 
            // diachi
            // 
            diachi.DataPropertyName = "diachi";
            diachi.HeaderText = "Địa chỉ";
            diachi.MinimumWidth = 6;
            diachi.Name = "diachi";
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "";
            btnDelete.MinimumWidth = 6;
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Xóa";
            btnDelete.UseColumnTextForButtonValue = true;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimkiem.Location = new Point(593, 25);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(94, 29);
            btnTimkiem.TabIndex = 1;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // btnThemmoi
            // 
            btnThemmoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemmoi.Location = new Point(693, 25);
            btnThemmoi.Name = "btnThemmoi";
            btnThemmoi.Size = new Size(94, 29);
            btnThemmoi.TabIndex = 2;
            btnThemmoi.Text = "Thêm mới";
            btnThemmoi.UseVisualStyleBackColor = true;
            btnThemmoi.Click += btnThemmoi_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimkiem.Location = new Point(390, 27);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(188, 27);
            txtTimkiem.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(314, 30);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 4;
            label1.Text = "Tìm kiếm";
            label1.Click += label1_Click;
            // 
            // btnXuatRaWord
            // 
            btnXuatRaWord.Location = new Point(154, 26);
            btnXuatRaWord.Name = "btnXuatRaWord";
            btnXuatRaWord.Size = new Size(154, 29);
            btnXuatRaWord.TabIndex = 15;
            btnXuatRaWord.Text = "Xuất ra word";
            btnXuatRaWord.UseVisualStyleBackColor = true;
            btnXuatRaWord.Click += btnXuatRaWord_Click;
            // 
            // frmDSGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 450);
            Controls.Add(btnXuatRaWord);
            Controls.Add(label1);
            Controls.Add(txtTimkiem);
            Controls.Add(btnThemmoi);
            Controls.Add(btnTimkiem);
            Controls.Add(dgvDSGV);
            Name = "frmDSGV";
            Text = "Danh sách giáo viên";
            Load += frmDSGV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDSGV;
        private Button btnTimkiem;
        private Button btnThemmoi;
        private TextBox txtTimkiem;
        private Label label1;
        private DataGridViewTextBoxColumn magiaovien;
        private DataGridViewTextBoxColumn hoten;
        private DataGridViewTextBoxColumn ngaysinh;
        private DataGridViewTextBoxColumn gt;
        private DataGridViewTextBoxColumn dienthoai;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn diachi;
        private DataGridViewButtonColumn btnDelete;
        private Button btnXuatRaWord;
    }
}