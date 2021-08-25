namespace QuanLyNhaHang
{
    partial class SoKhach
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
            this.Enter_button = new System.Windows.Forms.Button();
            this.soKhach_textBox = new System.Windows.Forms.TextBox();
            this.soKhach_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Enter_button
            // 
            this.Enter_button.BackColor = System.Drawing.Color.Teal;
            this.Enter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_button.ForeColor = System.Drawing.Color.White;
            this.Enter_button.Location = new System.Drawing.Point(369, 56);
            this.Enter_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(106, 42);
            this.Enter_button.TabIndex = 5;
            this.Enter_button.Text = "Enter";
            this.Enter_button.UseVisualStyleBackColor = false;
            this.Enter_button.Click += new System.EventHandler(this.Enter_button_Click);
            // 
            // soKhach_textBox
            // 
            this.soKhach_textBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soKhach_textBox.Location = new System.Drawing.Point(196, 61);
            this.soKhach_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soKhach_textBox.Name = "soKhach_textBox";
            this.soKhach_textBox.Size = new System.Drawing.Size(139, 34);
            this.soKhach_textBox.TabIndex = 4;
            // 
            // soKhach_label
            // 
            this.soKhach_label.AutoSize = true;
            this.soKhach_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soKhach_label.ForeColor = System.Drawing.Color.White;
            this.soKhach_label.Location = new System.Drawing.Point(41, 67);
            this.soKhach_label.Name = "soKhach_label";
            this.soKhach_label.Size = new System.Drawing.Size(149, 25);
            this.soKhach_label.TabIndex = 3;
            this.soKhach_label.Text = "Nhập số khách:";
            // 
            // SoKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(516, 161);
            this.Controls.Add(this.Enter_button);
            this.Controls.Add(this.soKhach_textBox);
            this.Controls.Add(this.soKhach_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SoKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoKhach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter_button;
        private System.Windows.Forms.TextBox soKhach_textBox;
        private System.Windows.Forms.Label soKhach_label;
    }
}