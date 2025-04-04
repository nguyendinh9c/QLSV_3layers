namespace QLSV_3layers
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            doiMatKhauToolStripMenuItem = new ToolStripMenuItem();
            thoatToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            sinhVienToolStripMenuItem = new ToolStripMenuItem();
            monHocToolStripMenuItem = new ToolStripMenuItem();
            giaoVienToolStripMenuItem1 = new ToolStripMenuItem();
            diemThiToolStripMenuItem = new ToolStripMenuItem();
            troGiupToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýToolStripMenuItem, troGiupToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1112, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doiMatKhauToolStripMenuItem, thoatToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            doiMatKhauToolStripMenuItem.Size = new Size(181, 26);
            doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // thoatToolStripMenuItem
            // 
            thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            thoatToolStripMenuItem.Size = new Size(181, 26);
            thoatToolStripMenuItem.Text = "Thoát";
            thoatToolStripMenuItem.Click += thoatToolStripMenuItem_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sinhVienToolStripMenuItem, monHocToolStripMenuItem, giaoVienToolStripMenuItem1, diemThiToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(73, 24);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // sinhVienToolStripMenuItem
            // 
            sinhVienToolStripMenuItem.Name = "sinhVienToolStripMenuItem";
            sinhVienToolStripMenuItem.Size = new Size(154, 26);
            sinhVienToolStripMenuItem.Text = "Sinh viên";
            sinhVienToolStripMenuItem.Click += sinhVienToolStripMenuItem_Click;
            // 
            // monHocToolStripMenuItem
            // 
            monHocToolStripMenuItem.Name = "monHocToolStripMenuItem";
            monHocToolStripMenuItem.Size = new Size(154, 26);
            monHocToolStripMenuItem.Text = "Môn học";
            monHocToolStripMenuItem.Click += monHocToolStripMenuItem_Click;
            // 
            // giaoVienToolStripMenuItem1
            // 
            giaoVienToolStripMenuItem1.Name = "giaoVienToolStripMenuItem1";
            giaoVienToolStripMenuItem1.Size = new Size(154, 26);
            giaoVienToolStripMenuItem1.Text = "Giáo viên";
            giaoVienToolStripMenuItem1.Click += giaoVienToolStripMenuItem1_Click;
            // 
            // diemThiToolStripMenuItem
            // 
            diemThiToolStripMenuItem.Name = "diemThiToolStripMenuItem";
            diemThiToolStripMenuItem.Size = new Size(154, 26);
            diemThiToolStripMenuItem.Text = "Điểm thi";
            diemThiToolStripMenuItem.Click += diemThiToolStripMenuItem_Click;
            // 
            // troGiupToolStripMenuItem
            // 
            troGiupToolStripMenuItem.Name = "troGiupToolStripMenuItem";
            troGiupToolStripMenuItem.Size = new Size(78, 24);
            troGiupToolStripMenuItem.Text = "Trợ giúp";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 489);
            panel1.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 517);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main form";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private ToolStripMenuItem thoatToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem sinhVienToolStripMenuItem;
        private ToolStripMenuItem monHocToolStripMenuItem;
        private ToolStripMenuItem giaoVienToolStripMenuItem1;
        private ToolStripMenuItem diemThiToolStripMenuItem;
        private ToolStripMenuItem troGiupToolStripMenuItem;
        private Panel panel1;
    }
}
