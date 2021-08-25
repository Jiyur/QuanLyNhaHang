namespace QuanLyNhaHang
{
    partial class NewUser
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
            this.label_Create = new System.Windows.Forms.Label();
            this.textBox_MK = new System.Windows.Forms.TextBox();
            this.label_MatKhau = new System.Windows.Forms.Label();
            this.textBox_tenDN = new System.Windows.Forms.TextBox();
            this.label_tenDN = new System.Windows.Forms.Label();
            this.textBox_maNV = new System.Windows.Forms.TextBox();
            this.label_maNV = new System.Windows.Forms.Label();
            this.label_chucVu = new System.Windows.Forms.Label();
            this.button_register = new System.Windows.Forms.Button();
            this.label_haveAccount = new System.Windows.Forms.Label();
            this.comboBox_chucvu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_Create
            // 
            this.label_Create.AutoSize = true;
            this.label_Create.Font = new System.Drawing.Font("Segoe UI", 16.8F);
            this.label_Create.ForeColor = System.Drawing.Color.White;
            this.label_Create.Location = new System.Drawing.Point(102, 27);
            this.label_Create.Name = "label_Create";
            this.label_Create.Size = new System.Drawing.Size(328, 46);
            this.label_Create.TabIndex = 53;
            this.label_Create.Text = "Create New Account";
            // 
            // textBox_MK
            // 
            this.textBox_MK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_MK.Location = new System.Drawing.Point(233, 223);
            this.textBox_MK.Name = "textBox_MK";
            this.textBox_MK.Size = new System.Drawing.Size(213, 39);
            this.textBox_MK.TabIndex = 52;
            // 
            // label_MatKhau
            // 
            this.label_MatKhau.AutoSize = true;
            this.label_MatKhau.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_MatKhau.ForeColor = System.Drawing.Color.White;
            this.label_MatKhau.Location = new System.Drawing.Point(101, 230);
            this.label_MatKhau.Name = "label_MatKhau";
            this.label_MatKhau.Size = new System.Drawing.Size(121, 32);
            this.label_MatKhau.TabIndex = 51;
            this.label_MatKhau.Text = "Mật khẩu:";
            // 
            // textBox_tenDN
            // 
            this.textBox_tenDN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_tenDN.Location = new System.Drawing.Point(233, 168);
            this.textBox_tenDN.Name = "textBox_tenDN";
            this.textBox_tenDN.Size = new System.Drawing.Size(213, 39);
            this.textBox_tenDN.TabIndex = 50;
            // 
            // label_tenDN
            // 
            this.label_tenDN.AutoSize = true;
            this.label_tenDN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_tenDN.ForeColor = System.Drawing.Color.White;
            this.label_tenDN.Location = new System.Drawing.Point(42, 175);
            this.label_tenDN.Name = "label_tenDN";
            this.label_tenDN.Size = new System.Drawing.Size(180, 32);
            this.label_tenDN.TabIndex = 49;
            this.label_tenDN.Text = "Tên đăng nhập:";
            // 
            // textBox_maNV
            // 
            this.textBox_maNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_maNV.Location = new System.Drawing.Point(233, 111);
            this.textBox_maNV.Name = "textBox_maNV";
            this.textBox_maNV.Size = new System.Drawing.Size(213, 39);
            this.textBox_maNV.TabIndex = 48;
            // 
            // label_maNV
            // 
            this.label_maNV.AutoSize = true;
            this.label_maNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_maNV.ForeColor = System.Drawing.Color.White;
            this.label_maNV.Location = new System.Drawing.Point(55, 114);
            this.label_maNV.Name = "label_maNV";
            this.label_maNV.Size = new System.Drawing.Size(167, 32);
            this.label_maNV.TabIndex = 47;
            this.label_maNV.Text = "Mã nhân viên:";
            // 
            // label_chucVu
            // 
            this.label_chucVu.AutoSize = true;
            this.label_chucVu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_chucVu.ForeColor = System.Drawing.Color.White;
            this.label_chucVu.Location = new System.Drawing.Point(115, 284);
            this.label_chucVu.Name = "label_chucVu";
            this.label_chucVu.Size = new System.Drawing.Size(107, 32);
            this.label_chucVu.TabIndex = 54;
            this.label_chucVu.Text = "Chức vụ:";
            // 
            // button_register
            // 
            this.button_register.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_register.Location = new System.Drawing.Point(121, 359);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(302, 45);
            this.button_register.TabIndex = 56;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // label_haveAccount
            // 
            this.label_haveAccount.AutoSize = true;
            this.label_haveAccount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_haveAccount.ForeColor = System.Drawing.Color.White;
            this.label_haveAccount.Location = new System.Drawing.Point(12, 446);
            this.label_haveAccount.Name = "label_haveAccount";
            this.label_haveAccount.Size = new System.Drawing.Size(302, 32);
            this.label_haveAccount.TabIndex = 57;
            this.label_haveAccount.Text = "<<Have an account? Login";
            this.label_haveAccount.Click += new System.EventHandler(this.label_haveAccount_Click);
            // 
            // comboBox_chucvu
            // 
            this.comboBox_chucvu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_chucvu.FormattingEnabled = true;
            this.comboBox_chucvu.Location = new System.Drawing.Point(233, 276);
            this.comboBox_chucvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_chucvu.Name = "comboBox_chucvu";
            this.comboBox_chucvu.Size = new System.Drawing.Size(213, 40);
            this.comboBox_chucvu.TabIndex = 58;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(531, 486);
            this.Controls.Add(this.comboBox_chucvu);
            this.Controls.Add(this.label_haveAccount);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.label_chucVu);
            this.Controls.Add(this.label_Create);
            this.Controls.Add(this.textBox_MK);
            this.Controls.Add(this.label_MatKhau);
            this.Controls.Add(this.textBox_tenDN);
            this.Controls.Add(this.label_tenDN);
            this.Controls.Add(this.textBox_maNV);
            this.Controls.Add(this.label_maNV);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Create;
        private System.Windows.Forms.TextBox textBox_MK;
        private System.Windows.Forms.Label label_MatKhau;
        private System.Windows.Forms.TextBox textBox_tenDN;
        private System.Windows.Forms.Label label_tenDN;
        private System.Windows.Forms.TextBox textBox_maNV;
        private System.Windows.Forms.Label label_maNV;
        private System.Windows.Forms.Label label_chucVu;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label label_haveAccount;
        private System.Windows.Forms.ComboBox comboBox_chucvu;
    }
}