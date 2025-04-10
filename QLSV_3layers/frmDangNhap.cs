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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public string tendangnhap = "";
        public string loaitk = "";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {

            if(cbbLoaiTaiKhoan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập");
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }

            tendangnhap = txtTenDangNhap.Text;
            loaitk = "";

            #region swtk
            switch (cbbLoaiTaiKhoan.Text)
            {
                case "Quản trị viên":
                    loaitk = "admin";
                    break;
                case "Giáo viên":
                    loaitk = "gv";
                    break;
                case "Sinh viên":
                    
                    loaitk = "sv";
                    break;
            }
            #endregion


            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@loaitaikhoan",
                    value = loaitk
                },
                new CustomParameter()
                {
                    key = "@taikhoan",
                    value = txtTenDangNhap.Text
                },
                new CustomParameter()
                {
                    key = "@matkhau",
                    value = txtMatKhau.Text
                }
            };

            var rs = new Database().SelectData("dangnhap", lstPara);

            if (rs.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
               
            }

            //
        }
    }
}
