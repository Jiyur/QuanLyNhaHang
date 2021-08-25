using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyNhaHang
{
    class MonAn
    {

        My_DB myDB = new My_DB();
        public DataTable LayTatCaMon()
        {
            SqlCommand command = new SqlCommand("SELECT id AS [ID Mon An], [ten mon] AS [Ten Mon An], gia AS [Gia],[nguyen lieu] AS [Nguyen Lieu] FROM MonAn", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable LayMenu()
        {
            SqlCommand command = new SqlCommand("SELECT id AS [ID], [ten mon] AS [Ten Mon An], gia AS [Gia] FROM MonAn", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable LayMon(SqlCommand command)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool ThemMon(int id, string name, float price, string mci)
        {
            SqlCommand command = new SqlCommand("INSERT INTO MonAn(id,[ten mon],gia,[nguyen lieu]) VALUES (@id,@na,@pr,@mci)", myDB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@na", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@pr", SqlDbType.Float).Value = price;
            command.Parameters.Add("@mci", SqlDbType.VarChar).Value = mci;
            myDB.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                myDB.closeConnection();
                return true;
            }
            else
            {
                myDB.closeConnection();
                return false;
            }
        }

        public bool XoaMon(int id)
        {
            SqlCommand command = new SqlCommand("DELETE  FROM MonAn WHERE id = @ID", myDB.getConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            myDB.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                myDB.closeConnection();
                return true;
            }
            else
            {
                myDB.closeConnection();
                return false;
            }
        }
        public bool XoaMon_ThanhPhan(int id)
        {
            SqlCommand command = new SqlCommand("DELETE  FROM ThanhPhan WHERE ID_mon = @ID", myDB.getConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            myDB.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                myDB.closeConnection();
                return true;
            }
            else
            {
                myDB.closeConnection();
                return false;
            }
        }
        public bool XoaMon_SLMonBan(int id)
        {
            SqlCommand command = new SqlCommand("DELETE  FROM SLMonBan WHERE [id mon] = @ID", myDB.getConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            myDB.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                myDB.closeConnection();
                return true;
            }
            else
            {
                myDB.closeConnection();
                return false;
            }
        }
        public bool XoaMon_Bill(string label)
        {
            SqlCommand command = new SqlCommand("ALTER TABLE Bill DROP COLUMN " + label + "", myDB.getConnection);
            myDB.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                myDB.closeConnection();
                return true;
            }
            else
            {
                myDB.closeConnection();
                return false;
            }
        }
        public bool SuaMon(int id, string name, float price, string MCI)
        {
            SqlCommand command = new SqlCommand("UPDATE MonAn SET [ten mon] = @na, gia = @pri, [nguyen lieu] = @mci WHERE id = @ID", myDB.getConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@na", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@pri", SqlDbType.Float).Value = price;
            command.Parameters.Add("@mci", SqlDbType.VarChar).Value = MCI;
            myDB.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                myDB.closeConnection();
                return true;
            }
            else
            {
                myDB.closeConnection();
                return false;
            }
        }

        public bool Check(string tenMon)
        {
            bool check = true;
            SqlCommand command = new SqlCommand("SELECT * FROM ThanhPhan", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            string[] columnNames = (from dc in table.Columns.Cast<DataColumn>()
                                    select dc.ColumnName).ToArray();
            for (int i = 1; i < columnNames.Length; i++)
            {
                if(columnNames[i].ToString() == tenMon.Trim())
                {
                    return check = false;
                }
            }
            return check;
        }
    }
}
