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
    public partial class frmDSGV : Form
    {
        public frmDSGV()
        {
            InitializeComponent();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimkiem.Text;
            loadDSGV();
        }
        private string tukhoa = "";
        private void loadDSGV()
        {
            string sql = "selectAllGV";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSGV.DataSource = new Database().SelectData(sql, lstPara);
        }

        private void frmDSGV_Load(object sender, EventArgs e)
        {
            loadDSGV();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new frmGV(null).ShowDialog();
            loadDSGV();
        }

        private void dgvDSGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mgv = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                new frmGV(mgv).ShowDialog();
                loadDSGV();
            }

        }

        private void dgvDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvDSGV.Columns["btnDelete"].Index)
                {
                    var maGV = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                    var sql = "deleteGV";
                    var lstPara = new List<CustomParameter>()
                    {
                        new CustomParameter
                        {
                            key = "@magiaovien",
                            value = maGV
                        }
                    };

                    var rs = new Database().ExeCute(sql, lstPara);
                    if (rs == 1)
                    {
                        MessageBox.Show("Xóa giáo viên thành công");
                        loadDSGV();
                    }

                }
            }
        }



private void btnXuatRaWord_Click(object sender, EventArgs e)
    {
        using (SaveFileDialog sfd = new SaveFileDialog())
        {
            sfd.Filter = "Word Documents|*.docx";
            sfd.Title = "Chọn nơi lưu file danh sách giáo viên";
            sfd.FileName = "DanhSachGiaoVien.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (WordprocessingDocument wordDoc = WordprocessingDocument.Create(sfd.FileName, WordprocessingDocumentType.Document))
                    {
                        MainDocumentPart mainPart = wordDoc.AddMainDocumentPart();
                        mainPart.Document = new Document();
                        Body body = new Body();

                        // Tiêu đề
                        Paragraph header = new Paragraph(new Run(new Text("Đại học Tài nguyên và Môi trường Hà Nội")));
                        header.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center });
                        body.Append(header);

                        // Ngày
                        Paragraph datePara = new Paragraph(new Run(new Text("Ngày: " + DateTime.Now.ToString("yyyy-MM-dd"))));
                        datePara.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center });
                        body.Append(datePara);

                        // Dòng trống
                        body.Append(new Paragraph(new Run(new Text(""))));

                        // Tiêu đề nội dung
                        Paragraph title = new Paragraph(new Run(new Text("DANH SÁCH GIÁO VIÊN")));
                        title.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center });
                        body.Append(title);

                        // Thêm khoảng cách
                        body.Append(new Paragraph(new Run(new Text(""))));

                        // Bảng
                        Table table = new Table();

                        // Định dạng bảng
                        TableProperties tblProp = new TableProperties(
                            new TableBorders(
                                new TopBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                                new BottomBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                                new LeftBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                                new RightBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                                new InsideHorizontalBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                                new InsideVerticalBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 }
                            )
                        );
                        table.AppendChild(tblProp);

                        // Header
                        TableRow headerRow = new TableRow();
                        foreach (DataGridViewColumn column in dgvDSGV.Columns)
                        {
                            if (column.Visible && column.Name != "btnDelete")
                            {
                                TableCell cell = new TableCell(new Paragraph(new Run(new Text(column.HeaderText))));
                                cell.Append(new TableCellProperties(new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "3000" }));
                                headerRow.Append(cell);
                            }
                        }
                        table.Append(headerRow);

                        // Dữ liệu
                        foreach (DataGridViewRow row in dgvDSGV.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                TableRow dataRow = new TableRow();
                                foreach (DataGridViewColumn column in dgvDSGV.Columns)
                                {
                                    if (column.Visible && column.Name != "btnDelete")
                                    {
                                        var value = row.Cells[column.Index].Value?.ToString() ?? "";
                                        TableCell cell = new TableCell(new Paragraph(new Run(new Text(value))));
                                        cell.Append(new TableCellProperties(new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "3000" }));
                                        dataRow.Append(cell);
                                    }
                                }
                                table.Append(dataRow);
                            }
                        }

                        // Thêm bảng vào body
                        body.Append(table);

                        // Gán body vào document
                        mainPart.Document.Append(body);
                        mainPart.Document.Save();
                    }

                    MessageBox.Show("Xuất file Word thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file Word: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
}
