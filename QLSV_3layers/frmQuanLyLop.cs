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
    public partial class frmQuanLyLop : Form
    {
        public frmQuanLyLop(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }

        private string mgv;

        private void frmQuanLyLop_Load(object sender, EventArgs e)
        {
            LoadDSLop();
            dgvKQHT.Columns["malophoc"].HeaderText = "Mã lớp";
            dgvKQHT.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvKQHT.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvKQHT.Columns["sotinchi"].HeaderText = "Số tín chỉ";
            dgvKQHT.Columns["siso"].HeaderText = "Sĩ số";
        }
        private void LoadDSLop()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = mgv
            });
            lst.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txtTuKhoa.Text
            });

            dgvKQHT.DataSource = new Database().SelectData("tracuulop", lst);
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            LoadDSLop();
        }

        private void dgvKQHT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy mã lớp và mã môn học từ dòng được chọn
                string malop = dgvKQHT.Rows[e.RowIndex].Cells["malophoc"].Value.ToString();
                string mamon = dgvKQHT.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString();

                // Truyền sang form chấm điểm
                var fcd = new frmChamDiemSinhVien(int.Parse(malop), int.Parse(mamon));
                fcd.ShowDialog();
            }
        }
    }
}
