using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace QuanLyNhaHang
{
    public partial class XuatBill : Form
    {
        public XuatBill()
        {
            InitializeComponent();
        }
        Bill bill = new Bill();
        int id_ban;
        public int ID_ban
        {
            get { return id_ban; }
            set { id_ban = value; }
        }
        private void XuatBill_Load(object sender, EventArgs e)
        {
            Label GoiMon_label = new Label();
            GoiMon_label.AutoSize = true;
            GoiMon_label.Font = new System.Drawing.Font("Agency FB", 20F);
            GoiMon_label.ForeColor = System.Drawing.Color.Gray;
            GoiMon_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            GoiMon_label.Location = new System.Drawing.Point(200, 10);
            GoiMon_label.ForeColor = System.Drawing.Color.Gainsboro;
            GoiMon_label.Text = "BÀN SỐ " + id_ban;
            GoiMon_label.Parent = this;
            GoiMon_label.Show();
            int kc = GoiMon_label.Location.Y + GoiMon_label.Size.Height + 20;

            Label ThongTin_label = new Label();
            ThongTin_label.AutoSize = true;
            ThongTin_label.Font = new System.Drawing.Font("Agency FB", 16F);
            ThongTin_label.ForeColor = System.Drawing.Color.Gray;
            ThongTin_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ThongTin_label.Location = new System.Drawing.Point(80, kc);
            ThongTin_label.ForeColor = System.Drawing.Color.Gainsboro;
            ThongTin_label.Text = "Món ăn           Số lượng            Thành tiền(VND)";
            ThongTin_label.Parent = this;
            ThongTin_label.Show();
            kc += ThongTin_label.Size.Height + 20;
            DataTable table = bill.layBill(id_ban);
            Double sum = 0;
            foreach (DataRow row in table.Rows)
            {
                Label monAn_label = new Label();
                monAn_label.AutoSize = true;
                monAn_label.Font = new System.Drawing.Font("Agency FB", 15F);
                monAn_label.ForeColor = System.Drawing.Color.Gray;
                monAn_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                monAn_label.Location = new System.Drawing.Point(80, kc);
                monAn_label.ForeColor = System.Drawing.Color.Gainsboro;
                monAn_label.Text = row[0].ToString() ;
                monAn_label.Parent = this;
                monAn_label.Show();

                Label Sl_label = new Label();
                Sl_label.AutoSize = true;
                Sl_label.Font = new System.Drawing.Font("Agency FB", 15F);
                Sl_label.ForeColor = System.Drawing.Color.Gray;
                Sl_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                Sl_label.Location = new System.Drawing.Point(200, kc);
                Sl_label.ForeColor = System.Drawing.Color.Gainsboro;
                Sl_label.Text = row[1].ToString();
                Sl_label.Parent = this;
                Sl_label.Show();

                Label Gia_label = new Label();
                Gia_label.AutoSize = true;
                Gia_label.Font = new System.Drawing.Font("Agency FB", 15F);
                Gia_label.ForeColor = System.Drawing.Color.Gray;
                Gia_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                Gia_label.Location = new System.Drawing.Point(330, kc);
                Gia_label.ForeColor = System.Drawing.Color.Gainsboro;
                Gia_label.Text = row[2].ToString();
                Gia_label.Parent = this;
                Sl_label.Show();
                kc += monAn_label.Size.Height + 10;
                sum += double.Parse(row[2].ToString()) * int.Parse(row[1].ToString());
            }

            Label label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Agency FB", 15F);
            label.ForeColor = System.Drawing.Color.Gray;
            label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label.Location = new System.Drawing.Point(80, kc);
            label.ForeColor = System.Drawing.Color.Gainsboro;
            label.Text = "_____________________________________________";
            label.Parent = this;
            label.Show();
            kc += label.Size.Height + 10;

            Label Tong_label = new Label();
            Tong_label.AutoSize = true;
            Tong_label.Font = new System.Drawing.Font("Agency FB", 15F);
            Tong_label.ForeColor = System.Drawing.Color.Gray;
            Tong_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Tong_label.Location = new System.Drawing.Point(80, kc);
            Tong_label.ForeColor = System.Drawing.Color.White;
            Tong_label.Text = "Tổng tiền:                                           " + sum + " .VND";
            Tong_label.Parent = this;
            Tong_label.Show();
            kc += Tong_label.Size.Height + 10;

            Label Date_label = new Label();
            Date_label.AutoSize = true;
            Date_label.Font = new System.Drawing.Font("Agency FB", 15F);
            Date_label.ForeColor = System.Drawing.Color.Gray;
            Date_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Date_label.Location = new System.Drawing.Point(80, kc);
            Date_label.ForeColor = System.Drawing.Color.White;
            Date_label.Text = "Ngày xuất:                                 " + DateTime.Now;
            Date_label.Parent = this;
            Date_label.Show();
            kc += Tong_label.Size.Height + 10;

            Button In_Bill = new Button();
            this.Controls.Add(In_Bill);
            In_Bill.BackColor = System.Drawing.Color.Transparent;
            In_Bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            In_Bill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            In_Bill.ForeColor = System.Drawing.Color.White;
            In_Bill.Location = new System.Drawing.Point(170, kc+50);
            In_Bill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            In_Bill.Name = "In_Bill";
            In_Bill.Size = new System.Drawing.Size(150, 50);
            In_Bill.TabIndex = 13;
            In_Bill.Text = "In bill";
            In_Bill.UseVisualStyleBackColor = false;
            In_Bill.Click += new System.EventHandler(this.In_Bill_Click);
            
        }

        private void In_Bill_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }
    }
}
