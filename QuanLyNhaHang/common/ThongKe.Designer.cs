
namespace QuanLyNhaHang
{
    partial class ThongKe
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
            this.doanhthu_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.time_datepicker = new System.Windows.Forms.DateTimePicker();
            this.doanhthu_gridView = new System.Windows.Forms.DataGridView();
            this.button_lichHienTai = new System.Windows.Forms.Button();
            this.showAll_btn = new System.Windows.Forms.Button();
            this.chartshow_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doanhthu_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // doanhthu_label
            // 
            this.doanhthu_label.AutoSize = true;
            this.doanhthu_label.Font = new System.Drawing.Font("Segoe Print", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doanhthu_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(89)))));
            this.doanhthu_label.Location = new System.Drawing.Point(157, 45);
            this.doanhthu_label.Name = "doanhthu_label";
            this.doanhthu_label.Size = new System.Drawing.Size(315, 88);
            this.doanhthu_label.TabIndex = 0;
            this.doanhthu_label.Text = "Doanh Thu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(635, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn ngày: ";
            // 
            // time_datepicker
            // 
            this.time_datepicker.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_datepicker.Location = new System.Drawing.Point(797, 216);
            this.time_datepicker.Name = "time_datepicker";
            this.time_datepicker.Size = new System.Drawing.Size(200, 38);
            this.time_datepicker.TabIndex = 3;
            this.time_datepicker.ValueChanged += new System.EventHandler(this.time_datepicker_ValueChanged);
            // 
            // doanhthu_gridView
            // 
            this.doanhthu_gridView.AllowUserToAddRows = false;
            this.doanhthu_gridView.AllowUserToDeleteRows = false;
            this.doanhthu_gridView.AllowUserToResizeColumns = false;
            this.doanhthu_gridView.AllowUserToResizeRows = false;
            this.doanhthu_gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doanhthu_gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.doanhthu_gridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.doanhthu_gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.doanhthu_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.doanhthu_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.doanhthu_gridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.doanhthu_gridView.EnableHeadersVisualStyles = false;
            this.doanhthu_gridView.Location = new System.Drawing.Point(59, 135);
            this.doanhthu_gridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doanhthu_gridView.Name = "doanhthu_gridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Helvetica Neue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.doanhthu_gridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.doanhthu_gridView.RowHeadersVisible = false;
            this.doanhthu_gridView.RowHeadersWidth = 51;
            this.doanhthu_gridView.RowTemplate.Height = 50;
            this.doanhthu_gridView.Size = new System.Drawing.Size(484, 532);
            this.doanhthu_gridView.TabIndex = 5;
            // 
            // button_lichHienTai
            // 
            this.button_lichHienTai.BackColor = System.Drawing.Color.Teal;
            this.button_lichHienTai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lichHienTai.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lichHienTai.ForeColor = System.Drawing.Color.White;
            this.button_lichHienTai.Location = new System.Drawing.Point(641, 290);
            this.button_lichHienTai.Name = "button_lichHienTai";
            this.button_lichHienTai.Size = new System.Drawing.Size(235, 62);
            this.button_lichHienTai.TabIndex = 6;
            this.button_lichHienTai.Text = "Ngày hiện tại";
            this.button_lichHienTai.UseVisualStyleBackColor = false;
            this.button_lichHienTai.Click += new System.EventHandler(this.button_lichHienTai_Click);
            // 
            // showAll_btn
            // 
            this.showAll_btn.BackColor = System.Drawing.Color.Teal;
            this.showAll_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAll_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAll_btn.ForeColor = System.Drawing.Color.White;
            this.showAll_btn.Location = new System.Drawing.Point(913, 290);
            this.showAll_btn.Name = "showAll_btn";
            this.showAll_btn.Size = new System.Drawing.Size(235, 62);
            this.showAll_btn.TabIndex = 7;
            this.showAll_btn.Text = "Hiện Tất Cả";
            this.showAll_btn.UseVisualStyleBackColor = false;
            this.showAll_btn.Click += new System.EventHandler(this.showAll_btn_Click);
            // 
            // chartshow_btn
            // 
            this.chartshow_btn.BackColor = System.Drawing.Color.Black;
            this.chartshow_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chartshow_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartshow_btn.ForeColor = System.Drawing.Color.White;
            this.chartshow_btn.Location = new System.Drawing.Point(641, 413);
            this.chartshow_btn.Name = "chartshow_btn";
            this.chartshow_btn.Size = new System.Drawing.Size(507, 62);
            this.chartshow_btn.TabIndex = 8;
            this.chartshow_btn.Text = "Biểu đồ doanh thu";
            this.chartshow_btn.UseVisualStyleBackColor = false;
            this.chartshow_btn.Click += new System.EventHandler(this.chartshow_btn_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1219, 720);
            this.Controls.Add(this.chartshow_btn);
            this.Controls.Add(this.showAll_btn);
            this.Controls.Add(this.button_lichHienTai);
            this.Controls.Add(this.doanhthu_gridView);
            this.Controls.Add(this.time_datepicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doanhthu_label);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doanhthu_gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label doanhthu_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker time_datepicker;
        private System.Windows.Forms.DataGridView doanhthu_gridView;
        private System.Windows.Forms.Button button_lichHienTai;
        private System.Windows.Forms.Button showAll_btn;
        private System.Windows.Forms.Button chartshow_btn;
    }
}