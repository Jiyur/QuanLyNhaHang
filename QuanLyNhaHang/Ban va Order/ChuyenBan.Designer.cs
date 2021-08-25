namespace QuanLyNhaHang
{
    partial class ChuyenBan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sangBan_textBox = new System.Windows.Forms.TextBox();
            this.ChuyenSangBan_label = new System.Windows.Forms.Label();
            this.tuBan_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ChuyenTuBan_label = new System.Windows.Forms.Label();
            this.BanTrong_dataGridView = new System.Windows.Forms.DataGridView();
            this.doanhthu_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BanTrong_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.sangBan_textBox);
            this.panel1.Controls.Add(this.ChuyenSangBan_label);
            this.panel1.Controls.Add(this.tuBan_textBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ChuyenTuBan_label);
            this.panel1.Location = new System.Drawing.Point(436, 106);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 231);
            this.panel1.TabIndex = 8;
            // 
            // sangBan_textBox
            // 
            this.sangBan_textBox.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.sangBan_textBox.Location = new System.Drawing.Point(241, 98);
            this.sangBan_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sangBan_textBox.Name = "sangBan_textBox";
            this.sangBan_textBox.Size = new System.Drawing.Size(103, 38);
            this.sangBan_textBox.TabIndex = 12;
            // 
            // ChuyenSangBan_label
            // 
            this.ChuyenSangBan_label.AutoSize = true;
            this.ChuyenSangBan_label.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.ChuyenSangBan_label.ForeColor = System.Drawing.Color.White;
            this.ChuyenSangBan_label.Location = new System.Drawing.Point(22, 102);
            this.ChuyenSangBan_label.Name = "ChuyenSangBan_label";
            this.ChuyenSangBan_label.Size = new System.Drawing.Size(161, 32);
            this.ChuyenSangBan_label.TabIndex = 11;
            this.ChuyenSangBan_label.Text = "Đổi sang bàn:";
            // 
            // tuBan_textBox
            // 
            this.tuBan_textBox.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tuBan_textBox.Location = new System.Drawing.Point(241, 32);
            this.tuBan_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tuBan_textBox.Name = "tuBan_textBox";
            this.tuBan_textBox.Size = new System.Drawing.Size(103, 38);
            this.tuBan_textBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(114, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Đổi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChuyenTuBan_label
            // 
            this.ChuyenTuBan_label.AutoSize = true;
            this.ChuyenTuBan_label.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.ChuyenTuBan_label.ForeColor = System.Drawing.Color.White;
            this.ChuyenTuBan_label.Location = new System.Drawing.Point(22, 38);
            this.ChuyenTuBan_label.Name = "ChuyenTuBan_label";
            this.ChuyenTuBan_label.Size = new System.Drawing.Size(133, 32);
            this.ChuyenTuBan_label.TabIndex = 8;
            this.ChuyenTuBan_label.Text = "Đổi từ bàn:";
            // 
            // BanTrong_dataGridView
            // 
            this.BanTrong_dataGridView.AllowUserToAddRows = false;
            this.BanTrong_dataGridView.AllowUserToDeleteRows = false;
            this.BanTrong_dataGridView.AllowUserToResizeColumns = false;
            this.BanTrong_dataGridView.AllowUserToResizeRows = false;
            this.BanTrong_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BanTrong_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BanTrong_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BanTrong_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BanTrong_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.BanTrong_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BanTrong_dataGridView.DefaultCellStyle = dataGridViewCellStyle20;
            this.BanTrong_dataGridView.EnableHeadersVisualStyles = false;
            this.BanTrong_dataGridView.Location = new System.Drawing.Point(20, 61);
            this.BanTrong_dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BanTrong_dataGridView.Name = "BanTrong_dataGridView";
            this.BanTrong_dataGridView.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Helvetica Neue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BanTrong_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.BanTrong_dataGridView.RowHeadersVisible = false;
            this.BanTrong_dataGridView.RowHeadersWidth = 51;
            this.BanTrong_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.BanTrong_dataGridView.RowTemplate.Height = 35;
            this.BanTrong_dataGridView.Size = new System.Drawing.Size(257, 340);
            this.BanTrong_dataGridView.TabIndex = 10;
            this.BanTrong_dataGridView.DoubleClick += new System.EventHandler(this.BanTrong_dataGridView_DoubleClick);
            // 
            // doanhthu_label
            // 
            this.doanhthu_label.AutoSize = true;
            this.doanhthu_label.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doanhthu_label.ForeColor = System.Drawing.Color.White;
            this.doanhthu_label.Location = new System.Drawing.Point(453, 23);
            this.doanhthu_label.Name = "doanhthu_label";
            this.doanhthu_label.Size = new System.Drawing.Size(339, 70);
            this.doanhthu_label.TabIndex = 11;
            this.doanhthu_label.Text = "Table Exchange";
            // 
            // ChuyenBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(835, 445);
            this.Controls.Add(this.doanhthu_label);
            this.Controls.Add(this.BanTrong_dataGridView);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChuyenBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChuyenBan";
            this.Load += new System.EventHandler(this.ChuyenBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BanTrong_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tuBan_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ChuyenTuBan_label;
        private System.Windows.Forms.TextBox sangBan_textBox;
        private System.Windows.Forms.Label ChuyenSangBan_label;
        private System.Windows.Forms.DataGridView BanTrong_dataGridView;
        private System.Windows.Forms.Label doanhthu_label;
    }
}