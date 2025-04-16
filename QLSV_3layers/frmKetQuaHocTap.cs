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
    public partial class frmKetQuaHocTap : Form
    {
        public frmKetQuaHocTap(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }

        private string msv;

        private void frmKetQuaHocTap_Load(object sender, EventArgs e)
        {
            LoadKQHT();

            dgvKQHT.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvKQHT.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvKQHT.Columns["lanhoc"].HeaderText = "Lần học";
            dgvKQHT.Columns["gvien"].HeaderText = "Giáo viên";
            dgvKQHT.Columns["diemthilan1"].HeaderText = "Điểm lần 1";
            dgvKQHT.Columns["diemthilan2"].HeaderText = "Điểm lần 2";
        }

        private void LoadKQHT()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@masinhvien",
                value = msv
            });

            lst.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = txtTuKhoa.Text
            });

            dgvKQHT.DataSource = new Database().SelectData("tracuudiem", lst);
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            LoadKQHT();
        }


        private void btnXuatRaWord_Click(object sender, EventArgs e)
        {
            try
            {
                // Sử dụng SaveFileDialog để người dùng chọn nơi lưu file
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Word Document|*.docx";
                    saveFileDialog.Title = "Lưu kết quả học tập";
                    saveFileDialog.FileName = "KetQuaHocTap.docx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        // Tạo file Word mới
                        using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                        {
                            // Thêm phần chính (MainDocumentPart)
                            MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                            mainPart.Document = new Document();
                            Body body = new Body();

                            // Định dạng căn lề cho toàn bộ tài liệu
                            SectionProperties sectionProps = new SectionProperties();
                            PageMargin pageMargin = new PageMargin()
                            {
                                Top = 1440, // 2.54 cm
                                Right = (UInt32Value)720U, // 1.27 cm
                                Bottom = 1440, // 2.54 cm
                                Left = (UInt32Value)720U // 1.27 cm
                            };
                            sectionProps.Append(pageMargin);
                            body.Append(sectionProps);

                            // Thêm tên trường
                            Paragraph schoolNamePara = new Paragraph();
                            Run schoolNameRun = new Run(new Text("ĐẠI HỌC TÀI NGUYÊN VÀ MÔI TRƯỜNG HÀ NỘI"));
                            RunProperties schoolNameRunProps = new RunProperties();
                            schoolNameRunProps.Bold = new Bold();
                            schoolNameRunProps.FontSize = new FontSize() { Val = "28" }; // 14pt
                            schoolNameRun.PrependChild(schoolNameRunProps);
                            schoolNamePara.Append(schoolNameRun);
                            schoolNamePara.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center });
                            body.Append(schoolNamePara);

                            // Thêm khoảng cách
                            body.Append(new Paragraph(new Run(new Break())));

                            // Thêm ngày xuất
                            Paragraph datePara = new Paragraph();
                            Run dateRun = new Run(new Text($"Hà Nội, ngày {DateTime.Now.Day} tháng {DateTime.Now.Month} năm {DateTime.Now.Year}"));
                            RunProperties dateRunProps = new RunProperties();
                            dateRunProps.FontSize = new FontSize() { Val = "24" }; // 12pt
                            dateRun.PrependChild(dateRunProps);
                            datePara.Append(dateRun);
                            datePara.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Right });
                            body.Append(datePara);

                            // Thêm khoảng cách
                            body.Append(new Paragraph(new Run(new Break())));

                            // Thêm tiêu đề
                            Paragraph titlePara = new Paragraph();
                            Run titleRun = new Run(new Text("KẾT QUẢ HỌC TẬP"));
                            RunProperties titleRunProps = new RunProperties();
                            titleRunProps.Bold = new Bold();
                            titleRunProps.FontSize = new FontSize() { Val = "40" }; // 20pt
                            titleRun.PrependChild(titleRunProps);
                            titlePara.Append(titleRun);
                            titlePara.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center });
                            body.Append(titlePara);

                            // Thêm khoảng cách
                            body.Append(new Paragraph(new Run(new Break())));

                            // Tạo bảng
                            Table table = new Table();

                            // Định dạng bảng (viền và căn giữa)
                            TableProperties tblProperties = new TableProperties(
                                new TableBorders(
                                    new TopBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 4 },
                                    new BottomBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 4 },
                                    new LeftBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 4 },
                                    new RightBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 4 },
                                    new InsideHorizontalBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 4 },
                                    new InsideVerticalBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 4 }
                                ),
                                new TableJustification() { Val = TableRowAlignmentValues.Center }
                            );
                            table.AppendChild(tblProperties);

                            // Dòng tiêu đề cột
                            TableRow headerRow = new TableRow();
                            foreach (DataGridViewColumn column in dgvKQHT.Columns)
                            {
                                TableCell cell = new TableCell();
                                Paragraph cellPara = new Paragraph();
                                Run cellRun = new Run(new Text(column.HeaderText));
                                cellPara.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center });

                                // Định dạng tiêu đề cột: in đậm, màu trắng, nền xanh
                                RunProperties cellRunProps = new RunProperties();
                                cellRunProps.Bold = new Bold();
                                //cellRunProps.Color = new Color() { Val = "FFFFFF" }; // Chữ trắng
                                cellRunProps.FontSize = new FontSize() { Val = "24" }; // 12pt
                                cellRun.PrependChild(cellRunProps);

                                cellPara.Append(cellRun);

                                // Màu nền xanh (RGB: 0, 120, 215)
                                TableCellProperties cellProps = new TableCellProperties();
                                cellProps.Append(new TableCellWidth() { Type = TableWidthUnitValues.Auto });
                                cellProps.Append(new Shading() { Fill = "0078D7", Val = ShadingPatternValues.Clear });
                                cell.Append(cellProps);

                                cell.Append(cellPara);
                                headerRow.Append(cell);
                            }
                            table.Append(headerRow);

                            // Dữ liệu từng dòng
                            foreach (DataGridViewRow dgRow in dgvKQHT.Rows)
                            {
                                if (dgRow.IsNewRow) continue;

                                TableRow row = new TableRow();
                                foreach (DataGridViewCell cell in dgRow.Cells)
                                {
                                    string cellText = cell.Value?.ToString() ?? "";
                                    TableCell tableCell = new TableCell();
                                    Paragraph cellPara = new Paragraph();
                                    Run cellRun = new Run(new Text(cellText));
                                    cellPara.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center });

                                    // Định dạng dữ liệu: cỡ chữ 12pt
                                    RunProperties cellRunProps = new RunProperties();
                                    cellRunProps.FontSize = new FontSize() { Val = "24" }; // 12pt
                                    cellRun.PrependChild(cellRunProps);

                                    cellPara.Append(cellRun);
                                    tableCell.Append(cellPara);
                                    row.Append(tableCell);
                                }
                                table.Append(row);
                            }

                            // Thêm bảng vào tài liệu
                            body.Append(table);
                            mainPart.Document.Append(body);
                            mainPart.Document.Save();
                        }

                        MessageBox.Show("Đã xuất ra Word tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
