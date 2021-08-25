
namespace QuanLyNhaHang
{
    partial class DoanhThuChart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.doanhthu_gridView = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.load_btn = new System.Windows.Forms.Button();
            this.doanhthu_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doanhthu_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.doanhthu_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.doanhthu_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.doanhthu_gridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.doanhthu_gridView.EnableHeadersVisualStyles = false;
            this.doanhthu_gridView.Location = new System.Drawing.Point(29, 415);
            this.doanhthu_gridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doanhthu_gridView.Name = "doanhthu_gridView";
            this.doanhthu_gridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Helvetica Neue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.doanhthu_gridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.doanhthu_gridView.RowHeadersVisible = false;
            this.doanhthu_gridView.RowHeadersWidth = 51;
            this.doanhthu_gridView.RowTemplate.Height = 50;
            this.doanhthu_gridView.Size = new System.Drawing.Size(624, 205);
            this.doanhthu_gridView.TabIndex = 6;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(29, 24);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Revenue";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(970, 335);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // load_btn
            // 
            this.load_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.load_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_btn.ForeColor = System.Drawing.Color.White;
            this.load_btn.Location = new System.Drawing.Point(856, 268);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(143, 52);
            this.load_btn.TabIndex = 9;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = false;
            this.load_btn.Visible = false;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click_1);
            // 
            // doanhthu_label
            // 
            this.doanhthu_label.AutoSize = true;
            this.doanhthu_label.Font = new System.Drawing.Font("Segoe Print", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doanhthu_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(89)))));
            this.doanhthu_label.Location = new System.Drawing.Point(765, 473);
            this.doanhthu_label.Name = "doanhthu_label";
            this.doanhthu_label.Size = new System.Drawing.Size(181, 88);
            this.doanhthu_label.TabIndex = 10;
            this.doanhthu_label.Text = "Chart";
            // 
            // DoanhThuChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 655);
            this.Controls.Add(this.doanhthu_label);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.doanhthu_gridView);
            this.Name = "DoanhThuChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoanhThuChart";
            this.Load += new System.EventHandler(this.DoanhThuChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doanhthu_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView doanhthu_gridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Label doanhthu_label;
    }
}