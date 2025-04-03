using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3layers
{
    public partial class frmDSGV : Form
    {
        public frmDSGV()
        {
            InitializeComponent();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimkiem.Text;
            loadDSGV();
        }
        private string tukhoa = "";
        private void loadDSGV()
        {
            string sql = "selectAllGV";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSGV.DataSource = new Database().SelectData(sql, lstPara);
        }

        private void frmDSGV_Load(object sender, EventArgs e)
        {
            loadDSGV();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new frmGV(null).ShowDialog();
            loadDSGV();
        }

        private void dgvDSGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mgv = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                new frmGV(mgv).ShowDialog();
                loadDSGV();
            }

        }

        private void dgvDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvDSGV.Columns["btnDelete"].Index)
                {
                    var maGV = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                    var sql = "deleteGV";
                    var lstPara = new List<CustomParameter>()
                    {
                        new CustomParameter
                        {
                            key = "@magiaovien",
                            value = maGV
                        }
                    };

                    var rs = new Database().ExeCute(sql, lstPara);
                    if (rs == 1)
                    {
                        MessageBox.Show("Xóa giáo viên thành công");
                        loadDSGV();
                    }

                }
            }
        }
    }
}
