using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Globalization;

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

        private void btnXuatRaWord_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Word Documents|*.docx";
                sfd.Title = "Chọn nơi lưu file Word";
                sfd.FileName = "DanhSachSinhVien.docx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (WordprocessingDocument wordDocument =
                            WordprocessingDocument.Create(sfd.FileName, WordprocessingDocumentType.Document))
                        {
                            MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                            mainPart.Document = new Document();
                            Body body = mainPart.Document.AppendChild(new Body());

                            // 1. Tiêu đề trường
                            Paragraph pTitle = CreateParagraph("Đại học Tài nguyên và Môi trường Hà Nội", true, JustificationValues.Center, "28");
                            body.Append(pTitle);

                            // 2. Ngày hiện tại
                            string currentDate = DateTime.Now.ToString("dd/MM/yyyy", new CultureInfo("vi-VN"));
                            Paragraph pDate = CreateParagraph("Ngày: " + currentDate, false, JustificationValues.Right, "22");
                            body.Append(pDate);

                            // 3. Tiêu đề chính
                            body.Append(CreateParagraph("Danh sách sinh viên", true, JustificationValues.Center, "26"));
                            body.Append(new Paragraph(new Run(new Break()))); // Dòng trống

                            // 4. Tạo bảng
                            Table table = new Table();

                            // Thiết lập style cho bảng
                            TableProperties tblProp = new TableProperties(
                                new TableBorders(
                                    new TopBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                                    new BottomBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                                    new LeftBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                                    new RightBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                                    new InsideHorizontalBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                                    new InsideVerticalBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 }
                                )
                            );
                            table.AppendChild(tblProp);

                            // Header
                            TableRow headerRow = new TableRow();
                            foreach (DataGridViewColumn column in dgvSinhVien.Columns)
                            {
                                TableCell cell = CreateCell(column.HeaderText, true);
                                headerRow.Append(cell);
                            }
                            table.Append(headerRow);

                            // Dữ liệu
                            foreach (DataGridViewRow row in dgvSinhVien.Rows)
                            {
                                if (row.IsNewRow) continue;
                                TableRow dataRow = new TableRow();
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    dataRow.Append(CreateCell(cell.Value?.ToString() ?? "", false));
                                }
                                table.Append(dataRow);
                            }

                            body.Append(table);

                            wordDocument.MainDocumentPart.Document.Save();
                           
                        }

                        MessageBox.Show("Xuất file Word thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất Word: " + ex.Message);
                    }
                }
            }
        }

        private Paragraph CreateParagraph(string text, bool bold, JustificationValues align, string fontSize = "24")
        {
            return new Paragraph(
                new ParagraphProperties(
                    new Justification() { Val = align }
                ),
                new Run(
                    new RunProperties(
                        new Bold() { Val = bold },
                        new FontSize() { Val = fontSize }
                    ),
                    new Text(text)
                )
            );
        }

        private TableCell CreateCell(string text, bool isHeader)
        {
            TableCell cell = new TableCell();

            TableCellProperties props = new TableCellProperties(
                new TableCellWidth { Type = TableWidthUnitValues.Auto }
            );

            RunProperties runProps = new RunProperties();
            if (isHeader)
                runProps.Append(new Bold());

            Paragraph para = new Paragraph(new Run(runProps, new Text(text)));

            cell.Append(props);
            cell.Append(para);
            return cell;
        }


    }
}
