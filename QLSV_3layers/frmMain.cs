namespace QLSV_3layers
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmWelcome f = new frmWelcome();
            AddForm(f);
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

        private void diemThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSDiemThi f = new frmDSDiemThi();
            AddForm(f);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
