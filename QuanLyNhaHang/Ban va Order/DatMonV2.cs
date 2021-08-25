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
    public partial class DatMonV2 : Form
    {
        public DatMonV2()
        {
            InitializeComponent();
        }
        SLmonBan sl = new SLmonBan();
        NguyenLieu NL = new NguyenLieu();
        MonAn mn = new MonAn();
        DataTable menu = new DataTable();
        DataTable sele = new DataTable();
        int total = 0;
        public bool pr = false;
        My_DB myDB = new My_DB();
        Bill bill = new Bill();
        int id_ban;
        int flag = 0;
        public int Flag
        {
            get { return flag; }
            set { flag = value; }
        }
        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        public int ID_ban
        {
            get { return id_ban; }
            set { id_ban = value; }
        }

        private void DatMonV2_Load(object sender, EventArgs e)
        {
            menu = mn.LayMenu();
            sele = menu.Clone();
            sele.Columns.Add("SL", typeof(System.Int32));
            ListMon_dataGrid.RowTemplate.Height = 50;

            ListMon_dataGrid.DataSource = menu;
            ListMon_dataGrid.ReadOnly = true;
            ListMon_dataGrid.AllowUserToAddRows = false;
            ListMon_dataGrid.Columns["ID"].Visible = false;
            ListMon_dataGrid.AllowUserToResizeRows = false;
            Select_dataGrid.DataSource = sele;
            Select_dataGrid.ReadOnly = true;
            Select_dataGrid.Columns["ID"].Visible = false;
            Select_dataGrid.AllowUserToAddRows = false;
            Select_dataGrid.RowTemplate.Height = 50;
            LoadTotal();
            banid_label.Text = "Bàn số: " + id_ban;
        }
       

        private void ListMon_dataGrid_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ListMon_dataGrid.CurrentRow.Cells[0].Value.ToString());
            if (sele.Select("ID='" + id + "'").Length == 0)
            {
                foreach(DataRow dr in menu.Rows)
                {
                    if ((int)dr["ID"] == id)
                    {
                        sele.Rows.Add(dr.ItemArray);
                        DataRow[] mr = sele.Select("ID='" + id + "'");
                        mr[0]["SL"] = 1;
                        break;
                    }
                }
            }
            else
            {
                DataRow[] mr = sele.Select("ID='" + id + "'");
                mr[0]["SL"] =(int)mr[0]["SL"]+ 1;
            }
            LoadTotal();

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sele.Rows.Count > 0)
                {
                    int id = int.Parse(Select_dataGrid.CurrentRow.Cells[0].Value.ToString());
                    {
                        DataRow[] mr = sele.Select("ID='" + id + "'");
                        sele.Rows.Remove(mr[0]);
                    }
                }
                else
                {
                    MessageBox.Show("Không có món ăn nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

            }
            LoadTotal();

        }

        private void des_btn_Click(object sender, EventArgs e)
        {
            if (sele.Rows.Count > 0)
            {
                int id = int.Parse(Select_dataGrid.CurrentRow.Cells[0].Value.ToString());
                {
                    DataRow[] mr = sele.Select("ID='" + id + "'");
                    if ((int)mr[0]["SL"] > 0)
                        mr[0]["SL"] = (int)mr[0]["SL"] - 1;

                }
            }
            else
            {
                MessageBox.Show("Không có món ăn nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadTotal();

        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            if (sele.Rows.Count > 0)
            {
                int id = int.Parse(Select_dataGrid.CurrentRow.Cells[0].Value.ToString());
                {
                    DataRow[] mr = sele.Select("ID='" + id + "'");
                    mr[0]["SL"] = (int)mr[0]["SL"] + 1;
                }
            }
            else
            {
                MessageBox.Show("Không có món ăn nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadTotal();

        }
        public void LoadTotal()
        {
            total = 0;
            if (sele.Rows.Count > 0)
            {
                foreach (DataRow dr in sele.Rows)
                {
                    total = total + int.Parse(dr["Gia"].ToString()) * int.Parse(dr["SL"].ToString());
                }
                Total_label.Text = "Total: " + total.ToString().Trim() + ".VND";
            }
            else
            {
                Total_label.Text = "Total: 0.VND";
            }
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (sele.Rows.Count > 0)
            {
                bill.ThemID_ban(id_ban);
                foreach (DataRow dr in sele.Rows)
                {

                    DataTable table = new DataTable();
                    table.Columns.Add("Nguyen Lieu", typeof(string));
                    table.Columns.Add("gam", typeof(double));
                    int number = int.Parse(dr["SL"].ToString());
                    string nameDish = dr["Ten Mon An"].ToString();
                    string sql = "SELECT [nguyen lieu] FROM MonAn WHERE [ten mon] = @na";
                    SqlCommand command = new SqlCommand();
                    command.CommandText = sql;
                    command.Connection = myDB.getConnection;
                    command.Parameters.Add("@na", SqlDbType.VarChar).Value = nameDish;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable NL_table = new DataTable();
                    adapter.Fill(NL_table);
                    string main_CI = NL_table.Rows[0][0].ToString();
                    string[] arrMain_CI = main_CI.Split(',');
                    for (int i = 0; i < arrMain_CI.Length - 1; i++)
                    {
                        if (arrMain_CI[i] != " ")
                        {
                            SqlCommand com = new SqlCommand("SELECT [" + arrMain_CI[i].Trim() + "] FROM ThanhPhan WHERE ID_mon = @id", myDB.getConnection);
                            com.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(dr["ID"].ToString());
                            SqlDataAdapter tp_adapter = new SqlDataAdapter(com);
                            DataTable TP_table = new DataTable();
                            tp_adapter.Fill(TP_table);
                            float gam = float.Parse(TP_table.Rows[0][0].ToString()) * number;
                            sql = "SELECT [so luong_ht] FROM KhoHang WHERE ten_nl = '" + arrMain_CI[i].Trim() + "'";
                            command.CommandText = sql;
                            command.Connection = myDB.getConnection;
                            SqlDataAdapter SL_adapter = new SqlDataAdapter(command);
                            DataTable SL_table = new DataTable();
                            SL_adapter.Fill(SL_table);
                            float RemainingMasss = float.Parse(SL_table.Rows[0][0].ToString());
                            string materials = arrMain_CI[i].Trim();
                            RemainingMasss = RemainingMasss - gam / 1000;
                            if (Math.Round(RemainingMasss, 2) < 0)
                            {
                                MessageBox.Show("Món đã hết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                            else
                            {
                                table.Rows.Add(arrMain_CI[i].Trim(), Math.Round(RemainingMasss, 2));
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    foreach (DataRow row in table.Rows)
                    {
                        NL.layNL(row[0].ToString(), double.Parse(row[1].ToString()));
                    }
                    bill.ThemVaoBill(id_ban, nameDish, number);
                    sl.capnhat(int.Parse(dr["ID"].ToString()), int.Parse(dr["SL"].ToString()));
                    flag = 1;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Chưa có món ăn nào được chọn", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
