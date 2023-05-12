namespace VanPhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_sosanhmatkhau = new System.Windows.Forms.TextBox();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(253, 18);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(170, 37);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Đăng nhập";
            // 
            // lbl_Account
            // 
            this.lbl_Account.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Account.Location = new System.Drawing.Point(87, 88);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(134, 34);
            this.lbl_Account.TabIndex = 1;
            this.lbl_Account.Text = "Tài khoản";
            this.lbl_Account.Click += new System.EventHandler(this.lbl_Account_Click);
            // 
            // txt_Account
            // 
            this.txt_Account.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Account.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Account.Location = new System.Drawing.Point(235, 82);
            this.txt_Account.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(273, 42);
            this.txt_Account.TabIndex = 1;
            this.txt_Account.TextChanged += new System.EventHandler(this.txt_Account_TextChanged);
            this.txt_Account.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Account_KeyPress);
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Password.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(235, 132);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(273, 42);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
            // 
            // lbl_Password
            // 
            this.lbl_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(87, 136);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(128, 34);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "Mật khẩu";
            this.lbl_Password.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Login.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(195, 189);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(170, 43);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_sosanhmatkhau
            // 
            this.txt_sosanhmatkhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_sosanhmatkhau.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sosanhmatkhau.Location = new System.Drawing.Point(516, 82);
            this.txt_sosanhmatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sosanhmatkhau.Name = "txt_sosanhmatkhau";
            this.txt_sosanhmatkhau.Size = new System.Drawing.Size(21, 42);
            this.txt_sosanhmatkhau.TabIndex = 9;
            this.txt_sosanhmatkhau.TabStop = false;
            this.txt_sosanhmatkhau.Visible = false;
            this.txt_sosanhmatkhau.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_taikhoan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taikhoan.Location = new System.Drawing.Point(545, 82);
            this.txt_taikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(21, 42);
            this.txt_taikhoan.TabIndex = 10;
            this.txt_taikhoan.TabStop = false;
            this.txt_taikhoan.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(371, 189);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đổi mật khẩu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(617, 252);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.txt_sosanhmatkhau);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_Account);
            this.Controls.Add(this.lbl_Account);
            this.Controls.Add(this.lbl_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.TextBox txt_Account;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_sosanhmatkhau;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.Button button1;
    }
}