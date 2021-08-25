namespace QuanLyNhaHang
{
    partial class NhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nhapHang_button = new System.Windows.Forms.Button();
            this.tgNhap_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tgNhap_label = new System.Windows.Forms.Label();
            this.gia_textBox = new System.Windows.Forms.TextBox();
            this.gia_label = new System.Windows.Forms.Label();
            this.soLuong_textBox = new System.Windows.Forms.TextBox();
            this.soLuong_label = new System.Windows.Forms.Label();
            this.tenNL_textBox = new System.Windows.Forms.TextBox();
            this.tenNL_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nhapHang_button
            // 
            this.nhapHang_button.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapHang_button.Location = new System.Drawing.Point(177, 300);
            this.nhapHang_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nhapHang_button.Name = "nhapHang_button";
            this.nhapHang_button.Size = new System.Drawing.Size(179, 41);
            this.nhapHang_button.TabIndex = 27;
            this.nhapHang_button.Text = "Nhập hàng";
            this.nhapHang_button.UseVisualStyleBackColor = true;
            this.nhapHang_button.Click += new System.EventHandler(this.nhapHang_button_Click);
            // 
            // tgNhap_dateTimePicker
            // 
            this.tgNhap_dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgNhap_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tgNhap_dateTimePicker.Location = new System.Drawing.Point(269, 238);
            this.tgNhap_dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tgNhap_dateTimePicker.Name = "tgNhap_dateTimePicker";
            this.tgNhap_dateTimePicker.Size = new System.Drawing.Size(162, 38);
            this.tgNhap_dateTimePicker.TabIndex = 26;
            // 
            // tgNhap_label
            // 
            this.tgNhap_label.AutoSize = true;
            this.tgNhap_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgNhap_label.ForeColor = System.Drawing.Color.White;
            this.tgNhap_label.Location = new System.Drawing.Point(65, 238);
            this.tgNhap_label.Name = "tgNhap_label";
            this.tgNhap_label.Size = new System.Drawing.Size(181, 32);
            this.tgNhap_label.TabIndex = 25;
            this.tgNhap_label.Text = "Thời gian nhập:";
            // 
            // gia_textBox
            // 
            this.gia_textBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gia_textBox.Location = new System.Drawing.Point(269, 174);
            this.gia_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gia_textBox.Name = "gia_textBox";
            this.gia_textBox.Size = new System.Drawing.Size(162, 38);
            this.gia_textBox.TabIndex = 24;
            // 
            // gia_label
            // 
            this.gia_label.AutoSize = true;
            this.gia_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gia_label.ForeColor = System.Drawing.Color.White;
            this.gia_label.Location = new System.Drawing.Point(65, 177);
            this.gia_label.Name = "gia_label";
            this.gia_label.Size = new System.Drawing.Size(89, 32);
            this.gia_label.TabIndex = 23;
            this.gia_label.Text = "Giá/kg:";
            // 
            // soLuong_textBox
            // 
            this.soLuong_textBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuong_textBox.Location = new System.Drawing.Point(269, 113);
            this.soLuong_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soLuong_textBox.Name = "soLuong_textBox";
            this.soLuong_textBox.Size = new System.Drawing.Size(162, 38);
            this.soLuong_textBox.TabIndex = 22;
            // 
            // soLuong_label
            // 
            this.soLuong_label.AutoSize = true;
            this.soLuong_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuong_label.ForeColor = System.Drawing.Color.White;
            this.soLuong_label.Location = new System.Drawing.Point(65, 113);
            this.soLuong_label.Name = "soLuong_label";
            this.soLuong_label.Size = new System.Drawing.Size(161, 32);
            this.soLuong_label.TabIndex = 21;
            this.soLuong_label.Text = "Số Lượng(kg):";
            // 
            // tenNL_textBox
            // 
            this.tenNL_textBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenNL_textBox.Location = new System.Drawing.Point(269, 54);
            this.tenNL_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tenNL_textBox.Name = "tenNL_textBox";
            this.tenNL_textBox.Size = new System.Drawing.Size(162, 38);
            this.tenNL_textBox.TabIndex = 20;
            // 
            // tenNL_label
            // 
            this.tenNL_label.AutoSize = true;
            this.tenNL_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenNL_label.ForeColor = System.Drawing.Color.White;
            this.tenNL_label.Location = new System.Drawing.Point(65, 54);
            this.tenNL_label.Name = "tenNL_label";
            this.tenNL_label.Size = new System.Drawing.Size(192, 32);
            this.tenNL_label.TabIndex = 19;
            this.tenNL_label.Text = "Tên nguyên liệu:";
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(483, 391);
            this.Controls.Add(this.nhapHang_button);
            this.Controls.Add(this.tgNhap_dateTimePicker);
            this.Controls.Add(this.tgNhap_label);
            this.Controls.Add(this.gia_textBox);
            this.Controls.Add(this.gia_label);
            this.Controls.Add(this.soLuong_textBox);
            this.Controls.Add(this.soLuong_label);
            this.Controls.Add(this.tenNL_textBox);
            this.Controls.Add(this.tenNL_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NhapHang";
            this.Text = "NhapHang";
            this.Load += new System.EventHandler(this.NhapHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nhapHang_button;
        private System.Windows.Forms.DateTimePicker tgNhap_dateTimePicker;
        private System.Windows.Forms.Label tgNhap_label;
        private System.Windows.Forms.TextBox gia_textBox;
        private System.Windows.Forms.Label gia_label;
        private System.Windows.Forms.TextBox soLuong_textBox;
        private System.Windows.Forms.Label soLuong_label;
        private System.Windows.Forms.TextBox tenNL_textBox;
        private System.Windows.Forms.Label tenNL_label;
    }
}