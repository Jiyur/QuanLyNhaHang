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
    public partial class SoKhach : Form
    {
        public SoKhach()
        {
            InitializeComponent();
        }
        int flag = 0;
        int so_luong;
        public int soLuong
        {
            get { return so_luong; }
            set { so_luong = value; }
        }
        public int Flag
        {
            get { return flag; }
            set { flag = value; }
        }
        private void Enter_button_Click(object sender, EventArgs e)
        {
            if (soKhach_textBox.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                so_luong = int.Parse(soKhach_textBox.Text);
                flag = 1;
                Close();
            }
        }
    }
}
