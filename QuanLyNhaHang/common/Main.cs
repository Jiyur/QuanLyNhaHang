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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
       
        private void QuanLy_label_Click(object sender, EventArgs e)
        {
            QuanLy quanLy = new QuanLy();
            quanLy.Show();
            quanLy.idvalue_label.Text = Globals.GlobalUserId.ToString().Trim();
            quanLy.fnamevalue_label.Text = Globals.GlobalUserName.Trim();
        }

        private void GoiMon_label_Click(object sender, EventArgs e)
        {
            MonAn mon = new MonAn();
            DataTable table = mon.LayTatCaMon();
            int sl = table.Rows.Count;
            int size = 100 + (sl - 1) * 20 + sl * 50;
            
        }

        private void Bep_label_Click(object sender, EventArgs e)
        {
            Bep bep = new Bep();
            bep.Show();
        }

        private void NhaKho_label_Click(object sender, EventArgs e)
        {
            Khohang kho = new Khohang();
            kho.Show();
        }

        private void Ban_label_Click(object sender, EventArgs e)
        {
            BanGhe bg = new BanGhe();
            bg.Show();

        }

        private void thongke_label_Click(object sender, EventArgs e)
        {
            ThongKe thongKe = new ThongKe();
            thongKe.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
