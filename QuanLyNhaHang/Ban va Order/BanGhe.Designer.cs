
namespace QuanLyNhaHang
{
    partial class BanGhe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ThaoTac_groupBox = new System.Windows.Forms.GroupBox();
            this.chuyenBan_button = new System.Windows.Forms.Button();
            this.xuatBill_button = new System.Windows.Forms.Button();
            this.Tailai_button = new System.Windows.Forms.Button();
            this.SuaTT_button = new System.Windows.Forms.Button();
            this.XoaBan_button = new System.Windows.Forms.Button();
            this.ThemBan_button = new System.Windows.Forms.Button();
            this.trangthai_txtbox = new System.Windows.Forms.TextBox();
            this.trangthai_label = new System.Windows.Forms.Label();
            this.slk_txtbox = new System.Windows.Forms.TextBox();
            this.soLuong_label = new System.Windows.Forms.Label();
            this.id_txtbox = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.thanhToan_textBox = new System.Windows.Forms.TextBox();
            this.thanhToan_label = new System.Windows.Forms.Label();
            this.DsBan_dataGridView = new System.Windows.Forms.DataGridView();
            this.ThaoTac_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DsBan_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ThaoTac_groupBox
            // 
            this.ThaoTac_groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.ThaoTac_groupBox.Controls.Add(this.chuyenBan_button);
            this.ThaoTac_groupBox.Controls.Add(this.xuatBill_button);
            this.ThaoTac_groupBox.Controls.Add(this.Tailai_button);
            this.ThaoTac_groupBox.Controls.Add(this.SuaTT_button);
            this.ThaoTac_groupBox.Controls.Add(this.XoaBan_button);
            this.ThaoTac_groupBox.Controls.Add(this.ThemBan_button);
            this.ThaoTac_groupBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThaoTac_groupBox.ForeColor = System.Drawing.Color.White;
            this.ThaoTac_groupBox.Location = new System.Drawing.Point(11, 170);
            this.ThaoTac_groupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThaoTac_groupBox.Name = "ThaoTac_groupBox";
            this.ThaoTac_groupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThaoTac_groupBox.Size = new System.Drawing.Size(1009, 136);
            this.ThaoTac_groupBox.TabIndex = 3;
            this.ThaoTac_groupBox.TabStop = false;
            this.ThaoTac_groupBox.Text = "THAO TÁC";
            // 
            // chuyenBan_button
            // 
            this.chuyenBan_button.AutoSize = true;
            this.chuyenBan_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chuyenBan_button.ForeColor = System.Drawing.Color.Black;
            this.chuyenBan_button.Location = new System.Drawing.Point(834, 50);
            this.chuyenBan_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chuyenBan_button.Name = "chuyenBan_button";
            this.chuyenBan_button.Size = new System.Drawing.Size(158, 50);
            this.chuyenBan_button.TabIndex = 10;
            this.chuyenBan_button.Text = "Chuyển bàn";
            this.chuyenBan_button.UseVisualStyleBackColor = true;
            this.chuyenBan_button.Click += new System.EventHandler(this.chuyenBan_button_Click);
            // 
            // xuatBill_button
            // 
            this.xuatBill_button.AutoSize = true;
            this.xuatBill_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatBill_button.ForeColor = System.Drawing.Color.Black;
            this.xuatBill_button.Location = new System.Drawing.Point(670, 50);
            this.xuatBill_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xuatBill_button.Name = "xuatBill_button";
            this.xuatBill_button.Size = new System.Drawing.Size(158, 50);
            this.xuatBill_button.TabIndex = 9;
            this.xuatBill_button.Text = "Xuất bill";
            this.xuatBill_button.UseVisualStyleBackColor = true;
            this.xuatBill_button.Click += new System.EventHandler(this.xuatBill_button_Click);
            // 
            // Tailai_button
            // 
            this.Tailai_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tailai_button.ForeColor = System.Drawing.Color.Black;
            this.Tailai_button.Location = new System.Drawing.Point(507, 50);
            this.Tailai_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tailai_button.Name = "Tailai_button";
            this.Tailai_button.Size = new System.Drawing.Size(158, 50);
            this.Tailai_button.TabIndex = 7;
            this.Tailai_button.Text = "Tải lại";
            this.Tailai_button.UseVisualStyleBackColor = true;
            this.Tailai_button.Click += new System.EventHandler(this.Tailai_button_Click);
            // 
            // SuaTT_button
            // 
            this.SuaTT_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaTT_button.ForeColor = System.Drawing.Color.Black;
            this.SuaTT_button.Location = new System.Drawing.Point(343, 50);
            this.SuaTT_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SuaTT_button.Name = "SuaTT_button";
            this.SuaTT_button.Size = new System.Drawing.Size(158, 50);
            this.SuaTT_button.TabIndex = 6;
            this.SuaTT_button.Text = "Sửa thông tin";
            this.SuaTT_button.UseVisualStyleBackColor = true;
            this.SuaTT_button.Click += new System.EventHandler(this.SuaTT_button_Click);
            // 
            // XoaBan_button
            // 
            this.XoaBan_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaBan_button.ForeColor = System.Drawing.Color.Black;
            this.XoaBan_button.Location = new System.Drawing.Point(180, 50);
            this.XoaBan_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XoaBan_button.Name = "XoaBan_button";
            this.XoaBan_button.Size = new System.Drawing.Size(158, 50);
            this.XoaBan_button.TabIndex = 5;
            this.XoaBan_button.Text = "Xóa Bàn";
            this.XoaBan_button.UseVisualStyleBackColor = true;
            this.XoaBan_button.Click += new System.EventHandler(this.XoaBan_button_Click);
            // 
            // ThemBan_button
            // 
            this.ThemBan_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemBan_button.ForeColor = System.Drawing.Color.Black;
            this.ThemBan_button.Location = new System.Drawing.Point(16, 50);
            this.ThemBan_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThemBan_button.Name = "ThemBan_button";
            this.ThemBan_button.Size = new System.Drawing.Size(158, 50);
            this.ThemBan_button.TabIndex = 4;
            this.ThemBan_button.Text = "Thêm Bàn";
            this.ThemBan_button.UseVisualStyleBackColor = true;
            this.ThemBan_button.Click += new System.EventHandler(this.ThemBan_button_Click);
            // 
            // trangthai_txtbox
            // 
            this.trangthai_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangthai_txtbox.Location = new System.Drawing.Point(742, 48);
            this.trangthai_txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trangthai_txtbox.Name = "trangthai_txtbox";
            this.trangthai_txtbox.Size = new System.Drawing.Size(162, 30);
            this.trangthai_txtbox.TabIndex = 41;
            // 
            // trangthai_label
            // 
            this.trangthai_label.AutoSize = true;
            this.trangthai_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangthai_label.ForeColor = System.Drawing.Color.White;
            this.trangthai_label.Location = new System.Drawing.Point(591, 48);
            this.trangthai_label.Name = "trangthai_label";
            this.trangthai_label.Size = new System.Drawing.Size(131, 32);
            this.trangthai_label.TabIndex = 40;
            this.trangthai_label.Text = "Trạng Thái:";
            // 
            // slk_txtbox
            // 
            this.slk_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slk_txtbox.Location = new System.Drawing.Point(271, 101);
            this.slk_txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slk_txtbox.Name = "slk_txtbox";
            this.slk_txtbox.Size = new System.Drawing.Size(162, 30);
            this.slk_txtbox.TabIndex = 37;
            // 
            // soLuong_label
            // 
            this.soLuong_label.AutoSize = true;
            this.soLuong_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuong_label.ForeColor = System.Drawing.Color.White;
            this.soLuong_label.Location = new System.Drawing.Point(52, 101);
            this.soLuong_label.Name = "soLuong_label";
            this.soLuong_label.Size = new System.Drawing.Size(193, 32);
            this.soLuong_label.TabIndex = 36;
            this.soLuong_label.Text = "Số Lượng Khách:";
            // 
            // id_txtbox
            // 
            this.id_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txtbox.Location = new System.Drawing.Point(271, 40);
            this.id_txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.Size = new System.Drawing.Size(162, 30);
            this.id_txtbox.TabIndex = 35;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.ForeColor = System.Drawing.Color.White;
            this.id_label.Location = new System.Drawing.Point(205, 48);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(43, 32);
            this.id_label.TabIndex = 34;
            this.id_label.Text = "ID:";
            // 
            // thanhToan_textBox
            // 
            this.thanhToan_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanhToan_textBox.Location = new System.Drawing.Point(742, 101);
            this.thanhToan_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thanhToan_textBox.Name = "thanhToan_textBox";
            this.thanhToan_textBox.Size = new System.Drawing.Size(162, 30);
            this.thanhToan_textBox.TabIndex = 43;
            // 
            // thanhToan_label
            // 
            this.thanhToan_label.AutoSize = true;
            this.thanhToan_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanhToan_label.ForeColor = System.Drawing.Color.White;
            this.thanhToan_label.Location = new System.Drawing.Point(576, 101);
            this.thanhToan_label.Name = "thanhToan_label";
            this.thanhToan_label.Size = new System.Drawing.Size(142, 32);
            this.thanhToan_label.TabIndex = 42;
            this.thanhToan_label.Text = "Thanh toán:";
            // 
            // DsBan_dataGridView
            // 
            this.DsBan_dataGridView.AllowUserToAddRows = false;
            this.DsBan_dataGridView.AllowUserToDeleteRows = false;
            this.DsBan_dataGridView.AllowUserToOrderColumns = true;
            this.DsBan_dataGridView.AllowUserToResizeColumns = false;
            this.DsBan_dataGridView.AllowUserToResizeRows = false;
            this.DsBan_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DsBan_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DsBan_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DsBan_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(102)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DsBan_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DsBan_dataGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DsBan_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DsBan_dataGridView.EnableHeadersVisualStyles = false;
            this.DsBan_dataGridView.Location = new System.Drawing.Point(11, 309);
            this.DsBan_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DsBan_dataGridView.Name = "DsBan_dataGridView";
            this.DsBan_dataGridView.ReadOnly = true;
            this.DsBan_dataGridView.RowHeadersVisible = false;
            this.DsBan_dataGridView.RowHeadersWidth = 51;
            this.DsBan_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.DsBan_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DsBan_dataGridView.RowTemplate.Height = 28;
            this.DsBan_dataGridView.Size = new System.Drawing.Size(1009, 287);
            this.DsBan_dataGridView.TabIndex = 44;
            this.DsBan_dataGridView.Click += new System.EventHandler(this.DsBan_dataGridView_Click);
            this.DsBan_dataGridView.DoubleClick += new System.EventHandler(this.DsBan_dataGridView_DoubleClick);
            // 
            // BanGhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1024, 609);
            this.Controls.Add(this.DsBan_dataGridView);
            this.Controls.Add(this.thanhToan_textBox);
            this.Controls.Add(this.thanhToan_label);
            this.Controls.Add(this.trangthai_txtbox);
            this.Controls.Add(this.ThaoTac_groupBox);
            this.Controls.Add(this.trangthai_label);
            this.Controls.Add(this.id_txtbox);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.slk_txtbox);
            this.Controls.Add(this.soLuong_label);
            this.Name = "BanGhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BanGhe";
            this.Load += new System.EventHandler(this.BanGhe_Load);
            this.ThaoTac_groupBox.ResumeLayout(false);
            this.ThaoTac_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DsBan_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox ThaoTac_groupBox;
        private System.Windows.Forms.Button Tailai_button;
        private System.Windows.Forms.Button SuaTT_button;
        private System.Windows.Forms.Button XoaBan_button;
        private System.Windows.Forms.Button ThemBan_button;
        private System.Windows.Forms.TextBox trangthai_txtbox;
        private System.Windows.Forms.Label trangthai_label;
        private System.Windows.Forms.TextBox slk_txtbox;
        private System.Windows.Forms.Label soLuong_label;
        private System.Windows.Forms.TextBox id_txtbox;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Button xuatBill_button;
        private System.Windows.Forms.TextBox thanhToan_textBox;
        private System.Windows.Forms.Label thanhToan_label;
        private System.Windows.Forms.DataGridView DsBan_dataGridView;
        private System.Windows.Forms.Button chuyenBan_button;
    }
}