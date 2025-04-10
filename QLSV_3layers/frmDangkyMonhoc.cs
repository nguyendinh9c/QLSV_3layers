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
    public partial class frmDangkyMonhoc : Form
    {
        public frmDangkyMonhoc(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }

        private string masv;

        private void frmDangkyMonhoc_Load(object sender, EventArgs e)
        {
            LoadDSLH();
            dgvDSLH.Columns["malophoc"].HeaderText = "Mã lớp học";
            dgvDSLH.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDSLH.Columns["sotinchi"].HeaderText = "Số tín chỉ";
            dgvDSLH.Columns["gvien"].HeaderText = "Giáo viên";

            dgvDSLH.Columns["mamonhoc"].Visible = false;

        }
        private void LoadDSLH()
        {
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@masinhvien",
                    value = masv
                }
            };
            dgvDSLH.DataSource = new Database().SelectData("dsLopChuaDKy", lst);
        }

        private void dgvDSLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSLH.Rows[e.RowIndex].Index >= 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn muốn đăng ký học  phần này [" + dgvDSLH.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString() + "]", "Xác nhận đăng ký", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    )
                {

                    List<CustomParameter> lst = new List<CustomParameter>()
                    {
                        new CustomParameter()
                        {
                            key = "@masinhvien",
                            value = masv
                        },
                        new CustomParameter()
                        {
                            key = "@malophoc",
                            value = dgvDSLH.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()
                        },

                    };
                    var rs = new Database().ExeCute("[dkyhoc]", lst);
                    if (rs == -1)
                    {
                        MessageBox.Show("Học phần này bạn đã đăng ký !!!!");
                        return;
                    }
                    if (rs == 1)
                    {
                        MessageBox.Show("Đăng ký thành công");
                        LoadDSLH();
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký không thành công");

                    }

                }
            }
        }
    }

}