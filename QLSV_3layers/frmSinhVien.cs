using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QLSV_3layers
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }
        private string msv;

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msv))
            {
                this.Text = "Thêm mới sinh viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin sinh viên";
                var r = new Database().Select("selectSV '" + msv + "'");
                //MessageBox.Show(r[0].ToString());
                txtHo.Text = r["ho"].ToString();
                txtTendem.Text = r["tendem"].ToString();
                txtTen.Text = r["ten"].ToString();
                mtbNgaysinh.Text = r["ngsinh"].ToString();
                if (int.Parse(r["gioitinh"].ToString()) == 1)
                {
                    rbtNam.Checked = true;
                }
                else
                {
                    rbtNu.Checked = true;
                }
                txtQuequan.Text = r["quequan"].ToString();
                txtDiachi.Text = r["diachi"].ToString();
                txtDienthoai.Text = r["dienthoai"].ToString();
                txtEmail.Text = r["email"].ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "";
            string ho = txtHo.Text;
            string tendem = txtTendem.Text;
            string ten = txtTen.Text;
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(mtbNgaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mtbNgaysinh.Select();
                return;
            }
            string gioitinh = rbtNam.Checked ? "1" : "0";
            string quequan = txtQuequan.Text;
            string diachi = txtDiachi.Text;
            string dienthoai = txtDienthoai.Text;
            string email = txtEmail.Text;
            List<CustomParameter> IstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(msv))
            {
                sql = "ThemMoiSV";

            }
            else
            {
                sql = "updateSV";
                IstPara.Add(new CustomParameter()
                {
                    key = "@masinhvien",
                    value = msv
                });
            }
            IstPara.Add(new CustomParameter()
            {
                key = "@ho",
                value = ho
            });
            IstPara.Add(new CustomParameter()
            {
                key = "@tendem",
                value = tendem
            });
            IstPara.Add(new CustomParameter()
            {
                key = "@ten",
                value = ten
            });
            IstPara.Add(new CustomParameter()
            {
                key = "@ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            IstPara.Add(new CustomParameter()
            {
                key = "@gioitinh",
                value = gioitinh
            });
            IstPara.Add(new CustomParameter()
            {
                key = "@quequan",
                value = quequan
            });
            IstPara.Add(new CustomParameter()
            {
                key = "@diachi",
                value = diachi
            });
            IstPara.Add(new CustomParameter()
            {
                key = "@dienthoai",
                value = dienthoai
            });
            IstPara.Add(new CustomParameter()
            {
                key = "@email",
                value = email
            });

            var rs = new Database().ExeCute(sql, IstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(msv))
                {
                    MessageBox.Show("Thêm mới sinh viên thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi thất bại");
            }


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
