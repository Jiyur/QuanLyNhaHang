using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyNhaHang
{
    class Bill
    {
        My_DB myDB = new My_DB();
        public DataTable layBill(int id_ban)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Bill WHERE [id ban] = @id", myDB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id_ban;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            DataTable Bill_table = new DataTable();
            Bill_table.Columns.Add("Ten mon", typeof(string));
            Bill_table.Columns.Add("So luong", typeof(int));
            for (int i = 1; i < table.Columns.Count; i++)
            {
                if(table.Rows[0][i].ToString() != "")
                {
                    Bill_table.Rows.Add(table.Columns[i].ToString(), int.Parse(table.Rows[0][i].ToString().Trim()));
                }
            }

            Bill_table.Columns.Add("Gia", typeof(double));
            SqlCommand cmd = new SqlCommand("SELECT [ten mon] , gia FROM MonAn", myDB.getConnection);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataTable MonAn_table = new DataTable();
            ada.Fill(MonAn_table);
            for (int i = 0; i < Bill_table.Rows.Count; i++)
            {
                for (int j = 0; j < MonAn_table.Rows.Count; j++)
                {
                    if (Bill_table.Rows[i]["Ten mon"].ToString() == MonAn_table.Rows[j]["ten mon"].ToString())
                    {
                        Bill_table.Rows[i]["Gia"] = MonAn_table.Rows[j]["gia"];
                    }
                }
            }
            return Bill_table;
        }
        public void ThemMon(string name)
        {
            SqlCommand cmd = new SqlCommand("ALTER TABLE Bill ADD [" + name.Trim() + "] Int;", myDB.getConnection);
            myDB.openConnection();
            cmd.ExecuteNonQuery();
            myDB.closeConnection();
        }

        public void ThemVaoBill(int id_ban, string tenMon, int soLuong)
        {
            SqlCommand command = new SqlCommand("UPDATE Bill SET [" + tenMon.Trim() + "] = @SL WHERE [id ban] = @id", myDB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id_ban;
            command.Parameters.Add("@SL", SqlDbType.Int).Value = soLuong;
            myDB.openConnection();
            command.ExecuteNonQuery();
            myDB.closeConnection();
        }

        public void ThemID_ban(int id_ban)
        {
            SqlCommand command = new SqlCommand("INSERT INTO  Bill([id ban]) VALUES (@Id)", myDB.getConnection);
            command.Parameters.Add("@Id", SqlDbType.VarChar).Value = id_ban;
            myDB.openConnection();
            command.ExecuteNonQuery();
            myDB.closeConnection();
        }

        public void CapNhapBill(int id_ban,string tenMon, int soluong)
        {
            SqlCommand command = new SqlCommand("UPDATE Bill SET ["+ tenMon +"] = @TN WHERE [id ban] = @id", myDB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id_ban;
            command.Parameters.Add("@TN", SqlDbType.Int).Value = soluong;
            myDB.openConnection();
            command.ExecuteNonQuery();
            myDB.closeConnection();
        }

        public void ThanhToan(int id_ban)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Bill WHERE [id ban]=@id", myDB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id_ban;
            myDB.openConnection();
            command.ExecuteNonQuery();
            myDB.closeConnection();
        }

        public void XoaBill(int id_ban)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Bill WHERE [id ban] = @id", myDB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id_ban;
            myDB.openConnection();
            command.ExecuteNonQuery();
            myDB.closeConnection();
        }

        public void Chuyen_bill (int tuBan, int denBan)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Bill WHERE [id ban] = @tu", myDB.getConnection);
            command.Parameters.Add("@tu", SqlDbType.Int).Value = tuBan;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            try
            {
                for (int i = 1; i < table.Columns.Count; i++)
                {
                    ThemID_ban(denBan);
                    CapNhapBill(denBan, table.Columns[i].ToString().Trim(), int.Parse(table.Rows[0][i].ToString()));
                }
                XoaBill(tuBan);
            }
            catch
            {

            }
        }
    }
}
