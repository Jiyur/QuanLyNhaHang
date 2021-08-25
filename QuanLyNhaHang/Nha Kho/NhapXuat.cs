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
    public partial class NhapXuat : Form
    {
        public NhapXuat()
        {
            InitializeComponent();
        }
        My_DB myDB = new My_DB();
        NguyenLieu NL = new NguyenLieu();
        SLmonBan Sl = new SLmonBan();
        private void KiemTraNX_button_Click(object sender, EventArgs e)
        {
            string thang = "thang " + DateTime.Now.Month;
            DataTable TP_table = new ThanhPhan().layTatCa();
            DataTable SD_table = new DataTable();
            SD_table.Columns.Add("ten nl", typeof(string));
            SD_table.Columns.Add("gam nl", typeof(float));
            for (int i = 1; i < TP_table.Columns.Count; i++)
            {
                float gam = 0;
                SqlCommand command = new SqlCommand("SELECT ID_mon ,[" + TP_table.Columns[i].ToString().Trim() + "], SLMonBan.[" + thang + "] " +
                    "FROM ThanhPhan INNER JOIN SLMonBan ON ThanhPhan.ID_mon = SLMonBan.[id mon] WHERE [" + TP_table.Columns[i].ToString().Trim() + "] IS NOT NULL", myDB.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        if (row[2].ToString() != "")
                        {
                            gam += float.Parse(row[1].ToString()) * int.Parse(row[2].ToString());
                        }
                        else
                        {
                            gam = 0;
                        }
                    }
                    SD_table.Rows.Add(table.Columns[1].ToString(), gam);
                }
            }
            DataTable KT_table = new DataTable();
            KT_table.Columns.Add("ten nguyen lieu", typeof(string));
            KT_table.Columns.Add("chenh lech", typeof(float));
            TP_table = NL.latTatCaNL();
            foreach (DataRow row_Tp in TP_table.Rows)
            {
                foreach (DataRow Row_SD in SD_table.Rows)
                {
                    if (row_Tp[0].ToString().Trim() == Row_SD[0].ToString().Trim())
                    {
                        float x = float.Parse(row_Tp[2].ToString()) + float.Parse(Row_SD[1].ToString()) / 1000;
                        float y = float.Parse(row_Tp[1].ToString());
                        if (!kiemTra(x, y))
                        {
                            KT_table.Rows.Add(row_Tp[0].ToString(), Math.Abs((x / y) - 0.95));
                        }
                    }
                }
            }
            if (KT_table.Rows.Count > 0)
            {
                DialogResult dlr0 = MessageBox.Show("Có một số nguyên liệu chênh lệch với ban đầu khá nhiều.\n" +
                    "Ban có muốn xem chi tiết", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dlr0 == DialogResult.Yes)
                {
                    ChenhLech chenh = new ChenhLech();
                    chenh.Table = KT_table;
                    this.Hide();
                    chenh.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Không có vấn đề gì trong kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NhapXuat_Load(object sender, EventArgs e)
        {
            Nhap_dataGridView.ReadOnly = true;
            Nhap_dataGridView.DataSource = NL.latTatCaNL();
            Nhap_dataGridView.Columns["Gia NL/kg"].Visible = false;
            Nhap_dataGridView.Columns["Thoi Gian Nhap"].Visible = false;
            Nhap_dataGridView.AllowUserToAddRows = false;

            Xuat_dataGridView.ReadOnly = true;
            Xuat_dataGridView.DataSource = Sl.SoLuong("thang " + DateTime.Now.Month);
            Xuat_dataGridView.AllowUserToAddRows = false;
        }

        public bool kiemTra(float x, float y)
        {
            if (x / y > 0.95)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
