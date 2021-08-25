using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class XepHang : Form
    {
        public XepHang()
        {
            InitializeComponent();
        }

        private void XepHang_Load(object sender, EventArgs e)
        {
            string ngay = "ngay " + DateTime.Now.Day.ToString();
            string thang = "thang " + DateTime.Now.Month.ToString();
            DataTable table = new SLmonBan().Max(ngay);
            DataTable table1 = new SLmonBan().Max(thang);
            string xh_ngay = "";
            string xh_thang = "";
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (i == table.Rows.Count - 1)
                {
                    xh_ngay += table.Rows[i][0].ToString();
                }
                else
                {
                    xh_ngay += table.Rows[i][0].ToString() + ", ";
                }
            }
            XHngay_label.Text = "Xếp hạng ngày: " + xh_ngay;
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                if(i == table1.Rows.Count - 1)
                {
                    xh_thang += table1.Rows[i][0].ToString();
                }
                else
                {
                    xh_thang += table1.Rows[i][0].ToString() + ", ";
                }
            }
            XHthang_label.Text = "Xêp hạng tháng: " + xh_thang;
        }
    }
}
