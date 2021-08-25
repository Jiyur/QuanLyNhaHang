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
    public partial class ChenhLech : Form
    {
        public ChenhLech()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        public DataTable Table
        {
            get { return table; }
            set { table = value; }
        }
        
        private void ChenhLech_Load(object sender, EventArgs e)
        {
            ChenhLech_dataGridView.ReadOnly = true;
            ChenhLech_dataGridView.DataSource = table;
            ChenhLech_dataGridView.AllowUserToAddRows = false;
        }
    }
}
