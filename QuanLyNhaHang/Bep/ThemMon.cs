using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaHang
{
    public partial class ThemMon : Form
    {
        public ThemMon()
        {
            InitializeComponent();
        }
        SLmonBan Sl = new SLmonBan();
        MonAn mon = new MonAn();
        My_DB myDB = new My_DB();
        ThanhPhan tp = new ThanhPhan();
        NguyenLieu Nl = new NguyenLieu();
        Bill bl = new Bill();
        int flag = 0;
        string mci = "";
        int id = 0;
        string tenNl = "";
        private void NhapNL_button_Click(object sender, EventArgs e)
        {
            id = int.Parse(dishID_textBox.Text);
            tenNl = chuanHoa(nguyenLieu_textBox.Text.Trim());
            float gam = float.Parse(KhoiLuong_textBox.Text);
            mci += tenNl + ", ";
            if (nguyenLieu_textBox.Text != "" || KhoiLuong_textBox.Text != "" || dishID_textBox.Text != "")
            {
                if (Check(id))
                {
                    tp.Them(id);
                }
                if (Nl.check(tenNl) && mon.Check(tenNl))
                {
                    DialogResult dlr = MessageBox.Show(tenNl + " không có trong kho!!! Bạn co muốn thêm vào kho??", "Lưu Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        tp.Tao(tenNl);
                        Nl.ThemNL(tenNl);
                        NhapHang nhap = new NhapHang();
                        nhap.TenNL = tenNl;
                        this.Hide();
                        nhap.ShowDialog();
                        this.Show();
                    }
                }else
                {
                    if(Nl.check(tenNl) && !mon.Check(tenNl))
                    {
                        DialogResult dlr = MessageBox.Show(tenNl + " không có trong kho!!! Bạn co muốn thêm vào kho??", "Lưu Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlr == DialogResult.Yes)
                        {
                            Nl.ThemNL(tenNl);
                            NhapHang nhap = new NhapHang();
                            nhap.TenNL = tenNl;
                            this.Hide();
                            nhap.ShowDialog();
                            this.Show();
                        }
                    }
                    if(!Nl.check(tenNl) && mon.Check(tenNl))
                    {
                        tp.Tao(tenNl);
                    }
                }
                tp.CapNhap(id, tenNl, gam);
            }
            else
            {
                MessageBox.Show("Nguyên liệu trống", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            NguyenLieu_listBox.Items.Add(nguyenLieu_textBox.Text + "/" + KhoiLuong_textBox.Text + "(gam)");
            nguyenLieu_textBox.Text = "";
            KhoiLuong_textBox.Text = "";
        }

        private void ThemMon_button_Click(object sender, EventArgs e)
        {
            id = int.Parse(dishID_textBox.Text);
            tenNl = nameDish_textBox.Text;
            string ten_mon = nameDish_textBox.Text.Trim();
            float price = float.Parse(price_textBox.Text);
            if (verify())
            {
                if (mon.ThemMon(id, tenNl, price, mci))
                {
                    MessageBox.Show("Thêm món thành công", "Thêm Món", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bl.ThemMon(ten_mon);
                    Sl.Them(id, ten_mon);
                }
                else
                {
                    MessageBox.Show("lỗi!", "Thêm món", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thông tin trống", "Thêm món", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            flag = 1;
        }

        private void Thoat_button_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                DialogResult dlr0 = MessageBox.Show("Bạn có muốn thoát mà chưa thêm món ăn ", "Chú ý!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr0 == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("DELETE FROM ThanhPhan WHERE ID_mon = @id", myDB.getConnection);
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    Close();
                }
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắn chắn muốn thoát ", "Chú ý!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    Close();
                }
            }
        }
        public bool verify()
        {
            if ((dishID_textBox.Text == "")
                || (nameDish_textBox.Text == "")
                || (price_textBox.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Check(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM ThanhPhan WHERE ID_mon = @id", myDB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ThemMon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == 0)
            {
                DialogResult dlr0 = MessageBox.Show("Bạn có muốn thoát mà chưa thêm món ăn ", "Chú ý!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr0 == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("DELETE FROM ThanhPhan WHERE ID_mon = @id", myDB.getConnection);
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        public string chuanHoa(string tenMon)
        {
            string ten;
            string Result = "";
            ten = tenMon;
            while (ten.IndexOf("  ") != -1)
            {
                ten = ten.Replace("  ", " ");
            }
            string[] SubName = ten.Split(' ');

            for (int i = 0; i < SubName.Length; i++)
            {
                Result += SubName[i] + " ";
            }
            return Result;
        }

        private void ThemMon_Load(object sender, EventArgs e)
        {

        }
    }
}
