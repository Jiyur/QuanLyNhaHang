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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        My_DB myBD = new My_DB();
        private void Login_Load(object sender, EventArgs e)
        {
            SLmonBan Sl = new SLmonBan();
            int thang = Sl.layThang();
            if (thang != DateTime.Now.Month)
            {
                Sl.XoaBang();
                Sl.TaoBang();
                for (int i = 1; i < DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); i++)
                {
                    Sl.themCot("ngay " + i);
                }
                Sl.themCot("thang " + DateTime.Now.Month);
                DataTable table = new MonAn().LayTatCaMon();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Sl.Them(int.Parse(table.Rows[i][0].ToString()), table.Rows[i][1].ToString());
                }
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (user_txtbox.Text.Trim() == "" || pass_txtbox.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống mục nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (NhanVien_radio.Checked == true)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();
                    SqlCommand command = new SqlCommand("SELECT * FROM TaiKhoan WHERE [ten dang nhap] = @ten AND [mat khau] = @Pass AND [chuc vu] = @cv", myBD.getConnection);
                    command.Parameters.Add("@ten", SqlDbType.VarChar).Value = user_txtbox.Text;
                    command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = pass_txtbox.Text;
                    command.Parameters.Add("@cv", SqlDbType.VarChar).Value = NhanVien_radio.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        this.Hide();
                        Check_Form cF = new Check_Form();
                        cF.idvalue_label.Text = table.Rows[0][0].ToString().Trim();
                        cF.fnamevalue_label.Text = table.Rows[0][1].ToString().Trim();
                        cF.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại thông tin.", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (QuanLy_radio.Checked == true)
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        DataTable table = new DataTable();
                        SqlCommand command = new SqlCommand("SELECT * FROM TaiKhoan WHERE [ten dang nhap] = @ten AND [mat khau] = @Pass AND [chuc vu] = @cv", myBD.getConnection);
                        command.Parameters.Add("@ten", SqlDbType.VarChar).Value = user_txtbox.Text;
                        command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = pass_txtbox.Text;
                        command.Parameters.Add("@cv", SqlDbType.VarChar).Value = QuanLy_radio.Text;
                        adapter.SelectCommand = command;
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            
                            Main main = new Main();
                            this.Hide();
                            Globals.SetGlobalUserID(int.Parse(table.Rows[0][0].ToString()));
                            Globals.SetGlobalUserName(table.Rows[0][1].ToString().Trim());
                            main.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng kiểm tra lại thông tin.", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void register_label_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser();
            this.Hide();
            newUser.ShowDialog();
            this.Show();
        }
    }
}
