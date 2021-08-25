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
    public partial class BanGhe : Form
    {
        public BanGhe()
        {
            InitializeComponent();
        }
        Ban ban = new Ban();
        DataTable bang = new DataTable();
        DoanhThu dt = new DoanhThu();
        private void BanGhe_Load(object sender, EventArgs e)
        {
            bang = ban.getAllBan();
            DsBan_dataGridView.DataSource = bang;
            DsBan_dataGridView.AllowUserToAddRows = false;
            id_txtbox.Text = "";
            slk_txtbox.Text = "";
            trangthai_txtbox.Text = "";
            thanhToan_textBox.Text = "";
        }
        bool verif()
        {
            if (id_txtbox.Text.Trim() == ""
                || slk_txtbox.Text.Trim() == ""
                || trangthai_txtbox.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }
        private void ThemBan_button_Click(object sender, EventArgs e)
        {
           
            try
            {
                int id = int.Parse(id_txtbox.Text.Trim());
                int slk = int.Parse(slk_txtbox.Text.Trim());
                string trangthai = trangthai_txtbox.Text.Trim();
                float tong_TT = float.Parse(thanhToan_textBox.Text);
                if (verif()&&!ban.existBan(id))
                {
                    if (ban.insertBan(id, slk, trangthai,tong_TT))
                    {
                        MessageBox.Show("Them Thanh Cong", "Them Ban", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Tailai_button_Click(null, null);
                    }
                   
                }
                else
                {
                    MessageBox.Show("Them That Bai", "Them Ban", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Them That Bai Do ID Ban Nay Da Ton Tai", "Them Ban", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Tailai_button_Click(object sender, EventArgs e)
        {
            BanGhe_Load(null, null);
        }

        private void DsBan_dataGridView_Click(object sender, EventArgs e)
        {
            id_txtbox.Text = DsBan_dataGridView.CurrentRow.Cells[0].Value.ToString().Trim();
            slk_txtbox.Text = DsBan_dataGridView.CurrentRow.Cells[1].Value.ToString().Trim();
            trangthai_txtbox.Text = DsBan_dataGridView.CurrentRow.Cells[2].Value.ToString().Trim();
            thanhToan_textBox.Text = DsBan_dataGridView.CurrentRow.Cells[3].Value.ToString().Trim();
        }

        private void XoaBan_button_Click(object sender, EventArgs e)
        {
            int id =int.Parse(DsBan_dataGridView.CurrentRow.Cells[0].Value.ToString().Trim());
            if (ban.deleteBan(id))
            {
                MessageBox.Show("Delete Succesful", "Xoa Ban", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tailai_button_Click(null, null);
            }
            else
            {
                MessageBox.Show("Failed to delete", "Xoa Ban", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SuaTT_button_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(id_txtbox.Text.Trim());
                int slk = int.Parse(slk_txtbox.Text.Trim());
                string trangthai = trangthai_txtbox.Text.Trim();
                float thanh_toan = float.Parse(thanhToan_textBox.Text);
                if (ban.updateBan(id, slk, trangthai,thanh_toan))
                {
                    MessageBox.Show("Edit Succesful", "Edit Ban", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Tailai_button_Click(null, null);

                }
                else
                {
                    MessageBox.Show("Failed to edit", "Edit Ban", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch(Exception)
            {

            }
        }

        private void DsBan_dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (trangthai_txtbox.Text == "empty")
            {
                if (trangthai_txtbox.Text == "empty")
                {
                    SoKhach SL = new SoKhach();
                    this.Hide();
                    SL.ShowDialog();
                    this.Show();
                    int flag = SL.Flag;
                    int Sl = SL.soLuong;
                    if (flag == 1)
                    {
                        DatMonV2 goi_mon = new DatMonV2();
                        goi_mon.ID_ban = int.Parse(id_txtbox.Text);
                        this.Hide();
                        goi_mon.ShowDialog();
                        this.Show();
                        if(goi_mon.Flag == 1)
                        {
                            ban.updateBan(int.Parse(id_txtbox.Text), Sl, "full",goi_mon.Total);
                            Tailai_button_Click(null, null);
                        }
                    }
                }
            }
            
        }

        private void xuatBill_button_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            if (id_txtbox.Text == "")
            {
                MessageBox.Show("Vui lòng chọn bàn cần xuất bill", "Thông bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (trangthai_txtbox.Text == "empty")
                {
                    MessageBox.Show("Bàn trống", "Thông bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XuatBill xuat_bill = new XuatBill();
                    xuat_bill.ID_ban = int.Parse(id_txtbox.Text.Trim());
                    DataTable table = bill.layBill(int.Parse(id_txtbox.Text.Trim()));
                    int sl = table.Rows.Count;
                    int size = 100 + (sl - 1) * 10 + sl * 20 + 300;
                    xuat_bill.Size = new System.Drawing.Size(500, size);
                    this.Hide();
                    xuat_bill.ShowDialog();
                    this.Show();
                    int idb = int.Parse(id_txtbox.Text.Trim());
                    DateTime date = DateTime.Now;
                    int thanhtoan = int.Parse(thanhToan_textBox.Text.Trim());
                    dt.insertDoanhThu(idb, thanhtoan, date);
                    ban.updateBan(int.Parse(id_txtbox.Text.Trim()), 0,"empty",0);
                    bill.ThanhToan(int.Parse(id_txtbox.Text.Trim()));
                    Tailai_button_Click(null, null);
                }
            }

        }

        private void chuyenBan_button_Click(object sender, EventArgs e)
        {
            ChuyenBan chuyen = new ChuyenBan();
            chuyen.Ban = id_txtbox.Text.ToString();
            this.Hide();
            chuyen.ShowDialog();
            this.Show();
            Tailai_button_Click(null, null);
        }
    }
}
