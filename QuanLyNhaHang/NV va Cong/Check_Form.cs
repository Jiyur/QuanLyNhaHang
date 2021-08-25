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
    public partial class Check_Form : Form
    {
        public Check_Form()
        {
            InitializeComponent();
        }
        int hour, minute, second;
        Nhanvien nhanvien = new Nhanvien();
        string day = DateTime.Now.ToString("dd-MM-yyyy");
        DataTable staff_table = new Nhanvien().layDSNV();
        
        int n = new Nhanvien().demNV();

        private void checkin_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void checkinn_btn_Click(object sender, EventArgs e)
        {
            //Check-in dựa vào ca, ngày làm việc
            int id = Convert.ToInt32(idvalue_label.Text.Trim());
            string ca = shift_label.Text.Trim();
            string in_time = hour_label.Text.Trim() + ":" + minute_label.Text.Trim();
            try
            {
                if (nhanvien.checkin(id, ca, in_time, day))
                {
                    MessageBox.Show("Checkin successfully !", "Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Checkin failed !!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {

            }
        }

        private void checkoutt_btn_Click(object sender, EventArgs e)
        {
            //Check-out dựa vào ca, ngày làm việc
            int id = Convert.ToInt32(idvalue_label.Text.Trim());
            string ca = shift_label.Text.Trim();
            string in_time = hour_label.Text.Trim() + ":" + minute_label.Text.Trim();
            try
            {
                if(nhanvien.checkout(id, ca, in_time, day))
                {
                    MessageBox.Show("Checkout successfully !", "Check", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Checkout failed !!!", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {

            }
        }

        private void Check_Form_Load(object sender, EventArgs e)
        {
            nhanvien_timer.Start();
        }

        private void nhanvien_timer_Tick(object sender, EventArgs e)
        {
            second = DateTime.Now.Second;
            minute = DateTime.Now.Minute;
            hour = DateTime.Now.Hour;
            hour_label.Text = DateTime.Now.ToString("HH");
            minute_label.Text = DateTime.Now.ToString("mm");
            second_label.Text = DateTime.Now.ToString("ss");
            //Hiển thị số ca theo thời gian
            if (hour >= 7 && hour < 11)
                shift_label.Text = "1";
            else if (hour >= 11 && hour < 14)
                shift_label.Text = "2";
            else if (hour >= 18 && hour < 22)
                shift_label.Text = "3";
            //Tự động cập nhật khi tan ca
            string ca = shift_label.Text.Trim();
            if (hour == 11 && minute == 0 && second == 0)
            {
                for (int i = 0; i < n; i++)
                    nhanvien.autoCheckout(Convert.ToInt32(staff_table.Rows[i][0].ToString()), ca, "11:00", day);
            }
            else if (hour == 14 && minute == 0 && second == 0)
            {
                for (int i = 0; i < n; i++)
                    nhanvien.autoCheckout(Convert.ToInt32(staff_table.Rows[i][0].ToString()), ca, "14:00", day);
            }
            else if (hour == 22 && minute == 0 && second == 0)
            {
                for (int i = 0; i < n; i++)
                    nhanvien.autoCheckout(Convert.ToInt32(staff_table.Rows[i][0].ToString()), ca, "22:00", day);
            }
        }
    }
}
