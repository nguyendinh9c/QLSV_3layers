namespace QLSV_3layers
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private string taikhoan;
        private string loaitk;
        private void frmMain_Load(object sender, EventArgs e)
        {
            var d = new frmDangNhap();
            d.ShowDialog();

            taikhoan = d.tendangnhap;
            loaitk = d.loaitk;
            if (loaitk.Equals("admin"))
            {
                quanlylopToolStripMenuItem.Visible = false;
                chucNangToolStripMenuItem.Visible = false;

            }
            else
            {
                quanlyToolStripMenuItem.Visible = false;
                if (loaitk.Equals("gv"))
                {
                    quanlylopToolStripMenuItem.Visible = true;
                    chucNangToolStripMenuItem.Visible = false;

                }
                else
                {
                    quanlylopToolStripMenuItem.Visible = false;
                    chucNangToolStripMenuItem.Visible = true;

                }

                frmWelcome f = new frmWelcome();
                AddForm(f);
            }
        }

        private void AddForm(Form f)
        {
            this.panel1.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.panel1.Controls.Add(f);
            f.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void giaoVienToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDSGV f = new frmDSGV();
            AddForm(f);

        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSSV f = new frmDSSV();
            AddForm(f);
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSMH f = new frmDSMH();
            AddForm(f);
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDsLopHoc f = new frmDsLopHoc();
            AddForm(f);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dangkyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDsMHDaDky(taikhoan);
            AddForm(f);
        }

        private void traCuuDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmKetQuaHocTap(taikhoan).ShowDialog();
            var fkq = new frmKetQuaHocTap(taikhoan);
            AddForm(fkq);
        }

        private void quanlylopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fql = new frmQuanLyLop(taikhoan);
            AddForm(fql);
        }
    }
}
