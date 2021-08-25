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
    public partial class ChuyenBan : Form
    {
        public ChuyenBan()
        {
            InitializeComponent();
        }
        string ban;
        public string Ban
        {
            get { return ban; }
            set { ban = value; }
        }
        private void ChuyenBan_Load(object sender, EventArgs e)
        {
            tuBan_textBox.Text = ban;
            BanTrong_dataGridView.ReadOnly = true;
            BanTrong_dataGridView.DataSource = new Ban().layBanTrong();
            BanTrong_dataGridView.AllowUserToAddRows = false;
            BanTrong_dataGridView.RowHeadersVisible = false;
        }

        private void BanTrong_dataGridView_DoubleClick(object sender, EventArgs e)
        {
            sangBan_textBox.Text = BanTrong_dataGridView.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!kiemTra())
            {
                int tuBan = int.Parse(tuBan_textBox.Text.ToString());
                int denBan = int.Parse(sangBan_textBox.Text.ToString());
                if(new Ban().Chuyen_ban(tuBan,denBan))
                {
                    new Bill().Chuyen_bill(tuBan, denBan);
                    MessageBox.Show("Chuyển bàn thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Thông tin trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool kiemTra()
        {
            if(tuBan_textBox.Text == "" || sangBan_textBox.Text =="")
            {
                return true;
            }
            return false;
        }
    }
}
