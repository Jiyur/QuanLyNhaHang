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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        DoanhThu dt = new DoanhThu();
        DataTable table = new DataTable();
        private void ThongKe_Load(object sender, EventArgs e)
        {
            table = dt.getThongKe();
            doanhthu_gridView.DataSource = table;
            time_datepicker.CustomFormat = "dd-MM-yyyy";
            doanhthu_gridView.Columns[0].DefaultCellStyle.Format = "dd-MM-yyyy";
        }
       
        private void time_datepicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                DateTime date = time_datepicker.Value.Date;
                doanhthu_gridView.DataSource = table.Select("Date= '" + date + "'").CopyToDataTable();
            }
            catch
            {
            }
        }

        private void button_lichHienTai_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now.Date;
            doanhthu_gridView.DataSource = table.Select("Date= '" + date + "'").CopyToDataTable();

        }
       

        private void showAll_btn_Click(object sender, EventArgs e)
        {
            doanhthu_gridView.DataSource = table;

        }

        private void chartshow_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (DoanhThuChart dt = new DoanhThuChart())
                dt.ShowDialog();
            this.Show();
        }
    }
}
