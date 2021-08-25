using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace QuanLyNhaHang
{
    public partial class TinhLuong : Form
    {
        public TinhLuong()
        {
            InitializeComponent();
        }
        TienCong tc = new TienCong();
        private void TinhLuong_Load(object sender, EventArgs e)
        {
            tiencong_gridview.RowTemplate.Height = 40;
            tiencong_gridview.DataSource = tc.tienLuong();
        }

        private void SaveSalary_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "*.docx";
            save.Filter = "DOCX Files|*.docx";
            if (save.ShowDialog() == DialogResult.OK && tiencong_gridview.Rows.Count > 0)
            {

                Spire.Doc.Document doc;
                try
                {
                    doc = new Spire.Doc.Document(save.FileName);
                }
                catch (Exception)
                {
                    doc = new Spire.Doc.Document();
                }

                Spire.Doc.Table table;
                if (doc.Sections.Count < 1)
                {
                    Spire.Doc.Documents.Paragraph paragraph = doc.AddSection().AddParagraph();
                    Spire.Doc.Fields.TextRange header1 = paragraph.AppendText("Lương nhân viên\n");

                    header1.CharacterFormat.FontName = "Times New Roman";
                    header1.CharacterFormat.FontSize = 20;
                    header1.CharacterFormat.Bold = true;
                    header1.CharacterFormat.FontSize = 20;
                    paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                    table = doc.Sections[0].AddTable(true);
                }
                else
                {
                    Spire.Doc.Documents.Paragraph paragraph = doc.Sections[0].AddParagraph();
                    Spire.Doc.Fields.TextRange header1 = paragraph.AppendText("Lương Nhân viên\n");

                    header1.CharacterFormat.FontName = "Times New Roman";
                    header1.CharacterFormat.FontSize = 20;
                    header1.CharacterFormat.Bold = true;
                    header1.CharacterFormat.FontSize = 20;
                    paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                    table = doc.Sections[0].AddTable(true);
                }

                // Số dòng và số cột cho bảng
                table.ResetCells(tiencong_gridview.Rows.Count + 1, tiencong_gridview.Columns.Count);
                for (int i = 0; i < tiencong_gridview.Columns.Count; i++)
                {
                    doc.Sections[0].Tables[0].Rows[0].Cells[i].Width = 100;
                }

                //Đặt hàng đầu tiên là header
                Spire.Doc.TableRow FRow = table.Rows[0];
                FRow.IsHeader = true;
                FRow.Height = 23;

                for (int i = 0; i < tiencong_gridview.Columns.Count; i++)
                {
                    Spire.Doc.Documents.Paragraph p = FRow.Cells[i].AddParagraph();
                    // Định dạng văn bản trong bảng
                    FRow.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                    p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                    Spire.Doc.Fields.TextRange TR = p.AppendText(tiencong_gridview.Columns[i].HeaderText);
                    TR.CharacterFormat.FontName = "Times New Roman";
                    TR.CharacterFormat.FontSize = 13;
                    TR.CharacterFormat.Bold = true;
                }

                for (int i = 0; i < tiencong_gridview.Rows.Count; i++)
                {
                    Spire.Doc.TableRow DataRow = table.Rows[i + 1];
                    Spire.Doc.Documents.Paragraph paragraph;
                    for (int j = 0; j < tiencong_gridview.Columns.Count - 1; j++)
                    {
                        DataRow.Height = 50;
                        DataRow.Cells[j].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                        paragraph = DataRow.Cells[j].AddParagraph();
                        paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        Spire.Doc.Fields.TextRange text = paragraph.AppendText(tiencong_gridview.Rows[i].Cells[j].Value.ToString().Trim());
                        text.CharacterFormat.FontName = "Times New Roman";
                        text.CharacterFormat.FontSize = 13;
                    }
                }
                doc.SaveToFile(save.FileName);
                MessageBox.Show("Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
