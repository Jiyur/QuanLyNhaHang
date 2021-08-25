using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyNhaHang
{
    class ThanhPhan
    {
        My_DB myDB = new My_DB();
        public void Tao(string name)
        {
            SqlCommand command = new SqlCommand("ALTER TABLE ThanhPhan ADD [" + name.Trim() + "] Float;", myDB.getConnection);
            myDB.openConnection();
            command.ExecuteNonQuery();
            myDB.closeConnection();
        }

        public void Them(int IDmon)
        {
            SqlCommand command = new SqlCommand("INSERT INTO  ThanhPhan(ID_mon) VALUES (@Id)", myDB.getConnection);
            command.Parameters.Add("@Id", SqlDbType.VarChar).Value = IDmon;
            myDB.openConnection();
            command.ExecuteNonQuery();
            myDB.closeConnection();
        }

        public void CapNhap(int IDmon, string name, float gam)
        {
            SqlCommand command = new SqlCommand("UPDATE ThanhPhan SET [" + name.Trim() + "] = @g WHERE ID_mon = @id", myDB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = IDmon;
            command.Parameters.Add("@g", SqlDbType.Float).Value = gam;
            myDB.openConnection();
            command.ExecuteNonQuery();
            myDB.closeConnection();
        }

        public DataTable layTatCa()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM ThanhPhan", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
