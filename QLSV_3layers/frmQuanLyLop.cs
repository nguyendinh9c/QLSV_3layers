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
using System.IO;
using DocumentFormat.OpenXml;

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

        private void btnXuatRaWord_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\DanhSachLop_GiangDay.docx";

            if (File.Exists(filePath))
            {
                try { File.Delete(filePath); }
                catch (IOException)
                {
                    MessageBox.Show("Vui lòng đóng file Word trước khi xuất!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            using (WordprocessingDocument wordDoc = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDoc.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

                // Tiêu đề trường
                body.Append(CreateCenteredParagraph("ĐẠI HỌC TÀI NGUYÊN VÀ MÔI TRƯỜNG HÀ NỘI", true, 28));

                // Dòng ngày tháng
                body.Append(CreateRightAlignedParagraph("Hà Nội, ngày 16 tháng 4 năm 2025", 24));

                // Khoảng trắng
                body.Append(new Paragraph(new Run(new Text(" "))));

                // Tiêu đề chính
                body.Append(CreateCenteredParagraph("DANH SÁCH CÁC LỚP ĐANG GIẢNG DẠY", true, 28));

                body.Append(new Paragraph(new Run(new Text(" "))));

                // Tạo bảng
                Table table = new Table();

                // Border
                table.AppendChild(new TableProperties(
                    new TableBorders(
                        new TopBorder { Val = BorderValues.Single, Size = 6 },
                        new BottomBorder { Val = BorderValues.Single, Size = 6 },
                        new LeftBorder { Val = BorderValues.Single, Size = 6 },
                        new RightBorder { Val = BorderValues.Single, Size = 6 },
                        new InsideHorizontalBorder { Val = BorderValues.Single, Size = 6 },
                        new InsideVerticalBorder { Val = BorderValues.Single, Size = 6 }
                    )
                ));

                // Header row
                TableRow headerRow = new TableRow();
                string[] headers = { "mã lớp", "mã môn học", "tên môn học", "số tín chỉ", "sĩ số" };
                int[] columnWidths = { 1500, 1500, 4000, 1500, 1500 }; // độ rộng từng cột (dxa)

                for (int i = 0; i < headers.Length; i++)
                {
                    headerRow.Append(CreateStyledCell(headers[i], columnWidths[i], true));
                }
                table.Append(headerRow);

                // Data rows
                foreach (DataGridViewRow row in dgvKQHT.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        TableRow dataRow = new TableRow();
                        string[] columns = { "malophoc", "mamonhoc", "tenmonhoc", "sotinchi", "siso" };

                        for (int i = 0; i < columns.Length; i++)
                        {
                            string value = row.Cells[columns[i]].Value?.ToString() ?? "";
                            dataRow.Append(CreateStyledCell(value, columnWidths[i]));
                        }
                        table.Append(dataRow);
                    }
                }

                body.Append(table);
            }

            MessageBox.Show("✅ Xuất file Word thành công!\n📁 File lưu tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Tạo đoạn văn căn giữa
        private Paragraph CreateCenteredParagraph(string text, bool bold, int fontSizeHalfPoint)
        {
            return new Paragraph(new Run(new RunProperties(
                    bold ? new Bold() : null,
                    new FontSize() { Val = fontSizeHalfPoint.ToString() }),
                new Text(text)))
            {
                ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center })
            };
        }

        // Tạo đoạn văn căn phải
        private Paragraph CreateRightAlignedParagraph(string text, int fontSizeHalfPoint)
        {
            return new Paragraph(new Run(new RunProperties(
                    new FontSize() { Val = fontSizeHalfPoint.ToString() }),
                new Text(text)))
            {
                ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Right })
            };
        }

        // Tạo ô bảng có độ rộng và căn giữa nội dung
        private TableCell CreateStyledCell(string text, int width, bool bold = false)
        {
            return new TableCell(
                new TableCellProperties(new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = width.ToString() }),
                new Paragraph(
                    new Run(new RunProperties(bold ? new Bold() : null), new Text(text)))
                {
                    ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center })
                });
        }
    }
}
