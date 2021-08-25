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
    public partial class Khohang : Form
    {
        public Khohang()
        {
            InitializeComponent();
        }
        NguyenLieu NL = new NguyenLieu();
        private void Khohang_Load(object sender, EventArgs e)
        {
            NguyenLieu_textBox.Text = "";
            slBanDau_textBox.Text = "";
            slHienTai_textBox.Text = "";
            Gia_textBox.Text = "";
            DSNL_dataGridView.ReadOnly = true;
            DSNL_dataGridView.DataSource = NL.latTatCaNL();
            DSNL_dataGridView.AllowUserToAddRows = true;
        }

        private void DSNL_dataGridView_Click(object sender, EventArgs e)
        {
            NguyenLieu_textBox.Text = DSNL_dataGridView.CurrentRow.Cells[0].Value.ToString();
            slBanDau_textBox.Text = DSNL_dataGridView.CurrentRow.Cells[1].Value.ToString();
            slHienTai_textBox.Text = DSNL_dataGridView.CurrentRow.Cells[2].Value.ToString();
            Gia_textBox.Text = DSNL_dataGridView.CurrentRow.Cells[3].Value.ToString();
            tgNhap_dateTimePicker.Text = DSNL_dataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        /*private void xoaNl_button_Click(object sender, EventArgs e)
        {
            try
            {
                string nl = DSNL_dataGridView.CurrentRow.Cells[0].Value.ToString();
                if (MessageBox.Show("Bạn chắc chắc muốn xóa nguyên liệu này?", "Xóa nguyên liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (NL.XoaNl(nl))
                    {
                        MessageBox.Show("Xóa thành công", "Xóa nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Xóa nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xin hãy chọn nguyên liệu cần xóa", "Xóa món ăn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Khohang_Load(null, null);
        }*/

        private void suaNL_button_Click(object sender, EventArgs e)
        {
            string nl = NguyenLieu_textBox.Text;
            float sl_banDau = float.Parse(slBanDau_textBox.Text);
            DateTime tgNhap = tgNhap_dateTimePicker.Value;
            float sl_hienTai = float.Parse(slHienTai_textBox.Text);
            float gia = float.Parse(Gia_textBox.Text);
            if (verify())
            {
                try
                {
                    if (NL.SuaNL(nl, sl_banDau, sl_hienTai,gia, tgNhap)) 
                    {
                        MessageBox.Show("Sửa thành công", "Sửa nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("lỗi!", "Sửa nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sửa nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Thông tin trống", "Sửa nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Khohang_Load(null, null); 
        }
        public bool verify()
        {
            if ((NguyenLieu_textBox.Text == "")
                || (slBanDau_textBox.Text == "")
                || (Gia_textBox.Text == "")
                || (slHienTai_textBox.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Tailai_button_Click(object sender, EventArgs e)
        {
            Khohang_Load(null, null);
        }

        private void nhapHang_button_Click(object sender, EventArgs e)
        {
            NhapHang nhap = new NhapHang();
            nhap.Show();
        }

        private void DSNL_dataGridView_DoubleClick(object sender, EventArgs e)
        {
            NhapHang nhap = new NhapHang();
            nhap.TenNL = DSNL_dataGridView.CurrentRow.Cells[0].Value.ToString();
            nhap.Show();
        }

        private void xoaNL_button_Click(object sender, EventArgs e)
        {
            try
            {
                string nl = DSNL_dataGridView.CurrentRow.Cells[0].Value.ToString();
                if (MessageBox.Show("Bạn chắc chắc muốn xóa nguyên liệu này?", "Xóa nguyên liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (NL.XoaNl(nl))
                    {
                        MessageBox.Show("Xóa thành công", "Xóa nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Xóa nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xin hãy chọn nguyên liệu cần xóa", "Xóa món ăn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Khohang_Load(null, null);
        }

        private void KiemTra_button_Click(object sender, EventArgs e)
        {
            NhapXuat NX = new NhapXuat();
            this.Hide();
            NX.ShowDialog();
            this.Show();
        }
    }
}
