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
using System.IO;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;



namespace QuanLyNhaHang
{
    public partial class QuanLy : Form
    {
        #region Variable
        int hour, minute, second;
        Nhanvien nhanvien = new Nhanvien();
        string day = DateTime.Now.ToString("dd-MM-yyyy");
        DataTable staff_table = new Nhanvien().layDSNV();
        int n = new Nhanvien().demNV();
        TienCong tc = new TienCong();
        bool isClick = false;

        #endregion
        #region Load
        public QuanLy()
        {
            InitializeComponent();
            //lấy kích thước của màn hình
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;

            //cho form hiển thị theo kích thước của màn hình
            this.Width = widthScreen;
            this.Height = heightScreen;

            //lay ty le bang cach lay kich thuoc man hinh chia cho kich thuoc thiet ke
            //1088 là chiều rộng, 602 là chiều cao Form khi thiết kế, xem trong Properties của Form
            float WidthPerscpective = (float)Width / 1088;
            float HeightPerscpective = (float)Height / 602;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);

        }

        private void ResizeAllControls(Control recussiveControl, float WidthPerscpective, float HeightPerscpective)
        {

            foreach (Control control in recussiveControl.Controls)
            {

                //gọi đệ quy nếu như 1 control nào có chứa các control khác nữa

                if (control.Controls.Count != 0)

                    ResizeAllControls(control, WidthPerscpective, HeightPerscpective);

                //canh lại toạ độ x, y, chiều rộng, cao cho các control trên form

                control.Left = (int)(control.Left * WidthPerscpective);

                control.Top = (int)(control.Top * HeightPerscpective);

                control.Width = (int)(control.Width * WidthPerscpective);

                control.Height = (int)(control.Height * HeightPerscpective);

            }
        }

        int flag = 0;
        Nhanvien nv = new Nhanvien();
        My_DB myDB = new My_DB();
        private void label_X_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            dateTimePicker_ngSinh.Format = DateTimePickerFormat.Custom;
            dateTimePicker_phanCong.Format = DateTimePickerFormat.Custom;
            dateTimePicker_ngSinh.CustomFormat = "dd-MM-yyyy";
            dateTimePicker_phanCong.CustomFormat = "dd-MM-yyyy";
            comboBox_chucvu.Items.Add("Quan ly");
            comboBox_chucvu.Items.Add("Nhan vien");
            dataGridView_DSNV.ReadOnly = true;
            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            dateTimePicker_phanCong.CustomFormat = "dd-MM-yyyy";
            dataGridView_DSNV.RowTemplate.Height = 80;
            dataGridView_DSNV.DataSource = nv.layDSNV();
            picol = (DataGridViewImageColumn)dataGridView_DSNV.Columns[9];
            picol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView_DSNV.AllowUserToAddRows = false;
            DuaDSPCLenDataGridView();
            ReloadCombo_LamThay();
            ReadloadCombo_BiThay();
            nhanvien_timer.Start();


        }
        //Lấy danh sach nhan len datagridview
        public void DuaDSNVLenDataGridView()
        {
            dataGridView_DSNV.ReadOnly = true;
            dataGridView_DSNV.RowTemplate.Height = 80;
            dataGridView_DSNV.DataSource = nv.layDSNV();
            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            picol = (DataGridViewImageColumn)dataGridView_DSNV.Columns[9];
            picol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView_DSNV.AllowUserToAddRows = false;
           
        }

        //Dua danh sach phan cong nhan vien data grid view
        public void DuaDSPCLenDataGridView()
        {
            dataGridView_phanCong.ReadOnly = true;
            dataGridView_phanCong.RowTemplate.Height = 30;
            dataGridView_phanCong.DataSource = nv.layDSPC();
            dataGridView_phanCong.AllowUserToAddRows = false;
            dateTimePicker_phanCong.Value = DateTime.Today;
        }
        #endregion
        #region Staff
        //Thêm và tự phân công nhân viên
        private void button_themNV_Click(object sender, EventArgs e)
        {           
            int maNV = Convert.ToInt32(textBox_maNV.Text);
            string tenDN = textBox_tenDN.Text;
            string matKhau = textBox_MK.Text;
            string hoten = textBox_hoTen.Text;
            DateTime ngSinh = dateTimePicker_ngSinh.Value;
            string soDT = textBox_soDt.Text;
            string diachi = textBox_diaChi.Text;
            string chucvu = comboBox_chucvu.Text;
            string phai = "nu";
            try
            {
                if (radioButton_nam.Checked)
                {
                    phai = "nam";
                }
                MemoryStream hinhanh = new MemoryStream();
                int born_year = dateTimePicker_ngSinh.Value.Year;
                int this_year = DateTime.Now.Year;
                if (((this_year - born_year) < 18) || ((this_year - born_year) > 40))
                {
                    MessageBox.Show("Tuoi phai tu 18 den 40!", "Ngay sinh khong hop le", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (verify())
                {
                    pictureBox_HA.Image.Save(hinhanh, pictureBox_HA.Image.RawFormat);
                    if (nv.themNV(maNV, tenDN, matKhau, hoten, ngSinh, phai, soDT, chucvu, diachi, hinhanh))
                    {
                        nv.PhanCong(maNV);
                        nv.insertChamCong(maNV, day);
                        MessageBox.Show("Them nhan vien thanh cong", "Them nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Loi!", "Them nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Thong tin trong", "Them nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                DuaDSNVLenDataGridView();
                DuaDSPCLenDataGridView();
                ReloadCombo_LamThay();
                ReadloadCombo_BiThay();
            }
            catch
            {

            }
        }

        //Sữa thông tin nhân viên
        private void button_sua_Click(object sender, EventArgs e)
        {
            int maNV;
            string tenDN = textBox_tenDN.Text;
            string matKhau = textBox_MK.Text;
            string hoten = textBox_hoTen.Text;
            DateTime ngSinh = dateTimePicker_ngSinh.Value;
            string soDT = textBox_soDt.Text;
            string diachi = textBox_diaChi.Text;
            string chucvu = comboBox_chucvu.Text;
            string phai = "nu";
            if (radioButton_nam.Checked)
            {
                phai = "nam";
            }

            MemoryStream hinhanh = new MemoryStream();
            int born_year = dateTimePicker_ngSinh.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year < 18) || (this_year - born_year > 50))
            {
                MessageBox.Show("Tuoi phai tu 18 den 50!", "Ngay sinh khong hop le", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (verify())
            {
                try
                {
                    maNV = Convert.ToInt32(textBox_maNV.Text);
                    pictureBox_HA.Image.Save(hinhanh, pictureBox_HA.Image.RawFormat);
                    if (nv.SuaNV(maNV, tenDN, matKhau, hoten, ngSinh, phai, soDT, chucvu, diachi, hinhanh))
                    {
                        MessageBox.Show("Sua thong tin thanh cong", "Sua thong tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Loi!", "Sua thong tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sua thong tin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Thong tin rong", "Sua thong tin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            DuaDSNVLenDataGridView();
            DuaDSPCLenDataGridView();
            ReloadCombo_LamThay();
            ReadloadCombo_BiThay();
        }

        //Xóa nhân viên
        private void button_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maNV = Convert.ToInt32(textBox_maNV.Text);
                if (MessageBox.Show("Ban chac chan muon xoa nhan vien nay?", "Xoa nhan vien", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (nv.XoaNV(maNV))
                    {
                        MessageBox.Show("Xoa thanh cong", "Xoa nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        textBox_maNV.Text = "";
                        textBox_tenDN.Text = "";
                        textBox_MK.Text = "";
                        comboBox_chucvu.Text = "";
                        textBox_hoTen.Text = "";
                        dateTimePicker_ngSinh.Value = DateTime.Now;
                        textBox_diaChi.Text = "";
                        textBox_soDt.Text = "";
                        pictureBox_HA.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Xoa nhan vien khong thanh cong", "Xoa nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui long chon nhan vien can xoa", "Xoa nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DuaDSNVLenDataGridView();
            DuaDSPCLenDataGridView();
            ReloadCombo_LamThay();
            ReadloadCombo_BiThay();
        }

        public bool verify()
        {
            if ((textBox_hoTen.Text == "")
                || (textBox_tenDN.Text == "")
                || (textBox_MK.Text == "")
                || (textBox_diaChi.Text == "")
                || (textBox_soDt.Text == "")
                || (pictureBox_HA.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void dataGridView_DSNV_Click(object sender, EventArgs e)
        {
            if (nhanvien.checkNewUser(int.Parse(dataGridView_DSNV.CurrentRow.Cells[0].Value.ToString().Trim())))
            {
                textBox_maNV.Text = dataGridView_DSNV.CurrentRow.Cells[0].Value.ToString().Trim();
                textBox_tenDN.Text = dataGridView_DSNV.CurrentRow.Cells[1].Value.ToString().Trim();
                textBox_MK.Text = dataGridView_DSNV.CurrentRow.Cells[2].Value.ToString().Trim();
                comboBox_chucvu.Text = dataGridView_DSNV.CurrentRow.Cells[3].Value.ToString().Trim();
                textBox_hoTen.Text = "";
                dateTimePicker_ngSinh.Value = DateTime.Now;
                radioButton_nu.Checked = false;
                radioButton_nam.Checked = false;
                textBox_soDt.Text = "";
                textBox_diaChi.Text = "";
                pictureBox_HA.Image = null;
            }
            else
            {
                textBox_maNV.Text = dataGridView_DSNV.CurrentRow.Cells[0].Value.ToString().Trim();
                textBox_tenDN.Text = dataGridView_DSNV.CurrentRow.Cells[1].Value.ToString().Trim();
                textBox_MK.Text = dataGridView_DSNV.CurrentRow.Cells[2].Value.ToString().Trim();
                comboBox_chucvu.Text = dataGridView_DSNV.CurrentRow.Cells[3].Value.ToString().Trim();
                textBox_hoTen.Text = dataGridView_DSNV.CurrentRow.Cells[4].Value.ToString().Trim();
                dateTimePicker_ngSinh.Value = (DateTime)dataGridView_DSNV.CurrentRow.Cells[5].Value;
                if ((dataGridView_DSNV.CurrentRow.Cells[6].Value.ToString().Trim() == "nu"))
                {
                    radioButton_nu.Checked = true;
                }
                else
                {
                    radioButton_nam.Checked = true;
                }
                try
                {
                    textBox_soDt.Text = dataGridView_DSNV.CurrentRow.Cells[7].Value.ToString().Trim();
                    textBox_diaChi.Text = dataGridView_DSNV.CurrentRow.Cells[8].Value.ToString().Trim();
                    byte[] pic;
                    pic = (byte[])dataGridView_DSNV.CurrentRow.Cells[9].Value;
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBox_HA.Image = Image.FromStream(picture);
                }
                catch
                {

                }
            }
        }

        //Tìm nhân viên
        private void button_tim_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT TaiKhoan.[ma nhan vien],[ten dang nhap],[mat khau],[chuc vu],[ho ten],[ngay sinh],[gioi tinh],[so dien thoai],[dia chi],[hinh anh]" +
                " FROM NhanVien,TaiKhoan WHERE NhanVien.[ma nhan vien] = TaiKhoan.[ma nhan vien] AND CAST(NhanVien.[ma nhan vien] AS varchar)+ [ho ten] LIKE'%" + textBox_traCuu.Text + "%'", myDB.getConnection);
            dataGridView_DSNV.ReadOnly = true;
            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            dataGridView_DSNV.RowTemplate.Height = 80;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_DSNV.DataSource = table;
            picol = (DataGridViewImageColumn)dataGridView_DSNV.Columns[9];
            picol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView_DSNV.AllowUserToAddRows = false;
        }

        //Up ảnh
        private void button_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox_HA.Image = Image.FromFile(opf.FileName);
            }
        }

        //Danh sách nhân viên
        private void button_DSNV_Click(object sender, EventArgs e)
        {
            DuaDSNVLenDataGridView();
        }
        #endregion
        #region PhanCong
        //Xem phân công theo ngày
        private void dateTimePicker_phanCong_ValueChanged(object sender, EventArgs e)
        {
            DataTable table = nv.layDSPC();
            if(flag == 0)
            {
                int Day_after = dateTimePicker_phanCong.Value.Day;
                int Day_now = DateTime.Now.Day;
                int Day = Day_after - Day_now;
                if (Day > 0)
                {
                    for (int i = 0; i < Day; i++)
                    {
                        nv.TheoNgaySau();
                    }
                }
                else
                {
                    for (int i = 0; i < Math.Abs(Day); i++)
                    {
                        nv.TheoNgaytruoc();
                    }
                }
                dataGridView_phanCong.ReadOnly = true;
                dataGridView_phanCong.RowTemplate.Height = 30;
                dataGridView_phanCong.DataSource = nv.layDSPC();
                dataGridView_phanCong.AllowUserToAddRows = false;
                flag = 1;
            }
            if(flag == 1)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    nv.CapNhatPC(int.Parse(table.Rows[i][0].ToString()), int.Parse(table.Rows[i][2].ToString()), int.Parse(table.Rows[i][3].ToString()), int.Parse(table.Rows[i][4].ToString()));
                }
                flag = 0;
            }
        }
        public void TuDongCapNhat()
        {
            int khoang = Math.Abs(DateTime.Now.Day - 0);
            SqlCommand command = new SqlCommand("SELECT [ma nhan vien] FROM PhanCong", myDB.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 1)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM PhanCong", myDB.getConnection);
                myDB.openConnection();
                cmd.ExecuteNonQuery();
                myDB.closeConnection();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    nv.PhanCong(int.Parse(table.Rows[i][0].ToString()));
                }
                for (int j = 0; j < khoang; j++)
                {
                    nv.TheoNgaySau();
                }
            }
        }
        #endregion
        #region Time
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
            else if (hour == 22 && minute==5 && second==0 && isClick==false)
            {
                isClick = true;
                Salary_btn_Click(null, null);
            }
           
            //Tự động cập nhật khi tan ca
            string ca = shift_label.Text.Trim();
            if (hour == 11 && minute == 0 && second == 0)
            {
                for (int i = 0; i < n; i++)
                    nhanvien.autoCheckout(Convert.ToInt32(staff_table.Rows[i][0].ToString().Trim()), ca, "11:00", day);
            }
            else if (hour == 14 && minute == 00 && second == 0)
            {
                for (int i = 0; i < n; i++)
                    nhanvien.autoCheckout(Convert.ToInt32(staff_table.Rows[i][0].ToString().Trim()), ca, "14:00", day);
            }
            else if (hour == 22 && minute == 0 && second == 0)
            {
                for (int i = 0; i < n; i++)
                    nhanvien.autoCheckout(Convert.ToInt32(staff_table.Rows[i][0].ToString().Trim()), ca, "22:00", day);
            }

          
        }

        private void checkin_btn_Click(object sender, EventArgs e)
        {
            //Check-in dựa vào ca, ngày làm việc
            int id = Convert.ToInt32(idvalue_label.Text.Trim());
            string ca = shift_label.Text.Trim();
            string in_time = hour_label.Text.Trim() + ":" + minute_label.Text.Trim();
            try
            {
                if(nhanvien.checkin(id, ca, in_time, day))
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

        private void checkout_btn_Click(object sender, EventArgs e)
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

        private void set_BTN_Click(object sender, EventArgs e)
        {
            DataTable staff_table2 = new Nhanvien().layNV(new SqlCommand("SELECT * FROM NhanVien"));
            int n = staff_table2.Rows.Count;
            try
            {
                if(!nv.KiemTraNgay(day))
                {
                    for (int i = 0; i < n; i++)
                    {
                        nhanvien.setTable(Convert.ToInt32(staff_table2.Rows[i][0].ToString()), day);
                    }
                    MessageBox.Show("Setting succesful!", "Setting ChamCong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Setting failed!", "Setting ChamCong", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch
            {
                MessageBox.Show("Error !", "Setting ChamCong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dataGridView_DSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //Xem phân công ngày hiện tại
        private void button_lichHienTai_Click(object sender, EventArgs e)
        {
            DuaDSPCLenDataGridView();
        }

        private void dataGridView_phanCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void replace_Click(object sender, EventArgs e)
        {
            dataGridView_phanCong.DataSource = nv.replaceTable(day);

        }

        
        #endregion

        #region LamThay
        public void ReloadCombo_LamThay()
        {
            lamthay_combo.DataSource = nv.layDSNV();
            lamthay_combo.DisplayMember = "Họ tên";
            lamthay_combo.ValueMember = "ID";
            lamthay_combo.SelectedItem = null;
        }

        private void Salary_btn_Click(object sender, EventArgs e)
        {
            //Tính công
            tc.removeTC();
            DataTable table = nv.getChamCong(day);
            foreach(DataRow row in table.Rows)
            {
                int id = (int)row["ma nhan vien"];
                tc.InsertID(id);
            }

            foreach(DataRow row in table.Rows)
            {
                TimeSpan span = new TimeSpan();
                int id = (int)row["ma nhan vien"];
                if (row["ca1-out"].ToString()!=""&& row["ca1-in"].ToString() != "")
                {
                    span=Conve(row["ca1-out"].ToString())- Conve(row["ca1-in"].ToString());
                }
                if(row["ca2-out"].ToString()!="" && row["ca2-in"].ToString() != "")
                {
                    span = Conve(row["ca2-out"].ToString()) - Conve(row["ca2-in"].ToString())+span;
                }
                if (row["ca3-out"].ToString() != "" && row["ca3-in"].ToString() != "")
                {
                    span = Conve(row["ca3-out"].ToString()) - Conve(row["ca3-in"].ToString()) + span;
                }
                double total= Math.Round(Convert.ToDouble(span.TotalHours), 2);
                try
                {
                    if (nv.insertTongCong(id, total,day))
                    {
                        if(total<8 && total>0 )
                        {
                            double realtime = total - (total % (int)total);
                            int salary = (int)realtime * 50000;
                            int pen = (8 - (int)realtime) * 100000;
                            tc.updateTienCong(id, salary, pen);
                            string test = row["ten nguoi lam thay"].ToString().Trim();
                            if (test != "")
                                tc.updateTienThuongToID((int)row["nguoi lam thay"], pen);
                            
                        }
                        continue;
                    }
                    else
                    {
                        MessageBox.Show("Error", "Insert Working Hours", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
                catch
                {

                }
                



            }
            DataTable tinhluongTable = tc.calculate();
            foreach(DataRow row in tinhluongTable.Rows)
            {
                int id = (int)row["ma nhan vien"];
                int sum = 0;
                if (row["tien cong"].ToString() != "")
                    sum += (int)row["tien cong"];
                if (row["tien phat"].ToString() != "")
                    sum -= (int)row["tien phat"];
                if (row["tien thuong"].ToString() != "")
                    sum += (int)row["tien thuong"];
                tc.updateRealSalary(id, sum);
            }
            this.Hide();
            using (TinhLuong fo = new TinhLuong())
                fo.ShowDialog();
            this.Show();

        }
        //Convert string to Datetime
        public DateTime Conve(string time)
        {
            return DateTime.Parse(time, System.Globalization.CultureInfo.CurrentCulture);
            
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "*.docx";
            save.Filter = "DOCX Files|*.docx";
            if (save.ShowDialog() == DialogResult.OK && dataGridView_DSNV.Rows.Count > 0)
            {

                Spire.Doc.Document doc;
                try
                {
                    doc = new Spire.Doc.Document(save.FileName);
                }
                catch (Exception)
                {
                    doc = new Spire.Doc.Document();
                }

                Spire.Doc.Table table;
                if (doc.Sections.Count < 1)
                {
                    Spire.Doc.Documents.Paragraph paragraph = doc.AddSection().AddParagraph();
                    Spire.Doc.Fields.TextRange header1 = paragraph.AppendText("Danh Sách Nhân Viên\n");

                    header1.CharacterFormat.FontName = "Times New Roman";
                    header1.CharacterFormat.FontSize = 20;
                    header1.CharacterFormat.Bold = true;
                    header1.CharacterFormat.FontSize = 20;
                    paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                    table = doc.Sections[0].AddTable(true);
                }
                else
                {
                    Spire.Doc.Documents.Paragraph paragraph = doc.Sections[0].AddParagraph();
                    Spire.Doc.Fields.TextRange header1 = paragraph.AppendText("Lương nhân viên\n");

                    header1.CharacterFormat.FontName = "Times New Roman";
                    header1.CharacterFormat.FontSize = 20;
                    header1.CharacterFormat.Bold = true;
                    header1.CharacterFormat.FontSize = 20;
                    paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                    table = doc.Sections[0].AddTable(true);
                }

                // Số dòng và số cột cho bảng
                table.ResetCells(dataGridView_DSNV.Rows.Count + 1, dataGridView_DSNV.Columns.Count);
                for (int i = 0; i < dataGridView_DSNV.Columns.Count; i++)
                {
                    doc.Sections[0].Tables[0].Rows[0].Cells[i].Width = 100;
                }

                //Đặt hàng đầu tiên là header
                Spire.Doc.TableRow FRow = table.Rows[0];
                FRow.IsHeader = true;
                FRow.Height = 23;

                for (int i = 0; i < dataGridView_DSNV.Columns.Count; i++)
                {
                    Spire.Doc.Documents.Paragraph p = FRow.Cells[i].AddParagraph();
                    // Định dạng văn bản trong bảng
                    FRow.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                    p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                    Spire.Doc.Fields.TextRange TR = p.AppendText(dataGridView_DSNV.Columns[i].HeaderText);
                    TR.CharacterFormat.FontName = "Times New Roman";
                    TR.CharacterFormat.FontSize = 13;
                    TR.CharacterFormat.Bold = true;
                }

                for (int i = 0; i < dataGridView_DSNV.Rows.Count; i++)
                {
                    Spire.Doc.TableRow DataRow = table.Rows[i + 1];
                    Spire.Doc.Documents.Paragraph paragraph;
                    for (int j = 0; j < dataGridView_DSNV.Columns.Count - 1; j++)
                    {
                        DataRow.Height = 50;
                        DataRow.Cells[j].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                        paragraph = DataRow.Cells[j].AddParagraph();
                        paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        Spire.Doc.Fields.TextRange text = paragraph.AppendText(dataGridView_DSNV.Rows[i].Cells[j].Value.ToString().Trim());
                        text.CharacterFormat.FontName = "Times New Roman";
                        text.CharacterFormat.FontSize = 13;
                    }

                    //Xử lí hình ảnh
                    paragraph = DataRow.Cells[9].AddParagraph();
                    byte[] pic;
                    pic = (byte[])dataGridView_DSNV.Rows[i].Cells[9].Value;
                    MemoryStream picture = new MemoryStream(pic);
                    System.Drawing.Image image = System.Drawing.Image.FromStream(picture);
                    DocPicture pc = paragraph.AppendPicture(image);
                    pc.Height = 50;
                    pc.Width = 50;

                    //Xử lí ngày sinh
                    DateTime date = Convert.ToDateTime(dataGridView_DSNV.Rows[i].Cells[5].Value);
                    DataRow.Cells[5].Paragraphs[0].Text = "";
                    DataRow.Cells[5].Paragraphs[0].AppendText(date.ToString("dd/MM/yyyy"));
                }
                doc.SaveToFile(save.FileName);
                MessageBox.Show("Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ReadloadCombo_BiThay() //Combo người được thay thế
        {
            bithay_combo.DataSource = nv.layDSNV();
            bithay_combo.DisplayMember = "Họ tên";
            bithay_combo.ValueMember = "ID";
            bithay_combo.SelectedItem = null;

        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            int id1 = (int)lamthay_combo.SelectedValue;
            int id2 = (int)bithay_combo.SelectedValue;
            string name = (string)lamthay_combo.GetItemText(lamthay_combo.SelectedItem);
            try
            {
                if (nv.updateNguoiLamTay(id1, id2,name,day) && id1!=id2)
                {
                    MessageBox.Show("Updated substitute successful", "Substitute", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    replace_Click(null, null);
                }
                else if(id1==id2)
                {
                    MessageBox.Show("Cannot update due to id1 and id2 have a same value  ", "Substitute", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Cannot update due to id1 and id2 have a same value ", "Substitute", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion
    }
}
