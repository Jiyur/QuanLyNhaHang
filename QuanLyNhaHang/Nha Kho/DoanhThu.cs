using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyNhaHang
{
    class DoanhThu
    {
        My_DB mydb = new My_DB();
        public bool insertDoanhThu(int id,int thanhtoan,DateTime date)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO DoanhThu ([id ban],[thanh toan],[ngay thu]) VALUES(@id,@tt,@date)";
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@tt", SqlDbType.Int).Value = thanhtoan;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            command.Connection = mydb.getConnection;
            mydb.openConnection();
            if(command.ExecuteNonQuery()==1)
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
        public DataTable getThongKe()
        {
            SqlCommand command = new SqlCommand("SELECT [ngay thu] as 'Date',SUM([thanh toan]) as 'Total' FROM DoanhThu " +
                "GROUP BY [ngay thu]",mydb.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;

            

        }
    }
}
