using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;

using System.Drawing; // cần thêm nếu bạn lấy màu

namespace QLSV_3layers
{
    public partial class frmChamDiemSinhVien : Form
    {
        private int malop;
        private int mamon;
        private string masinhvien;
        private float diemthilan1;
        private float diemthilan2;
        SqlConnection conn = new SqlConnection("Data Source=DUONG-THE-INDIE\\SQLEXPRESS;Initial Catalog=QLSV_NEW;Integrated Security=True");

        private void OpenCon()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        private void CloseCon()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private Boolean Exe(string cmd)
        {
            try
            {
                OpenCon();
                SqlCommand command = new SqlCommand(cmd, conn);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                CloseCon();
            }
        }

        private DataTable Read(string cmd)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenCon();
                SqlCommand command = new SqlCommand(cmd, conn);
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cmnr: " + ex.Message);
                return null;
            }
            finally
            {
                CloseCon();
            }
        }

        public frmChamDiemSinhVien(int malop, int mamon)
        {
            this.malop = malop;
            this.mamon = mamon;
            InitializeComponent();
        }

        private void frmChamDiemSinhVien_Load(object sender, EventArgs e)
        {

            dgvChamDiemSinhVien.AllowUserToAddRows = false;
            dgvChamDiemSinhVien.ReadOnly = true;
            dgvChamDiemSinhVien.AllowUserToDeleteRows = false;

            LoadSinhVien(this.malop);
        }

        private void LoadSinhVien(int malophoc)
        {
            string sql = "SELECT * FROM tblDiem WHERE malophoc = '" + malophoc + "'";
            DataTable dataTable = Read(sql);
            if (dataTable != null)
            {
                DataTable filteredTable = new DataTable();
                filteredTable.Columns.Add("mã sinh viên", typeof(string));
                filteredTable.Columns.Add("họ tên", typeof(string));
                filteredTable.Columns.Add("lần học", typeof(float));
                filteredTable.Columns.Add("điểm lần 1", typeof(float));
                filteredTable.Columns.Add("điểm lần 2", typeof(float));

                foreach (DataRow row in dataTable.Rows)
                {
                    string masinhvien = row["masinhvien"].ToString();
                    // read data from masinhvien
                    string sqlSinhVien = "SELECT ho, tendem, ten FROM tblSinhVien WHERE masinhvien = '" + masinhvien + "'";
                    DataTable dataTableSinhVien = Read(sqlSinhVien);

                    if (dataTableSinhVien != null && dataTableSinhVien.Rows.Count > 0)
                    {
                        DataRow sinhvien = dataTableSinhVien.Rows[0]; // Fix: Declare and assign 'sinhvien' here
                        DataRow newRow = filteredTable.NewRow();
                        newRow["mã sinh viên"] = row["masinhvien"];
                        newRow["họ tên"] = sinhvien["ho"].ToString() + " " + sinhvien["tendem"].ToString() + " " + sinhvien["ten"].ToString();
                        newRow["lần học"] = row["lanhoc"];
                        newRow["điểm lần 1"] = row["diemthilan1"];
                        newRow["điểm lần 2"] = row["diemthilan2"];
                        filteredTable.Rows.Add(newRow);
                    }
                }
                dgvChamDiemSinhVien.DataSource = filteredTable;
            }
        }


        private void btnChamDienm_Click(object sender, EventArgs e)
        {
            // Cho phép sửa điểm trong DataGridView
            dgvChamDiemSinhVien.ReadOnly = false;

            // Nhưng vẫn không cho thêm hay xóa hàng nếu không muốn
            dgvChamDiemSinhVien.AllowUserToAddRows = false;
            dgvChamDiemSinhVien.AllowUserToDeleteRows = false;

            // Nếu bạn muốn chỉ sửa 2 cột "diemlan1" và "diemlan2":
            foreach (DataGridViewColumn col in dgvChamDiemSinhVien.Columns)
            {
                if (col.Name == "điểm lần 1" || col.Name == "điểm lần 2")
                {
                    col.ReadOnly = false;
                }
                else
                {
                    col.ReadOnly = true;
                }
            }
        }

        private void dgvChamDiemSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            masinhvien = dgvChamDiemSinhVien.Rows[e.RowIndex].Cells["mã sinh viên"].Value.ToString();
            //Exe(); // sửa điểm lần 1 và điểm lần 2 theo masinhvien

            diemthilan1 = float.Parse(dgvChamDiemSinhVien.Rows[e.RowIndex].Cells["điểm lần 1"].Value.ToString());

            diemthilan2 = float.Parse(dgvChamDiemSinhVien.Rows[e.RowIndex].Cells["điểm lần 2"].Value.ToString());
            */

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvChamDiemSinhVien.Rows)
            {
                if (row.IsNewRow) continue; // Bỏ dòng trống cuối cùng nếu có

                string masinhvien = row.Cells["mã sinh viên"].Value.ToString();
                string diem1 = row.Cells["điểm lần 1"].Value?.ToString();
                string diem2 = row.Cells["điểm lần 2"].Value?.ToString();

                // Nếu điểm rỗng thì coi là NULL
                string sql = $@"
            UPDATE tblDiem 
            SET 
                diemthilan1 = {(string.IsNullOrEmpty(diem1) ? "NULL" : diem1)}, 
                diemthilan2 = {(string.IsNullOrEmpty(diem2) ? "NULL" : diem2)}
            WHERE masinhvien = '{masinhvien}'";

                Exe(sql); // Gọi hàm update bạn đã có sẵn
            }

            LoadSinhVien(this.malop);
        }

        // Đặt vào btnXuatRaWord_Click:
        private void btnXuatRaWord_Click(object sender, EventArgs e)
        {
            string filePath = "D:\\DiemSinhVien.docx";
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = new Body();

                // ===== TÊN TRƯỜNG =====
                Paragraph schoolName = new Paragraph(
                    new Run(
                        new Text("ĐẠI HỌC TÀI NGUYÊN VÀ MÔI TRƯỜNG HÀ NỘI")
                        {
                            Space = SpaceProcessingModeValues.Preserve
                        }
                    )
                );
                schoolName.ParagraphProperties = new ParagraphProperties(
                    new Justification() { Val = JustificationValues.Center },
                    new SpacingBetweenLines() { After = "100" }
                );
                RunProperties schoolStyle = new RunProperties(new Bold(), new FontSize() { Val = "28" });
                schoolName.Descendants<Run>().First().RunProperties = schoolStyle;
                body.Append(schoolName);

                // ===== NGÀY THÁNG =====
                string currentDate = $"Hà Nội, ngày {DateTime.Now.Day} tháng {DateTime.Now.Month} năm {DateTime.Now.Year}";
                Paragraph datePara = new Paragraph(new Run(new Text(currentDate)));
                datePara.ParagraphProperties = new ParagraphProperties(
                    new Justification() { Val = JustificationValues.Right },
                    new SpacingBetweenLines() { After = "300" }
                );
                body.Append(datePara);

                // ===== TIÊU ĐỀ =====
                Paragraph title = new Paragraph(new Run(new Text("DANH SÁCH ĐIỂM SINH VIÊN")));
                title.ParagraphProperties = new ParagraphProperties(
                    new Justification() { Val = JustificationValues.Center },
                    new SpacingBetweenLines() { After = "200" }
                );
                RunProperties titleStyle = new RunProperties(new Bold(), new FontSize() { Val = "32" });
                title.Descendants<Run>().First().RunProperties = titleStyle;
                body.Append(title);

                // ===== TẠO BẢNG =====
                Table table = new Table();

                TableProperties tblProperties = new TableProperties(
                    new TableBorders(
                        new TopBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 4 },
                        new BottomBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 4 },
                        new LeftBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 4 },
                        new RightBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 4 },
                        new InsideHorizontalBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 4 },
                        new InsideVerticalBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 4 }
                    )
                );
                table.AppendChild(tblProperties);

                // ===== TIÊU ĐỀ CỘT =====
                TableRow headerRow = new TableRow();
                foreach (DataGridViewColumn column in dgvChamDiemSinhVien.Columns)
                {
                    TableCell cell = new TableCell(new Paragraph(new Run(new Text(column.HeaderText))));
                    cell.TableCellProperties = new TableCellProperties(new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "2400" });
                    headerRow.Append(cell);
                }
                table.Append(headerRow);

                // ===== DỮ LIỆU HÀNG =====
                foreach (DataGridViewRow dgRow in dgvChamDiemSinhVien.Rows)
                {
                    if (dgRow.IsNewRow) continue;
                    TableRow row = new TableRow();
                    foreach (DataGridViewCell cell in dgRow.Cells)
                    {
                        string cellText = cell.Value?.ToString() ?? "";
                        TableCell tableCell = new TableCell(new Paragraph(new Run(new Text(cellText))));
                        tableCell.TableCellProperties = new TableCellProperties(new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "2400" });
                        row.Append(tableCell);
                    }
                    table.Append(row);
                }

                body.Append(table);

                

                // Lưu nội dung vào tài liệu
                mainPart.Document.Append(body);
                mainPart.Document.Save();
            }

            MessageBox.Show("Đã xuất ra Word tại: " + filePath, "Thông báo");
        }
    }
}
