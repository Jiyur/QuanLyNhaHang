using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace QuanLyNhaHang
{
    class TienCong
    {
        My_DB mydb = new My_DB();
        public bool updateTienCong(int id,int salary,int pen)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "UPDATE TienCong SET [tien cong]=@salary,[tien phat]=@tp " +
                "WHERE [ma nhan vien]=@id";
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@salary", SqlDbType.Int).Value = salary;
            command.Parameters.Add("@tp", SqlDbType.Int).Value = pen;

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
        public bool InsertID(int id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "INSERT INTO TienCong([ma nhan vien]) VALUES(@id)";
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
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
        public bool removeTC()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "DELETE FROM TienCong WHERE [ma nhan vien] is not null";
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
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
        public bool updateTienThuongToID(int id,int salary)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "UPDATE TienCong SET [tien thuong]=@salary WHERE [ma nhan vien]=@id";
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@salary", SqlDbType.Int).Value = salary;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
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
        public DataTable calculate()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT * FROM TienCong";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateRealSalary(int id,int salary)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "UPDATE TienCong SET [tien nhan duoc]=@salary WHERE [ma nhan vien]=@id";
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@salary", SqlDbType.Int).Value = salary;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
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
        public DataTable tienLuong()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT TienCong.[ma nhan vien] as 'ID',[ho ten] as 'Họ tên',[tien cong] as 'Tiền công'," +
                "[tien phat] as 'Tiền phạt',[tien thuong] as 'Tiền thưởng',[tien nhan duoc] as 'Tiền nhận được', " +
                "[tong gio lam] as 'Tổng giờ làm' " +
                "FROM TienCong,NhanVien,ChamCong WHERE TienCong.[ma nhan vien]=NhanVien.[ma nhan vien] " +
                "AND ChamCong.[ma nhan vien]=TienCong.[ma nhan vien]";
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
   
}
