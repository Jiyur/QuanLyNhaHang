using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyNhaHang
{
    class SLmonBan
    {
        My_DB myDB = new My_DB();
        public int layThang()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM SLMonBan", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            int n = table.Columns.Count - 1;
            string thang = table.Columns[n].ToString();
            string[] arr = thang.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsNumeric(arr[i]))
                {
                    return int.Parse(arr[i]);
                }
            }
            return 0;
        }
        static bool IsNumeric(string value)
        {
            try
            {
                char[] chars = value.ToCharArray();
                foreach (char c in chars)
                {
                    if (!char.IsNumber(c))
                        return false;
                }
                return true;
            }
            catch (Exception)
            { return false; }
        }

        public void XoaBang()
        {
            SqlCommand command = new SqlCommand("DROP TABLE SLMonBan;", myDB.getConnection);
            myDB.openConnection();
            command.ExecuteNonQuery();
            myDB.closeConnection();
        }
        public void TaoBang()
        {
            SqlCommand command = new SqlCommand("CREATE TABLE SLMonBan ([id mon] int, [ten mon] varchar(50));", myDB.getConnection);
            myDB.openConnection();
            command.ExecuteNonQuery();
            myDB.closeConnection();
        }
        public void themCot(string day)
        {
            SqlCommand command = new SqlCommand("ALTER TABLE SLMonBan ADD [" + day.Trim() + "] int;", myDB.getConnection);
            myDB.openConnection();
            command.ExecuteNonQuery();
            myDB.closeConnection();
        }

        public DataTable SoLuong(string thang)
        {
            SqlCommand command = new SqlCommand("SELECT [id mon], [ten mon], [" + thang + "] FROM SLMonBan", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void Them(int id_mon, string ten)
        {
            SqlCommand command = new SqlCommand("INSERT INTO SLMonBan([id mon], [ten mon]) VALUES (@id,@ten)", myDB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id_mon;
            command.Parameters.Add("@ten", SqlDbType.VarChar).Value = ten;
            myDB.openConnection();
            command.ExecuteNonQuery();
            myDB.closeConnection();
        }

        public void capnhat(int id_mon, int soluong)
        {
            string ngay = "ngay " + DateTime.Now.Day;
            string thang = "thang " + DateTime.Now.Month;
            SqlCommand command = new SqlCommand("SELECT [" + ngay + "], [" + thang + "] FROM SLMonBan WHERE [id mon] = @id", myDB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id_mon;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            int sl_ngay = 0;
            int sl_thang = 0;
            if (table.Rows[0][0].ToString() == "" && table.Rows[0][1].ToString() == "")
            {
                sl_ngay = soluong;
                sl_thang = soluong;
            }
            else
            {
                if (table.Rows[0][0].ToString() == "" && table.Rows[0][1].ToString() != "")
                {
                    sl_ngay = soluong;
                    sl_thang = int.Parse(table.Rows[0][1].ToString()) + soluong;
                }
                if (table.Rows[0][0].ToString() != "" && table.Rows[0][1].ToString() != "")
                {
                    sl_ngay = int.Parse(table.Rows[0][0].ToString()) + soluong;
                    sl_thang = int.Parse(table.Rows[0][1].ToString()) + soluong;
                }
            }
            SqlCommand cmd = new SqlCommand("UPDATE SlMonBan SET [" + ngay + "] = @sln, [" + thang + "] = @slt WHERE [id mon] = @id", myDB.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id_mon;
            cmd.Parameters.Add("@sln", SqlDbType.Int).Value = sl_ngay;
            cmd.Parameters.Add("@slt", SqlDbType.Int).Value = sl_thang;
            myDB.openConnection();
            cmd.ExecuteNonQuery();
            myDB.closeConnection();
        }
        public DataTable Max(string DayMonth)
        {
            SqlCommand command = new SqlCommand("SELECT  MAX([" + DayMonth + "])AS [max ngay] FROM SlMonBan", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            SqlCommand command1 = new SqlCommand("SELECT  [ten mon] FROM SlMonBan WHERE [" + DayMonth + "] = @n", myDB.getConnection);
            command1.Parameters.Add("@n", SqlDbType.Int).Value = int.Parse(table.Rows[0][0].ToString());
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            DataTable table1 = new DataTable();
            adapter1.Fill(table1);
            return table1;
        }
    }
}
