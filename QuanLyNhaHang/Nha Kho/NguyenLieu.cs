using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyNhaHang
{
    class NguyenLieu
    {

        My_DB myDB = new My_DB();
        public DataTable latTatCaNL()
        {
            SqlCommand command = new SqlCommand("SELECT ten_nl AS [Ten Nguyen Lieu],[so luong_bd] AS [SL Ban Dau],[so luong_ht] AS [SL Hien Tai], gia_nl AS [Gia NL/kg], " +
                "tg_nhap AS [Thoi Gian Nhap] FROM KhoHang", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool ThemNL(string tenNl)
        {
            SqlCommand command = new SqlCommand("INSERT INTO KhoHang(ten_nl) VALUES (@mat)", myDB.getConnection);
            command.Parameters.Add("@mat", SqlDbType.VarChar).Value = tenNl;
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

        public bool XoaNl(string tenNl)
        {
            SqlCommand command = new SqlCommand("DELETE  FROM KhoHang WHERE ten_nl = @mat", myDB.getConnection);
            command.Parameters.Add("@mat", SqlDbType.VarChar).Value = tenNl;
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

        public bool SuaNL(string tenNL, float sl_banDau, float sl_hientai, float gia, DateTime tg)
        {
            SqlCommand command = new SqlCommand("UPDATE KhoHang SET tg_nhap = @it,gia_nl = @pri,[so luong_bd] = @sbd, [so luong_ht] = @sht WHERE ten_nl = @mat", myDB.getConnection);
            command.Parameters.Add("@mat", SqlDbType.VarChar).Value = tenNL;
            command.Parameters.Add("@sbd", SqlDbType.Float).Value = sl_banDau;
            command.Parameters.Add("@sht", SqlDbType.Float).Value = sl_hientai;
            command.Parameters.Add("@pri", SqlDbType.Float).Value = gia;
            command.Parameters.Add("@it", SqlDbType.Date).Value = tg;
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

        public bool NhapNl(string tenNL, float soLuong, float gia, DateTime Tg)
        {
            SqlCommand command = new SqlCommand("UPDATE KhoHang SET [so luong_bd] = @OM, gia_nl = @pri,tg_nhap = @IT, [so luong_ht] = @RM  WHERE ten_nl = @mat ", myDB.getConnection);
            command.Parameters.Add("@mat", SqlDbType.VarChar).Value = tenNL;
            command.Parameters.Add("@OM", SqlDbType.Float).Value = soLuong;
            command.Parameters.Add("@pri", SqlDbType.Float).Value = gia;
            command.Parameters.Add("@IT", SqlDbType.Date).Value = Tg;
            command.Parameters.Add("@RM", SqlDbType.Float).Value = soLuong;
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

        public bool check(string tenNL)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM KhoHang WHERE ten_nl = @mat", myDB.getConnection);
            command.Parameters.Add("@mat", SqlDbType.VarChar).Value = tenNL;
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

        public void layNL(string tenNl, double soLuong)
        {
            SqlCommand command = new SqlCommand("UPDATE KhoHang SET [so luong_ht] = @RM  WHERE ten_nl = @mat ", myDB.getConnection);
            command.Parameters.Add("@mat", SqlDbType.VarChar).Value = tenNl;
            command.Parameters.Add("@RM", SqlDbType.Float).Value = soLuong;
            myDB.openConnection();
            command.ExecuteNonQuery();
            myDB.closeConnection();
        }
    }
}
