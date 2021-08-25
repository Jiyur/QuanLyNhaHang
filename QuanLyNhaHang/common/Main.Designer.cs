namespace QuanLyNhaHang
{
    partial class Main
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
            this.Bep_label = new System.Windows.Forms.Label();
            this.NhaKho_label = new System.Windows.Forms.Label();
            this.QuanLy_label = new System.Windows.Forms.Label();
            this.Ban_label = new System.Windows.Forms.Label();
            this.thongke_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bep_label
            // 
            this.Bep_label.AutoSize = true;
            this.Bep_label.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bep_label.ForeColor = System.Drawing.Color.White;
            this.Bep_label.Location = new System.Drawing.Point(113, 130);
            this.Bep_label.Name = "Bep_label";
            this.Bep_label.Size = new System.Drawing.Size(64, 38);
            this.Bep_label.TabIndex = 0;
            this.Bep_label.Text = "Bếp";
            this.Bep_label.Click += new System.EventHandler(this.Bep_label_Click);
            // 
            // NhaKho_label
            // 
            this.NhaKho_label.AutoSize = true;
            this.NhaKho_label.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhaKho_label.ForeColor = System.Drawing.Color.White;
            this.NhaKho_label.Location = new System.Drawing.Point(113, 210);
            this.NhaKho_label.Name = "NhaKho_label";
            this.NhaKho_label.Size = new System.Drawing.Size(124, 38);
            this.NhaKho_label.TabIndex = 1;
            this.NhaKho_label.Text = "Nhà Kho";
            this.NhaKho_label.Click += new System.EventHandler(this.NhaKho_label_Click);
            // 
            // QuanLy_label
            // 
            this.QuanLy_label.AutoSize = true;
            this.QuanLy_label.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLy_label.ForeColor = System.Drawing.Color.White;
            this.QuanLy_label.Location = new System.Drawing.Point(113, 58);
            this.QuanLy_label.Name = "QuanLy_label";
            this.QuanLy_label.Size = new System.Drawing.Size(118, 38);
            this.QuanLy_label.TabIndex = 3;
            this.QuanLy_label.Text = "Quản Lý";
            this.QuanLy_label.Click += new System.EventHandler(this.QuanLy_label_Click);
            // 
            // Ban_label
            // 
            this.Ban_label.AutoSize = true;
            this.Ban_label.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ban_label.ForeColor = System.Drawing.Color.White;
            this.Ban_label.Location = new System.Drawing.Point(337, 58);
            this.Ban_label.Name = "Ban_label";
            this.Ban_label.Size = new System.Drawing.Size(63, 38);
            this.Ban_label.TabIndex = 4;
            this.Ban_label.Text = "Bàn";
            this.Ban_label.Click += new System.EventHandler(this.Ban_label_Click);
            // 
            // thongke_label
            // 
            this.thongke_label.AutoSize = true;
            this.thongke_label.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongke_label.ForeColor = System.Drawing.Color.White;
            this.thongke_label.Location = new System.Drawing.Point(337, 130);
            this.thongke_label.Name = "thongke_label";
            this.thongke_label.Size = new System.Drawing.Size(133, 38);
            this.thongke_label.TabIndex = 5;
            this.thongke_label.Text = "Thống kê";
            this.thongke_label.Click += new System.EventHandler(this.thongke_label_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(565, 360);
            this.Controls.Add(this.thongke_label);
            this.Controls.Add(this.Ban_label);
            this.Controls.Add(this.QuanLy_label);
            this.Controls.Add(this.NhaKho_label);
            this.Controls.Add(this.Bep_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bep_label;
        private System.Windows.Forms.Label NhaKho_label;
        private System.Windows.Forms.Label QuanLy_label;
        private System.Windows.Forms.Label Ban_label;
        private System.Windows.Forms.Label thongke_label;
    }
}