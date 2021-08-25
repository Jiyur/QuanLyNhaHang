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
    public partial class Bep : Form
    {
        public Bep()
        {
            InitializeComponent();
        }
        MonAn mon = new MonAn();
        private void Bep_Load(object sender, EventArgs e)
        {
            IDMon_textBox.Text = "";
            tenMon_textBox.Text = "";
            Gia_textBox.Text = "";
            CurentQuantity_textBox.Text = "";
            NguyenLieu_textBox.Text = "";
            DsMon_dataGridView.ReadOnly = true;
            DsMon_dataGridView.DataSource = mon.LayTatCaMon();
            DsMon_dataGridView.AllowUserToAddRows = false;
        }

        private void ThemMon_button_Click(object sender, EventArgs e)
        {
            ThemMon themmon = new ThemMon();
            this.Hide();
            themmon.ShowDialog();
            this.Show();
            Bep_Load(null, null);
        }

        private void DsMon_dataGridView_Click(object sender, EventArgs e)
        {
            IDMon_textBox.Text = DsMon_dataGridView.CurrentRow.Cells[0].Value.ToString();
            tenMon_textBox.Text = DsMon_dataGridView.CurrentRow.Cells[1].Value.ToString();
            Gia_textBox.Text = DsMon_dataGridView.CurrentRow.Cells[2].Value.ToString();
            //CurentQuantity_textBox.Text = DsMon_dataGridView.CurrentRow.Cells[3].Value.ToString();
            NguyenLieu_textBox.Text = DsMon_dataGridView.CurrentRow.Cells[3].Value.ToString();
        }

        private void XoaMon_button_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(IDMon_textBox.Text);
                if (MessageBox.Show("Banl chắc chắc muốn xóa món ăn này?", "Xóa món ăn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (mon.XoaMon(id))
                    {
                        mon.XoaMon_ThanhPhan(id);
                        mon.XoaMon_SLMonBan(id);
                        mon.XoaMon_Bill(tenMon_textBox.Text.Trim());
                        MessageBox.Show("Xóa thành công", "Xóa món ăn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Xóa món ăn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xin hãy chọn món cần xóa", "Xóa món ăn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Bep_Load(null, null);
        }

        private void SuaTT_button_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDMon_textBox.Text);
            string name = tenMon_textBox.Text;
            float price = float.Parse(Gia_textBox.Text);
            string mci = NguyenLieu_textBox.Text;
            if (verify())
            {
                try
                {
                    if (mon.SuaMon(id, name, price, mci))
                    {
                        MessageBox.Show("Successful Edit", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro!", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Information", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Bep_Load(null, null);
        }
        public bool verify()
        {
            if ((IDMon_textBox.Text == "")
                || (tenMon_textBox.Text == "")
                || (Gia_textBox.Text == "")
                || (NguyenLieu_textBox.Text == ""))
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
            Bep_Load(null, null);
        }

        private void XepHang_button_Click(object sender, EventArgs e)
        {
            XepHang xep_hang = new XepHang();
            this.Hide();
            xep_hang.ShowDialog();
            this.Show();
        }
    }
}
