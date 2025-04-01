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
            var db = new Database();
            //dgvData.DataSource = db.SelectData(null);
        }
    }
}
