
namespace QuanLyNhaHang
{
    partial class Login
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
            this.register_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.QuanLy_radio = new System.Windows.Forms.RadioButton();
            this.NhanVien_radio = new System.Windows.Forms.RadioButton();
            this.login_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.Lgon_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pass_txtbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.user_txtbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.pass_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.id_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_label.ForeColor = System.Drawing.Color.Gainsboro;
            this.register_label.Location = new System.Drawing.Point(388, 508);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(266, 26);
            this.register_label.TabIndex = 19;
            this.register_label.Text = "New User? Sign Up Now !";
            this.register_label.Click += new System.EventHandler(this.register_label_Click);
            // 
            // QuanLy_radio
            // 
            this.QuanLy_radio.AutoSize = true;
            this.QuanLy_radio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLy_radio.ForeColor = System.Drawing.Color.White;
            this.QuanLy_radio.Location = new System.Drawing.Point(440, 355);
            this.QuanLy_radio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuanLy_radio.Name = "QuanLy_radio";
            this.QuanLy_radio.Size = new System.Drawing.Size(119, 36);
            this.QuanLy_radio.TabIndex = 18;
            this.QuanLy_radio.TabStop = true;
            this.QuanLy_radio.Text = "quan ly";
            this.QuanLy_radio.UseVisualStyleBackColor = true;
            // 
            // NhanVien_radio
            // 
            this.NhanVien_radio.AutoSize = true;
            this.NhanVien_radio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhanVien_radio.ForeColor = System.Drawing.Color.White;
            this.NhanVien_radio.Location = new System.Drawing.Point(112, 355);
            this.NhanVien_radio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NhanVien_radio.Name = "NhanVien_radio";
            this.NhanVien_radio.Size = new System.Drawing.Size(146, 36);
            this.NhanVien_radio.TabIndex = 17;
            this.NhanVien_radio.TabStop = true;
            this.NhanVien_radio.Text = "nhan vien";
            this.NhanVien_radio.UseVisualStyleBackColor = true;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(394, 412);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(165, 65);
            this.login_btn.TabIndex = 16;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.LightCoral;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(173, 412);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(165, 65);
            this.exit_btn.TabIndex = 15;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            // 
            // Lgon_label
            // 
            this.Lgon_label.AutoSize = true;
            this.Lgon_label.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lgon_label.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lgon_label.Location = new System.Drawing.Point(277, 26);
            this.Lgon_label.Name = "Lgon_label";
            this.Lgon_label.Size = new System.Drawing.Size(180, 91);
            this.Lgon_label.TabIndex = 14;
            this.Lgon_label.Text = "Login";
            // 
            // pass_txtbox
            // 
            this.pass_txtbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.pass_txtbox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_txtbox.Location = new System.Drawing.Point(288, 269);
            this.pass_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pass_txtbox.Name = "pass_txtbox";
            this.pass_txtbox.Size = new System.Drawing.Size(271, 44);
            this.pass_txtbox.TabIndex = 13;
            this.pass_txtbox.UseSystemPasswordChar = true;
            // 
            // user_txtbox
            // 
            this.user_txtbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.user_txtbox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_txtbox.Location = new System.Drawing.Point(288, 145);
            this.user_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.user_txtbox.Name = "user_txtbox";
            this.user_txtbox.Size = new System.Drawing.Size(271, 44);
            this.user_txtbox.TabIndex = 12;
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_label.ForeColor = System.Drawing.Color.White;
            this.pass_label.Location = new System.Drawing.Point(106, 264);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(150, 41);
            this.pass_label.TabIndex = 11;
            this.pass_label.Text = "Password:";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.ForeColor = System.Drawing.Color.White;
            this.id_label.Location = new System.Drawing.Point(106, 140);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(159, 41);
            this.id_label.TabIndex = 10;
            this.id_label.Text = "Username:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.download;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(173, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 59);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(688, 551);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.register_label);
            this.Controls.Add(this.QuanLy_radio);
            this.Controls.Add(this.NhanVien_radio);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.Lgon_label);
            this.Controls.Add(this.pass_txtbox);
            this.Controls.Add(this.user_txtbox);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.id_label);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel register_label;
        private System.Windows.Forms.RadioButton QuanLy_radio;
        private System.Windows.Forms.RadioButton NhanVien_radio;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button exit_btn;
        private Bunifu.Framework.UI.BunifuCustomLabel Lgon_label;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox pass_txtbox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox user_txtbox;
        private Bunifu.Framework.UI.BunifuCustomLabel pass_label;
        private Bunifu.Framework.UI.BunifuCustomLabel id_label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}