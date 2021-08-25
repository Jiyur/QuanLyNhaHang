using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void label_haveAccount_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            comboBox_chucvu.Items.Add("Quan ly");
            comboBox_chucvu.Items.Add("Nhan vien");
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            int mnv = int.Parse(textBox_maNV.Text);
            string tenDN = textBox_tenDN.Text;
            string mk = textBox_MK.Text;
            string cv = comboBox_chucvu.Text;
            if(new Nhanvien().themTK(mnv, tenDN, mk, cv))
            {
                MessageBox.Show("Create success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Create fail", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
