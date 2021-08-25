
namespace QuanLyNhaHang
{
    partial class Check_Form
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hour_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.second_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minute_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shift_label = new System.Windows.Forms.Label();
            this.ca_label = new System.Windows.Forms.Label();
            this.fnamevalue_label = new System.Windows.Forms.Label();
            this.fname_label = new System.Windows.Forms.Label();
            this.nhanvien_timer = new System.Windows.Forms.Timer(this.components);
            this.title_label = new System.Windows.Forms.Label();
            this.checkinn_btn = new System.Windows.Forms.Button();
            this.checkoutt_btn = new System.Windows.Forms.Button();
            this.idvalue_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.hour_label);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.second_label);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.minute_label);
            this.panel1.Location = new System.Drawing.Point(159, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 201);
            this.panel1.TabIndex = 15;
            // 
            // hour_label
            // 
            this.hour_label.AutoSize = true;
            this.hour_label.Font = new System.Drawing.Font("Helvetica Neue", 64.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour_label.ForeColor = System.Drawing.Color.White;
            this.hour_label.Location = new System.Drawing.Point(73, 39);
            this.hour_label.Name = "hour_label";
            this.hour_label.Size = new System.Drawing.Size(173, 125);
            this.hour_label.TabIndex = 1;
            this.hour_label.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 32F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(267, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 64);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // second_label
            // 
            this.second_label.AutoSize = true;
            this.second_label.Font = new System.Drawing.Font("Helvetica Neue", 64.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second_label.ForeColor = System.Drawing.Color.White;
            this.second_label.Location = new System.Drawing.Point(613, 39);
            this.second_label.Name = "second_label";
            this.second_label.Size = new System.Drawing.Size(173, 125);
            this.second_label.TabIndex = 3;
            this.second_label.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 32F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(530, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 64);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            // 
            // minute_label
            // 
            this.minute_label.AutoSize = true;
            this.minute_label.Font = new System.Drawing.Font("Helvetica Neue", 64.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minute_label.ForeColor = System.Drawing.Color.White;
            this.minute_label.Location = new System.Drawing.Point(340, 39);
            this.minute_label.Name = "minute_label";
            this.minute_label.Size = new System.Drawing.Size(173, 125);
            this.minute_label.TabIndex = 2;
            this.minute_label.Text = "00";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.shift_label);
            this.panel2.Controls.Add(this.ca_label);
            this.panel2.Controls.Add(this.id_label);
            this.panel2.Controls.Add(this.fnamevalue_label);
            this.panel2.Controls.Add(this.idvalue_label);
            this.panel2.Controls.Add(this.fname_label);
            this.panel2.Location = new System.Drawing.Point(918, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 163);
            this.panel2.TabIndex = 20;
            // 
            // shift_label
            // 
            this.shift_label.AutoSize = true;
            this.shift_label.Font = new System.Drawing.Font("Helvetica Neue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shift_label.ForeColor = System.Drawing.Color.White;
            this.shift_label.Location = new System.Drawing.Point(80, 120);
            this.shift_label.Name = "shift_label";
            this.shift_label.Size = new System.Drawing.Size(58, 27);
            this.shift_label.TabIndex = 6;
            this.shift_label.Text = "NaN";
            this.shift_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ca_label
            // 
            this.ca_label.AutoSize = true;
            this.ca_label.Font = new System.Drawing.Font("Helvetica Neue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ca_label.ForeColor = System.Drawing.Color.White;
            this.ca_label.Location = new System.Drawing.Point(18, 120);
            this.ca_label.Name = "ca_label";
            this.ca_label.Size = new System.Drawing.Size(59, 27);
            this.ca_label.TabIndex = 7;
            this.ca_label.Text = "Ca : ";
            this.ca_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fnamevalue_label
            // 
            this.fnamevalue_label.AutoSize = true;
            this.fnamevalue_label.Font = new System.Drawing.Font("Helvetica Neue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnamevalue_label.ForeColor = System.Drawing.Color.White;
            this.fnamevalue_label.Location = new System.Drawing.Point(115, 72);
            this.fnamevalue_label.Name = "fnamevalue_label";
            this.fnamevalue_label.Size = new System.Drawing.Size(58, 27);
            this.fnamevalue_label.TabIndex = 18;
            this.fnamevalue_label.Text = "NaN";
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Font = new System.Drawing.Font("Helvetica Neue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_label.ForeColor = System.Drawing.Color.White;
            this.fname_label.Location = new System.Drawing.Point(18, 72);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(79, 27);
            this.fname_label.TabIndex = 17;
            this.fname_label.Text = "Name:";
            // 
            // nhanvien_timer
            // 
            this.nhanvien_timer.Tick += new System.EventHandler(this.nhanvien_timer_Tick);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Agency FB", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.White;
            this.title_label.Location = new System.Drawing.Point(468, 59);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(234, 61);
            this.title_label.TabIndex = 19;
            this.title_label.Text = "Check Form";
            // 
            // checkinn_btn
            // 
            this.checkinn_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.checkinn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkinn_btn.Font = new System.Drawing.Font("Agency FB", 17F);
            this.checkinn_btn.ForeColor = System.Drawing.Color.White;
            this.checkinn_btn.Location = new System.Drawing.Point(411, 414);
            this.checkinn_btn.Name = "checkinn_btn";
            this.checkinn_btn.Size = new System.Drawing.Size(147, 52);
            this.checkinn_btn.TabIndex = 23;
            this.checkinn_btn.Text = "Check In";
            this.checkinn_btn.UseVisualStyleBackColor = false;
            this.checkinn_btn.Click += new System.EventHandler(this.checkinn_btn_Click);
            // 
            // checkoutt_btn
            // 
            this.checkoutt_btn.BackColor = System.Drawing.Color.LightCoral;
            this.checkoutt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutt_btn.Font = new System.Drawing.Font("Agency FB", 17F);
            this.checkoutt_btn.ForeColor = System.Drawing.Color.White;
            this.checkoutt_btn.Location = new System.Drawing.Point(609, 414);
            this.checkoutt_btn.Name = "checkoutt_btn";
            this.checkoutt_btn.Size = new System.Drawing.Size(147, 52);
            this.checkoutt_btn.TabIndex = 24;
            this.checkoutt_btn.Text = "Check Out";
            this.checkoutt_btn.UseVisualStyleBackColor = false;
            this.checkoutt_btn.Click += new System.EventHandler(this.checkoutt_btn_Click);
            // 
            // idvalue_label
            // 
            this.idvalue_label.AutoSize = true;
            this.idvalue_label.Font = new System.Drawing.Font("Helvetica Neue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idvalue_label.ForeColor = System.Drawing.Color.White;
            this.idvalue_label.Location = new System.Drawing.Point(80, 24);
            this.idvalue_label.Name = "idvalue_label";
            this.idvalue_label.Size = new System.Drawing.Size(58, 27);
            this.idvalue_label.TabIndex = 16;
            this.idvalue_label.Text = "NaN";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Helvetica Neue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.ForeColor = System.Drawing.Color.White;
            this.id_label.Location = new System.Drawing.Point(17, 24);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(40, 27);
            this.id_label.TabIndex = 6;
            this.id_label.Text = "ID:";
            // 
            // Check_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1137, 618);
            this.Controls.Add(this.checkoutt_btn);
            this.Controls.Add(this.checkinn_btn);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Check_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check_Form";
            this.Load += new System.EventHandler(this.Check_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label hour_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label second_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label minute_label;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label fnamevalue_label;
        public System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label shift_label;
        public System.Windows.Forms.Label ca_label;
        private System.Windows.Forms.Timer nhanvien_timer;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button checkinn_btn;
        private System.Windows.Forms.Button checkoutt_btn;
        private System.Windows.Forms.Label id_label;
        public System.Windows.Forms.Label idvalue_label;
    }
}