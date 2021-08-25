using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rtChart;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyNhaHang
{
    public partial class DoanhThuChart : Form
    {
        public DoanhThuChart()
        {
            InitializeComponent();
        }
        DoanhThu dt = new DoanhThu();
        private void DoanhThuChart_Load(object sender, EventArgs e)
        {
            doanhthu_gridView.DataSource = dt.getThongKe();
            load_btn_Click_1(null, null);
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
           
            try
            {
                doanhthu_gridView.EndEdit();
            }
            catch
            {

            }
        }

        private void load_btn_Click_1(object sender, EventArgs e)
        {
            chart1.Series[0].XValueType = ChartValueType.DateTime;
            chart1.Series["Revenue"].XValueMember = "Date";
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM-yyyy";
            chart1.Series["Revenue"].YValueMembers = "Total";
            chart1.DataSource = doanhthu_gridView.DataSource;
            chart1.DataBind();
        }
    }
}
