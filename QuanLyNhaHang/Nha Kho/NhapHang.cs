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
    public partial class NhapHang : Form
    {
        public NhapHang()
        {
            InitializeComponent();
        }
        string tenNL;
        public string TenNL
        {
            get { return tenNL; }
            set { tenNL = value; }
        }

        MonAn mon = new MonAn();
        NguyenLieu NL = new NguyenLieu();
        My_DB myDB = new My_DB();
        private void NhapHang_Load(object sender, EventArgs e)
        {
            tenNL_textBox.Text = tenNL;
        }

        private void nhapHang_button_Click(object sender, EventArgs e)
        {
            string ten_NL = tenNL_textBox.Text;
            float sl = float.Parse(soLuong_textBox.Text);
            float gia = float.Parse(gia_textBox.Text);
            DateTime tg = tgNhap_dateTimePicker.Value;
            if (verify())
            {
                try
                {
                    if (NL.NhapNl(ten_NL, sl, gia, tg))
                    {
                        MessageBox.Show("Nhập thành công", "Nhập hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi!!!", "Nhập hàngs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Nhập hàng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Thông tin hàng trống", "Nhập hàng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Close();
        }
        public bool verify()
        {
            if ((tenNL_textBox.Text == "")
                || (soLuong_textBox.Text == "")
                || (gia_textBox.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
