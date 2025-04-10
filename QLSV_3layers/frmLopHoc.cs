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
    public partial class frmLopHoc : Form
    {
        public frmLopHoc(string malophoc)
        {
            this.malophoc = malophoc;
            InitializeComponent();
        }
        private string malophoc;
        private Database db;
        private string nguoithuchien = "admin";
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            db = new Database();
            List<CustomParameter> ls = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value = ""
                }
            };
            cbbMonHoc.DataSource = db.SelectData("selectAllMonHoc", ls);
            cbbMonHoc.DisplayMember = "tenmonhoc";
            cbbMonHoc.ValueMember = "mamonhoc";
            cbbGiaoVien.SelectedIndex = -1;

            cbbGiaoVien.DataSource = db.SelectData("selectAllGV", ls);
            cbbGiaoVien.DisplayMember = "hoten";
            cbbGiaoVien.ValueMember = "magiaovien";
            cbbGiaoVien.SelectedIndex = -1;

            if (string.IsNullOrEmpty(malophoc))
            {
                this.Text = "Thêm lớp học";
            }
            else
            {
                this.Text = "Cập nhật lớp học";
                var r = db.Select("exec selectLopHoc '" + malophoc + "'");
                cbbGiaoVien.SelectedValue = r["magiaovien"].ToString();
                cbbMonHoc.SelectedValue = r["mamonhoc"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string sql = "";

            if (cbbGiaoVien.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn giáo viên");
                return;
            }
            if (cbbMonHoc.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn môn học");
                return;
            }

            List<CustomParameter> lst = new List<CustomParameter>();
            if(string.IsNullOrEmpty(malophoc))
            {
                sql = "insertLopHoc";
                lst.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithuchien
                });
            }
            else
            {
                sql = "updateLopHoc";
                lst.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithuchien
                });
                lst.Add(new CustomParameter()
                {
                    key = "@malophoc",
                    value = malophoc
                });
            }

            lst.Add(new CustomParameter()
            {
                key = "@mamonhoc",
                value = cbbMonHoc.SelectedValue.ToString()
            });

            lst.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = cbbGiaoVien.SelectedValue.ToString()
            });


            var kq = db.ExeCute(sql, lst);

            if(kq > 0)
            {
                MessageBox.Show("Thành công");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
