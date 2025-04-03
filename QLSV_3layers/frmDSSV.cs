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
    public partial class frmDSSV : Form
    {


        public frmDSSV()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDSSV_Load(object sender, EventArgs e)
        {
            LoadDSSV();
        }

        private void LoadDSSV(string tukhoa = "")
        {
            List<CustomParameter> IstPara = new List<CustomParameter>();
            IstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa ?? string.Empty
            });
            try
            {
                var dt = new Database().SelectData("SelectAllSinhVien", IstPara);
                dgvSinhVien.DataSource = dt;
                dgvSinhVien.Columns["masinhvien"].HeaderText = "Mã SV";
                dgvSinhVien.Columns["hoten"].HeaderText = "Họ tên";
                dgvSinhVien.Columns["nsinh"].HeaderText = "Ngày sinh";
                dgvSinhVien.Columns["gt"].HeaderText = "Giới tính";
                dgvSinhVien.Columns["quequan"].HeaderText = "Quê quán";
                dgvSinhVien.Columns["diachi"].HeaderText = "Địa chỉ";
                dgvSinhVien.Columns["email"].HeaderText = "Email";
                dgvSinhVien.Columns["dienthoai"].HeaderText = "Điện thoại";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }

        }

        private void dgvSinhVien_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                new frmSinhVien(msv).ShowDialog();
                LoadDSSV();
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new frmSinhVien(null).ShowDialog();
            LoadDSSV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgvSinhVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa");
                return;
            }

            // Lấy mã sinh viên từ dòng được chọn
            string msv = dgvSinhVien.SelectedRows[0].Cells["masinhvien"].Value.ToString();

            // Xác nhận trước khi xóa
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên {msv} không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Gọi stored procedure xóa sinh viên
                List<CustomParameter> lstPara = new List<CustomParameter>();
                lstPara.Add(new CustomParameter()
                {
                    key = "@masinhvien",
                    value = msv
                });

                var rs = new Database().ExeCute("deleteSV", lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Xóa sinh viên thành công");
                    LoadDSSV(); // Load lại danh sách sau khi xóa
                }
                else
                {
                    MessageBox.Show("Xóa sinh viên thất bại");
                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            LoadDSSV();
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {

            LoadDSSV(txtTuKhoa.Text.Trim());
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
