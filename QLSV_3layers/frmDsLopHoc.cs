using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;

namespace QLSV_3layers
{
    public partial class frmDsLopHoc : Form
    {
        public frmDsLopHoc()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void frmDsLopHoc_Load(object sender, EventArgs e)
        {
            LoadDSLH();
        }
        private void LoadDSLH()
        {
            string sql = "allLopHoc";
            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value = tukhoa
                }
            };
            dgvLopHoc.DataSource = new Database().SelectData(sql, lstPara);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            LoadDSLH();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new frmLopHoc(null).ShowDialog();
            LoadDSLH();
        }

        private void dgvLopHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                new frmLopHoc(dgvLopHoc.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()).ShowDialog();
                LoadDSLH();
            }
        }

        private void dgvLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXuatRaWord_Click(object sender, EventArgs e)
        {
            try
            {
                // Hộp thoại lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Lưu danh sách lớp học";
                saveFileDialog.Filter = "Word Document (*.docx)|*.docx";
                saveFileDialog.FileName = "DanhSachLopHoc.docx";

                if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

                string filePath = saveFileDialog.FileName;

                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    Body body = new Body();

                    // Tiêu đề trường
                    Paragraph truong = new Paragraph(new Run(new Text("ĐẠI HỌC TÀI NGUYÊN VÀ MÔI TRƯỜNG HÀ NỘI")));
                    truong.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center });
                    truong.Descendants<Run>().First().RunProperties = new RunProperties(new Bold(), new FontSize() { Val = "28" });
                    body.Append(truong);

                    // Ngày
                    Paragraph ngay = new Paragraph(new Run(new Text("Ngày: " + DateTime.Now.ToString("yyyy-MM-dd"))));
                    ngay.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Right });
                    body.Append(ngay);

                    // Tiêu đề
                    Paragraph tieude = new Paragraph(new Run(new Text("DANH SÁCH LỚP HỌC")));
                    tieude.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center });
                    tieude.Descendants<Run>().First().RunProperties = new RunProperties(new Bold(), new FontSize() { Val = "24" });
                    body.Append(tieude);

                    // Khoảng cách
                    body.Append(new Paragraph(new Run(new Text(""))));

                    // Phần tiêu đề bảng
                    Paragraph tieudeBang = new Paragraph(new Run(new Text("1. Danh sách lớp học")));
                    tieudeBang.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Left });
                    tieudeBang.Descendants<Run>().First().RunProperties = new RunProperties(new Bold(), new FontSize() { Val = "22" });
                    body.Append(tieudeBang);

                    // Bảng
                    Table table = new Table();

                    // Định dạng bảng (viền)
                    TableProperties tblProp = new TableProperties(
                        new TableBorders(
                            new TopBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                            new BottomBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                            new LeftBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                            new RightBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                            new InsideHorizontalBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                            new InsideVerticalBorder() { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 }
                        )
                    );
                    table.AppendChild(tblProp);

                    // Header row
                    TableRow headerRow = new TableRow();
                    foreach (DataGridViewColumn col in dgvLopHoc.Columns)
                    {
                        TableCell headerCell = new TableCell(
                            new Paragraph(new Run(new Text(col.HeaderText)))
                        );
                        headerCell.TableCellProperties = new TableCellProperties(new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "4000" });
                        headerRow.Append(headerCell);
                    }
                    table.Append(headerRow);

                    // Dữ liệu
                    foreach (DataGridViewRow row in dgvLopHoc.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            TableRow dataRow = new TableRow();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string cellText = cell.Value?.ToString() ?? "";
                                TableCell dataCell = new TableCell(
                                    new Paragraph(new Run(new Text(cellText)))
                                );
                                dataCell.TableCellProperties = new TableCellProperties(new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "4000" });
                                dataRow.Append(dataCell);
                            }
                            table.Append(dataRow);
                        }
                    }

                    // Thêm bảng vào body
                    body.Append(table);

                    // Kết thúc tài liệu
                    mainPart.Document.Append(body);
                    mainPart.Document.Save();
                }

                MessageBox.Show("Xuất file Word thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Mở file
                // Mở file sau khi lưu
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất file Word: " + ex.Message);
            }
        }


    }
}
