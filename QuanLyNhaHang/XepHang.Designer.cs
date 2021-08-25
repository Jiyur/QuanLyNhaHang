namespace QuanLyNhaHang
{
    partial class XepHang
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
            this.XHngay_label = new System.Windows.Forms.Label();
            this.XHthang_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // XHngay_label
            // 
            this.XHngay_label.AutoSize = true;
            this.XHngay_label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.XHngay_label.ForeColor = System.Drawing.Color.White;
            this.XHngay_label.Location = new System.Drawing.Point(39, 49);
            this.XHngay_label.Name = "XHngay_label";
            this.XHngay_label.Size = new System.Drawing.Size(237, 32);
            this.XHngay_label.TabIndex = 0;
            this.XHngay_label.Text = "Xếp hạng theo ngày:";
            // 
            // XHthang_label
            // 
            this.XHthang_label.AutoSize = true;
            this.XHthang_label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.XHthang_label.ForeColor = System.Drawing.Color.White;
            this.XHthang_label.Location = new System.Drawing.Point(29, 112);
            this.XHthang_label.Name = "XHthang_label";
            this.XHthang_label.Size = new System.Drawing.Size(247, 32);
            this.XHthang_label.TabIndex = 1;
            this.XHthang_label.Text = "Xếp hạng theo tháng:";
            // 
            // XepHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(475, 195);
            this.Controls.Add(this.XHthang_label);
            this.Controls.Add(this.XHngay_label);
            this.Name = "XepHang";
            this.Text = "XepHang";
            this.Load += new System.EventHandler(this.XepHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label XHngay_label;
        private System.Windows.Forms.Label XHthang_label;
    }
}