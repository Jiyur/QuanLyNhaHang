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
    class Nhanvien
    {
        My_DB myDB = new My_DB();
        //Trả về danh sách nhân viên
        public DataTable layDSNV()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = myDB.getConnection;
            command.CommandText = ("SELECT TaiKhoan.[ma nhan vien] as ID,[ten dang nhap] as 'Tên Đăng Nhập' ,[mat khau] as 'Mật khẩu',[chuc vu] as 'Chức vụ'," +
                "[ho ten] as 'Họ tên' ,[ngay sinh] as 'Ngày sinh'" +
                ",[gioi tinh] as 'Sex',[so dien thoai] as 'Phone',[dia chi] as 'Address',[hinh anh] as 'Picture' FROM TaiKhoan, NhanVien " +
                "WHERE TaiKhoan.[ma nhan vien] = NhanVien.[ma nhan vien]");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
       
        //Trả về danh sách phân công
        public DataTable layDSPC()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = myDB.getConnection;
            command.CommandText = ("SELECT PhanCong.[ma nhan vien] as 'ID' ,[ho ten] as 'Họ Tên',ca1 as Ca1,ca2 as Ca2,ca3 as Ca3,[chuc vu] as 'Jobs' FROM PhanCong " +
                "inner JOIN NhanVien ON PhanCong.[ma nhan vien]=NhanVien.[ma nhan vien] JOIN TaiKhoan " +
                "ON TaiKhoan.[ma nhan vien]=NhanVien.[ma nhan vien]");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //Insert nhân viên vào database
        public bool themNV(int maNV, string tenDN, string matKhau, string hoten, DateTime ngSinh, string phai, string sdt, string chucvu, string diachi, MemoryStream hinhanh)
        {
            SqlCommand command = new SqlCommand("INSERT INTO TaiKhoan([ma nhan vien],[ten dang nhap],[mat khau],[chuc vu]) VALUES (@MNV,@TDN,@MK,@CV)", myDB.getConnection);
            command.Parameters.Add("@MNV", SqlDbType.Int).Value = maNV;
            command.Parameters.Add("@TDN", SqlDbType.VarChar).Value = tenDN;
            command.Parameters.Add("@Mk", SqlDbType.VarChar).Value = matKhau;
            command.Parameters.Add("@CV", SqlDbType.NVarChar).Value = chucvu;
            SqlCommand cmd = new SqlCommand("INSERT INTO NhanVien ([ma nhan vien],[ho ten],[ngay sinh],[gioi tinh],[so dien thoai],[dia chi],[hinh anh]) VALUES (@maNhanVien,@HT,@NS,@P,@soDt,@DC,@HA)", myDB.getConnection);
            cmd.Parameters.Add("@maNhanVien", SqlDbType.Int).Value = maNV;
            cmd.Parameters.Add("@HT", SqlDbType.VarChar).Value = hoten;
            cmd.Parameters.Add("@NS", SqlDbType.DateTime).Value = ngSinh;
            cmd.Parameters.Add("@P", SqlDbType.VarChar).Value = phai;
            cmd.Parameters.Add("@soDT", SqlDbType.VarChar).Value = sdt;
            cmd.Parameters.Add("@DC", SqlDbType.VarChar).Value = diachi;
            cmd.Parameters.Add("@HA", SqlDbType.Image).Value = hinhanh.ToArray();

            myDB.openConnection();
            if ((command.ExecuteNonQuery() == 1) && (cmd.ExecuteNonQuery() == 1))
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

        public DataTable layNV(SqlCommand command)
        {
            command.Connection = myDB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            try
            {
                adapter.Fill(table);

            }
            catch (Exception)
            { 
            }
            return table;

        }

        public bool SuaNV(int maNV, string tenDN, string matKhau, string hoten, DateTime ngSinh, string phai, string sdt, string chucvu, string diachi, MemoryStream hinhanh)
        {
            SqlCommand command = new SqlCommand("UPDATE TaiKhoan SET [ten dang nhap] = @TDN, [mat khau] = @MK,[chuc vu] = @CV WHERE [ma nhan vien]=@MNV", myDB.getConnection);
            command.Parameters.Add("@MNV", SqlDbType.Int).Value = maNV;
            command.Parameters.Add("@TDN", SqlDbType.VarChar).Value = tenDN;
            command.Parameters.Add("@Mk", SqlDbType.VarChar).Value = matKhau;
            command.Parameters.Add("@CV", SqlDbType.NVarChar).Value = chucvu;
            SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET [ho ten] = @HT, [ngay sinh] = @NS, [gioi tinh] = @P, [so dien thoai] = @soDt, [dia chi] = @DC, [hinh anh] = @HA WHERE [ma nhan vien]=@maNhanVien", myDB.getConnection);
            cmd.Parameters.Add("@maNhanVien", SqlDbType.Int).Value = maNV;
            cmd.Parameters.Add("@HT", SqlDbType.VarChar).Value = hoten;
            cmd.Parameters.Add("@NS", SqlDbType.DateTime).Value = ngSinh;
            cmd.Parameters.Add("@P", SqlDbType.VarChar).Value = phai;
            cmd.Parameters.Add("@soDT", SqlDbType.VarChar).Value = sdt;
            cmd.Parameters.Add("@DC", SqlDbType.VarChar).Value = diachi;
            cmd.Parameters.Add("@HA", SqlDbType.Image).Value = hinhanh.ToArray();
            myDB.openConnection();
            if ((command.ExecuteNonQuery() == 1) && (cmd.ExecuteNonQuery() == 1))
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

        public bool XoaNV(int maNV)
        {
            SqlCommand command = new SqlCommand("DELETE  FROM TaiKhoan WHERE TaiKhoan.[ma nhan vien] = @MNV", myDB.getConnection);
            command.Parameters.Add("@MNV", SqlDbType.Int).Value = maNV;
            SqlCommand cmd = new SqlCommand("DELETE  FROM NhanVien WHERE NhanVien.[ma nhan vien] = @MNV", myDB.getConnection);
            cmd.Parameters.Add("@MNV", SqlDbType.Int).Value = maNV;
            SqlCommand Scmd = new SqlCommand("DELETE  FROM PhanCong WHERE PhanCong.[ma nhan vien] = @MNV", myDB.getConnection);
            Scmd.Parameters.Add("@MNV", SqlDbType.Int).Value = maNV;
            myDB.openConnection();
            if ((command.ExecuteNonQuery() == 1) && (cmd.ExecuteNonQuery() == 1) && (Scmd.ExecuteNonQuery() == 1))
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

        //Phân công công việc
        public void PhanCong(int maNV)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM PhanCong", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if (table.Rows.Count < 5)
            {
                if (table.Rows.Count == 0)
                {
                    PhanCa(maNV, 1, 1, 1);
                }
                if (table.Rows.Count == 1)
                {
                    CapNhatPC(int.Parse(table.Rows[0][0].ToString()), 0, 0, 0);
                    PhanCa(maNV, 1, 1, 1);
                }
                if (table.Rows.Count == 2)
                {
                    PhanCa(maNV, 1, 1, 1);
                }
                if (table.Rows.Count == 3)
                {
                    CapNhatPC(int.Parse(table.Rows[2][0].ToString()), 1, 1, 0);
                    PhanCa(maNV, 0, 1, 1);
                }
                if (table.Rows.Count == 4)
                {
                    //CapNhatPC(int.Parse(table.Rows[0][0].ToString()), 1, 1, 0);
                    //CapNhatPC(int.Parse(table.Rows[1][0].ToString()), 0, 1, 1);
                    PhanCa(maNV, 1, 0, 1);
                }
            }
            else
            {
                if (table.Rows.Count % 3 == 0)
                {
                    PhanCa(maNV, int.Parse(table.Rows[3][1].ToString()), int.Parse(table.Rows[3][2].ToString()), int.Parse(table.Rows[3][3].ToString()));
                }
                if (table.Rows.Count % 3 == 1)
                {
                    PhanCa(maNV, int.Parse(table.Rows[4][1].ToString()), int.Parse(table.Rows[4][2].ToString()), int.Parse(table.Rows[4][3].ToString()));
                }
                if (table.Rows.Count % 3 == 2)
                {
                    PhanCa(maNV, int.Parse(table.Rows[2][1].ToString()), int.Parse(table.Rows[2][2].ToString()), int.Parse(table.Rows[2][3].ToString()));
                }
            }
        }

        //cập nhật lại ca 
        public void CapNhatPC(int maNV, int x, int y, int z)
        {
            SqlCommand command = new SqlCommand("UPDATE PhanCong SET [ca1] = @C1, [ca2] = @C2, [ca3] = @C3 WHERE [ma nhan vien]=@MNV", myDB.getConnection);
            command.Parameters.Add("@MNV", SqlDbType.Int).Value = maNV;
            command.Parameters.Add("@C1", SqlDbType.VarChar).Value = x;
            command.Parameters.Add("@C2", SqlDbType.VarChar).Value = y;
            command.Parameters.Add("@C3", SqlDbType.NVarChar).Value = z;
            myDB.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDB.closeConnection();
            }
            else
            {
                myDB.closeConnection();
            }
        }

        //phân ca làm vào sql
        public void PhanCa(int maNV, int x, int y, int z)
        {
            SqlCommand command = new SqlCommand("INSERT INTO PhanCong([ma nhan vien],[ca1],[ca2],[ca3]) VALUES (@MNV,@C1,@C2,@C3)", myDB.getConnection);
            command.Parameters.Add("@MNV", SqlDbType.Int).Value = maNV;
            command.Parameters.Add("@C1", SqlDbType.Int).Value = x;
            command.Parameters.Add("@C2", SqlDbType.Int).Value = y;
            command.Parameters.Add("@C3", SqlDbType.Int).Value = z;
            myDB.openConnection();
            //ExecuteNonQuery dùng để thực thi các câu truy vấn như INSERT, DELETE, UPDATE. 
            //nó trả về kiểu int chính là số dòng trong table của database bị thay đổi bởi 3 lệnh trên.
            //nếu #1 thì bị lỗi.
            if ((command.ExecuteNonQuery() == 1))
            {
                myDB.closeConnection();
            }
            else
            {
                myDB.closeConnection();
            }
        }

        //Xem lịch phân công những ngày tiếp theo
        public void TheoNgaySau()
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM PhanCong", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if (table.Rows.Count > 3)
            {
                table.Rows.Add(1000, int.Parse(table.Rows[2][1].ToString()), int.Parse(table.Rows[2][2].ToString()), int.Parse(table.Rows[2][3].ToString()));
                table.Rows.Add(1000, int.Parse(table.Rows[0][1].ToString()), int.Parse(table.Rows[0][2].ToString()), int.Parse(table.Rows[0][3].ToString()));
                int n = table.Rows.Count - 1;
                CapNhatPC(int.Parse(table.Rows[0][0].ToString()), int.Parse(table.Rows[1][1].ToString()), int.Parse(table.Rows[1][2].ToString()), int.Parse(table.Rows[1][3].ToString()));
                CapNhatPC(int.Parse(table.Rows[1][0].ToString()), int.Parse(table.Rows[n][1].ToString()), int.Parse(table.Rows[n][2].ToString()), int.Parse(table.Rows[n][3].ToString()));
                for (int j = 2; j < n - 1; j++)
                {
                    CapNhatPC(int.Parse(table.Rows[j][0].ToString()), int.Parse(table.Rows[j + 1][1].ToString()), int.Parse(table.Rows[j + 1][2].ToString()), int.Parse(table.Rows[j + 1][3].ToString()));
                }
            }
            else
            {
                table.Rows.Add(1000, int.Parse(table.Rows[0][1].ToString()), int.Parse(table.Rows[0][2].ToString()), int.Parse(table.Rows[0][3].ToString()));
                int n = table.Rows.Count - 1;
                CapNhatPC(int.Parse(table.Rows[0][0].ToString()), int.Parse(table.Rows[1][1].ToString()), int.Parse(table.Rows[1][2].ToString()), int.Parse(table.Rows[1][3].ToString()));
                CapNhatPC(int.Parse(table.Rows[1][0].ToString()), int.Parse(table.Rows[n][1].ToString()), int.Parse(table.Rows[n][2].ToString()), int.Parse(table.Rows[n][3].ToString()));
            }
        }

        //xem lịch phân công nhũng ngày trước ngày hiện tại
        public void TheoNgaytruoc()
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM PhanCong", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if (table.Rows.Count > 3)
            {
                table.Rows.Add(1000, int.Parse(table.Rows[table.Rows.Count - 1][1].ToString()), int.Parse(table.Rows[table.Rows.Count - 1][2].ToString()), int.Parse(table.Rows[table.Rows.Count - 1][3].ToString()));
                table.Rows.Add(1000, int.Parse(table.Rows[1][1].ToString()), int.Parse(table.Rows[1][2].ToString()), int.Parse(table.Rows[1][3].ToString()));
                int n = table.Rows.Count - 1;
                CapNhatPC(int.Parse(table.Rows[1][0].ToString()), int.Parse(table.Rows[0][1].ToString()), int.Parse(table.Rows[0][2].ToString()), int.Parse(table.Rows[0][3].ToString()));
                CapNhatPC(int.Parse(table.Rows[0][0].ToString()), int.Parse(table.Rows[n][1].ToString()), int.Parse(table.Rows[n][2].ToString()), int.Parse(table.Rows[n][3].ToString()));
                for (int j = n - 2; j > 2; j--)
                {
                    CapNhatPC(int.Parse(table.Rows[j][0].ToString()), int.Parse(table.Rows[j - 1][1].ToString()), int.Parse(table.Rows[j - 1][2].ToString()), int.Parse(table.Rows[j - 1][3].ToString()));
                }
                CapNhatPC(int.Parse(table.Rows[2][0].ToString()), int.Parse(table.Rows[n - 1][1].ToString()), int.Parse(table.Rows[n - 1][2].ToString()), int.Parse(table.Rows[n - 1][3].ToString()));
            }
            else
            {
                table.Rows.Add(1000, int.Parse(table.Rows[1][1].ToString()), int.Parse(table.Rows[1][2].ToString()), int.Parse(table.Rows[1][3].ToString()));
                int n = table.Rows.Count - 1;
                CapNhatPC(int.Parse(table.Rows[1][0].ToString()), int.Parse(table.Rows[0][1].ToString()), int.Parse(table.Rows[0][2].ToString()), int.Parse(table.Rows[0][3].ToString()));
                CapNhatPC(int.Parse(table.Rows[0][0].ToString()), int.Parse(table.Rows[n][1].ToString()), int.Parse(table.Rows[n][2].ToString()), int.Parse(table.Rows[n][3].ToString()));
            }
        }
        //Đếm nhân viên
        public int demNV()
        {
            myDB.openConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM NhanVien", myDB.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table.Rows.Count;
        }
        //Kiểm tra ngày
        public bool KiemTraNgay(string momment)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM ChamCong Where [ngay]=@time", myDB.getConnection);
            command.Parameters.Add("@time", SqlDbType.NVarChar).Value = momment;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if(table.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool insertChamCong(int id,string momment)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = myDB.getConnection;
            myDB.openConnection();
            command.CommandText = "INSERT INTO ChamCong([ma nhan vien],[ngay])" + "VALUES(@ID,@time)";
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@time", SqlDbType.NVarChar).Value = momment;
            if ((command.ExecuteNonQuery() == 1))
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
        //Tạo database Chấm công theo ngày
        public bool setTable(int id, string momment)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = myDB.getConnection;
            myDB.openConnection();
            command.CommandText = "INSERT INTO ChamCong([ma nhan vien],[ngay])" + "VALUES(@ID,@time)";
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@time", SqlDbType.NVarChar).Value = momment;
            if ((command.ExecuteNonQuery() == 1))
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
        //Checkin
        public bool checkin(int id, string ca, string in_time, string day)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = myDB.getConnection;
            myDB.openConnection();
            switch (ca)
            {
                case "1":
                    command.CommandText = "UPDATE ChamCong SET [ca1-in]=@_in WHERE [ma nhan vien]=@ID AND ngay=@time";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@_in", SqlDbType.VarChar).Value = in_time;
                    command.Parameters.Add("@time", SqlDbType.NVarChar).Value = day;
                    break;
                case "2":
                    command.CommandText = "UPDATE ChamCong SET [ca2-in]=@_in WHERE [ma nhan vien]=@ID AND ngay=@time";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@_in", SqlDbType.VarChar).Value = in_time;
                    command.Parameters.Add("@time", SqlDbType.NVarChar).Value = day;

                    break;
                case "3":
                    command.CommandText = "UPDATE ChamCong SET [ca3-in]=@_in WHERE [ma nhan vien]=@ID AND ngay=@time";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@_in", SqlDbType.VarChar).Value = in_time;
                    command.Parameters.Add("@time", SqlDbType.NVarChar).Value = day;

                    break;
            }
            if ((command.ExecuteNonQuery() == 1))
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
        //Check-out
        public bool checkout(int id, string ca, string in_time, string day)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = myDB.getConnection;
            myDB.openConnection();
            switch (ca.Trim())
            {
                case "1":
                    command.CommandText = "UPDATE ChamCong SET [ca1-out]=@_in WHERE [ma nhan vien]=@ID AND ngay=@time";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@_in", SqlDbType.VarChar).Value = in_time;
                    command.Parameters.Add("@time", SqlDbType.NVarChar).Value = day;
                    break;
                case "2":
                    command.CommandText = "UPDATE ChamCong SET [ca2-out]=@_in WHERE [ma nhan vien]=@ID AND ngay=@time";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@_in", SqlDbType.VarChar).Value = in_time;
                    command.Parameters.Add("@time", SqlDbType.NVarChar).Value = day;

                    break;
                case "3":
                    command.CommandText = "UPDATE ChamCong SET [ca3-out]=@_in WHERE [ma nhan vien]=@ID AND ngay=@time";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@_in", SqlDbType.VarChar).Value = in_time;
                    command.Parameters.Add("@time", SqlDbType.NVarChar).Value = day;

                    break;
            }
            if ((command.ExecuteNonQuery() == 1))
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
        //Auto check-out
        public bool autoCheckout(int id, string ca, string in_time, string day)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = myDB.getConnection;
            myDB.openConnection();
            switch (ca)
            {
                case "1":
                    command.CommandText = "UPDATE ChamCong SET [ca1-out]=@_in WHERE [ma nhan vien]=@ID AND ngay=@time AND [ca1-in] is not null AND [ca1-out] is null";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@_in", SqlDbType.VarChar).Value = in_time;
                    command.Parameters.Add("@time", SqlDbType.NVarChar).Value = day;

                    break;
                case "2":
                    command.CommandText = "UPDATE ChamCong SET [ca2-out]=@_in WHERE [ma nhan vien]=@ID AND ngay=@time AND [ca2-in] is not null AND [ca2-out] is null";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@_in", SqlDbType.VarChar).Value = in_time;
                    command.Parameters.Add("@time", SqlDbType.NVarChar).Value = day;

                    break;
                case "3":
                    command.CommandText = "UPDATE ChamCong SET [ca3-out]=@_in WHERE [ma nhan vien]=@ID AND ngay=@time AND [ca3-in] is not null AND [ca3-out] is null";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@_in", SqlDbType.VarChar).Value = in_time;
                    command.Parameters.Add("@time", SqlDbType.NVarChar).Value = day;

                    break;
            }
            if ((command.ExecuteNonQuery() == 1))
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
        //Show replace
        public DataTable replaceTable(string momment)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = myDB.getConnection;
            command.CommandText = "SELECT ChamCong.[ma nhan vien] as 'ID',[ho ten] as 'Họ tên', ngay as 'Date'," +
                "[nguoi lam thay] as 'ID người thay',[ten nguoi lam thay] as 'Tên người thay'" +
                "FROM ChamCong,NhanVien WHERE ChamCong.[ma nhan vien]=NhanVien.[ma nhan vien] AND [ngay]=@time";
            command.Parameters.Add("@time", SqlDbType.NVarChar).Value = momment;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //Update người làm thay ca
        public bool updateNguoiLamTay(int id1,int id2,string name,string momment)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = myDB.getConnection;
            command.CommandText = "UPDATE ChamCong Set [nguoi lam thay]=@id1,[ten nguoi lam thay]=@name WHERE [ma nhan vien]=@id2 and @id1!=@id2 and [ngay]=@time ";
            command.Parameters.Add("@time", SqlDbType.NVarChar).Value = momment;
            command.Parameters.Add("@id1", SqlDbType.Int).Value = id1;
            command.Parameters.Add("@id2", SqlDbType.Int).Value = id2;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value =name ;

            myDB.openConnection();
            if(command.ExecuteNonQuery()==1)
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
        //Lấy bảng Chấm Công
        public DataTable getChamCong(string momment)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM ChamCong WHERE [ngay]=@time";
            command.Connection = myDB.getConnection;
            command.Parameters.Add("@time", SqlDbType.NVarChar).Value = momment;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            return table;
        }
        //Thêm vào cột Tổng công
        public bool insertTongCong(int id,double total,string momment)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE ChamCong SET [tong gio lam]=@total WHERE [ma nhan vien]=@id AND [ngay]=@time";
            command.Connection = myDB.getConnection;
            command.Parameters.Add("@time", SqlDbType.NVarChar).Value = momment;

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@total", SqlDbType.Float).Value = total;
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
        public bool themTK(int maNV, string tenDN, string matKhau, string chucvu)
        {
            SqlCommand command = new SqlCommand("INSERT INTO TaiKhoan([ma nhan vien],[ten dang nhap],[mat khau],[chuc vu]) VALUES (@MNV,@TDN,@MK,@CV)", myDB.getConnection);
            command.Parameters.Add("@MNV", SqlDbType.Int).Value = maNV;
            command.Parameters.Add("@TDN", SqlDbType.VarChar).Value = tenDN;
            command.Parameters.Add("@Mk", SqlDbType.VarChar).Value = matKhau;
            command.Parameters.Add("@CV", SqlDbType.NVarChar).Value = chucvu;
            SqlCommand cmd = new SqlCommand("INSERT INTO NhanVien ([ma nhan vien]) VALUES (@maNhanVien)", myDB.getConnection);
            cmd.Parameters.Add("@maNhanVien", SqlDbType.Int).Value = maNV;
            myDB.openConnection();
            if ((command.ExecuteNonQuery() == 1) && (cmd.ExecuteNonQuery() == 1))
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

        public bool checkNewUser(int mnv)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM NhanVien Where [ma nhan vien]=@mnv", myDB.getConnection);
            command.Parameters.Add("@mnv", SqlDbType.Int).Value = mnv;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            for(int i = 1; i < table.Columns.Count - 2;i++)
            {
                if(table.Rows[0][i].ToString() != "")
                {
                    return false;
                }
            }
            return true;
        }
    }
}
