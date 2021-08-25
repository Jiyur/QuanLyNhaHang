using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyNhaHang
{
    class Ban
    {
        My_DB mydb = new My_DB();
        public bool insertBan(int id, int soluongKhach, string trangthai,float tong_TT)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "INSERT INTO Ban([id ban],[so luong khach],[trang thai],[tong thanh toan]) VALUES(@id,@sl,@tt,@ttt)";
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluongKhach;
            command.Parameters.Add("@tt", SqlDbType.VarChar).Value = trangthai;
            command.Parameters.Add("@ttt", SqlDbType.Float).Value = tong_TT;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }
        public bool deleteBan(int id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "DELETE FROM Ban WHERE [id ban]=@id";
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool existBan(int id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT * FROM Ban WHERE [id ban]=@id";
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool updateBan(int id, int soluongKhach, string trangthai,float total)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "UPDATE Ban SET [so luong khach]=@sl,[trang thai]=@tt, [tong thanh toan] = @ttt WHERE [id ban]=@id";
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluongKhach;
            command.Parameters.Add("@tt", SqlDbType.VarChar).Value = trangthai;
            command.Parameters.Add("@ttt", SqlDbType.Float).Value = total;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable getAllBan()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT [id ban] as 'ID',[so luong khach] as 'Số lượng khách',[trang thai] as 'Trạng thái', [tong thanh toan] as [Tổng thanh toan] FROM Ban";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable getTrangThai(int id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT [trang thai] from Ban WHERE [id ban]=@id";
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public bool updateBanSauKhiDatMon(int id, int soluongKhach, string trangthai,float total)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "UPDATE Ban SET [so luong khach]=@sl,[trang thai]=@tt, [tong thanh toan] = @ttt WHERE [id ban]=@id";
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluongKhach;
            command.Parameters.Add("@tt", SqlDbType.VarChar).Value = trangthai;
            command.Parameters.Add("@ttt", SqlDbType.Float).Value = total;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public DataTable layBanTrong()
        {
            SqlCommand command = new SqlCommand("SELECT [id ban] AS [Bàn trống hiện có] FROM Ban WHERE [trang thai] = 'empty'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool Chuyen_ban(int tuBan, int denBan)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Ban WHERE [id ban] = @tu", mydb.getConnection);
            command.Parameters.Add("@tu", SqlDbType.Int).Value = tuBan;
            SqlDataAdapter adapter1 = new SqlDataAdapter(command);
            DataTable table1 = new DataTable();
            adapter1.Fill(table1);
            bool flag1 = updateBan(denBan, int.Parse(table1.Rows[0]["so luong khach"].ToString()), table1.Rows[0]["trang thai"].ToString().Trim(), float.Parse(table1.Rows[0]["tong thanh toan"].ToString()));
            command.CommandText = "SELECT * FROM Ban WHERE [id ban] = @den";
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@den", SqlDbType.Int).Value = denBan;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            bool flag2 = updateBan(tuBan, 0, "empty", 0);
            if(flag1 && flag2)
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
