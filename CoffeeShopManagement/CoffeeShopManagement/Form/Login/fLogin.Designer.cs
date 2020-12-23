namespace CoffeeShopManagement
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.lConnectToDeveloper = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bLogin = new Guna.UI2.WinForms.Guna2Button();
            this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxShowPassword = new System.Windows.Forms.CheckBox();
            this.lForgetPassword = new System.Windows.Forms.Label();
            this.bCreateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.lNotification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lConnectToDeveloper
            // 
            this.lConnectToDeveloper.AutoSize = true;
            this.lConnectToDeveloper.BackColor = System.Drawing.Color.Transparent;
            this.lConnectToDeveloper.Cursor = System.Windows.Forms.Cursors.Help;
            this.lConnectToDeveloper.ForeColor = System.Drawing.Color.Gray;
            this.lConnectToDeveloper.Location = new System.Drawing.Point(19, 739);
            this.lConnectToDeveloper.Name = "lConnectToDeveloper";
            this.lConnectToDeveloper.Size = new System.Drawing.Size(141, 13);
            this.lConnectToDeveloper.TabIndex = 5;
            this.lConnectToDeveloper.Text = "@ Liên hệ với nhà phát triển";
            this.lConnectToDeveloper.Click += new System.EventHandler(this.lConnectToDeveloper_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(973, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(981, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Đăng nhập để sử dụng hệ thống";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(980, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên đăng nhập";
            // 
            // bLogin
            // 
            this.bLogin.AutoRoundedCorners = true;
            this.bLogin.BackColor = System.Drawing.Color.Transparent;
            this.bLogin.BorderRadius = 27;
            this.bLogin.CheckedState.Parent = this.bLogin;
            this.bLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLogin.CustomImages.Parent = this.bLogin;
            this.bLogin.FillColor = System.Drawing.Color.Chocolate;
            this.bLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.ForeColor = System.Drawing.Color.White;
            this.bLogin.HoverState.Parent = this.bLogin;
            this.bLogin.Location = new System.Drawing.Point(983, 446);
            this.bLogin.Name = "bLogin";
            this.bLogin.ShadowDecoration.Parent = this.bLogin;
            this.bLogin.Size = new System.Drawing.Size(483, 56);
            this.bLogin.TabIndex = 2;
            this.bLogin.Text = "Đăng nhập";
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.AutoRoundedCorners = true;
            this.tbUsername.BackColor = System.Drawing.Color.Transparent;
            this.tbUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsername.BorderRadius = 28;
            this.tbUsername.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.DefaultText = "";
            this.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.DisabledState.Parent = this.tbUsername;
            this.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.FocusedState.Parent = this.tbUsername;
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.Black;
            this.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.HoverState.Parent = this.tbUsername;
            this.tbUsername.IconLeftSize = new System.Drawing.Size(30, 30);
            this.tbUsername.Location = new System.Drawing.Point(983, 185);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbUsername.PlaceholderText = "Nhập tên đăng nhập";
            this.tbUsername.SelectedText = "";
            this.tbUsername.ShadowDecoration.Parent = this.tbUsername;
            this.tbUsername.Size = new System.Drawing.Size(483, 58);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(983, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1074, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(1040, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "*";
            // 
            // tbPassword
            // 
            this.tbPassword.AutoRoundedCorners = true;
            this.tbPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPassword.BorderRadius = 28;
            this.tbPassword.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.Parent = this.tbPassword;
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.FocusedState.Parent = this.tbPassword;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.HoverState.Parent = this.tbPassword;
            this.tbPassword.Location = new System.Drawing.Point(983, 295);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbPassword.PlaceholderText = "Nhập mật khẩu";
            this.tbPassword.SelectedText = "";
            this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
            this.tbPassword.Size = new System.Drawing.Size(483, 58);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // cbxShowPassword
            // 
            this.cbxShowPassword.AutoSize = true;
            this.cbxShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.cbxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxShowPassword.FlatAppearance.BorderSize = 0;
            this.cbxShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbxShowPassword.Location = new System.Drawing.Point(983, 361);
            this.cbxShowPassword.Name = "cbxShowPassword";
            this.cbxShowPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxShowPassword.Size = new System.Drawing.Size(125, 20);
            this.cbxShowPassword.TabIndex = 17;
            this.cbxShowPassword.TabStop = false;
            this.cbxShowPassword.Text = "Hiển thị mật khẩu";
            this.cbxShowPassword.UseVisualStyleBackColor = false;
            this.cbxShowPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lForgetPassword
            // 
            this.lForgetPassword.AutoSize = true;
            this.lForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.lForgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lForgetPassword.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lForgetPassword.Location = new System.Drawing.Point(1154, 511);
            this.lForgetPassword.Name = "lForgetPassword";
            this.lForgetPassword.Size = new System.Drawing.Size(141, 20);
            this.lForgetPassword.TabIndex = 18;
            this.lForgetPassword.Text = "Quên mật khẩu?";
            // 
            // bCreateAccount
            // 
            this.bCreateAccount.AutoRoundedCorners = true;
            this.bCreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.bCreateAccount.BorderRadius = 21;
            this.bCreateAccount.CheckedState.Parent = this.bCreateAccount;
            this.bCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCreateAccount.CustomImages.Parent = this.bCreateAccount;
            this.bCreateAccount.FillColor = System.Drawing.Color.Maroon;
            this.bCreateAccount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCreateAccount.ForeColor = System.Drawing.Color.White;
            this.bCreateAccount.HoverState.Parent = this.bCreateAccount;
            this.bCreateAccount.Location = new System.Drawing.Point(1110, 536);
            this.bCreateAccount.Name = "bCreateAccount";
            this.bCreateAccount.ShadowDecoration.Parent = this.bCreateAccount;
            this.bCreateAccount.Size = new System.Drawing.Size(226, 45);
            this.bCreateAccount.TabIndex = 3;
            this.bCreateAccount.Text = "Tạo tài khoản";
            this.bCreateAccount.Click += new System.EventHandler(this.bCreateAccount_Click);
            // 
            // lNotification
            // 
            this.lNotification.AutoSize = true;
            this.lNotification.BackColor = System.Drawing.Color.Transparent;
            this.lNotification.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline);
            this.lNotification.ForeColor = System.Drawing.Color.Red;
            this.lNotification.Location = new System.Drawing.Point(983, 394);
            this.lNotification.Name = "lNotification";
            this.lNotification.Size = new System.Drawing.Size(0, 18);
            this.lNotification.TabIndex = 20;
            // 
            // fLogin
            // 
            this.AcceptButton = this.bLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1499, 761);
            this.Controls.Add(this.lNotification);
            this.Controls.Add(this.bCreateAccount);
            this.Controls.Add(this.lForgetPassword);
            this.Controls.Add(this.cbxShowPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lConnectToDeveloper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cà phê";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lConnectToDeveloper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button bLogin;
        private Guna.UI2.WinForms.Guna2TextBox tbUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private System.Windows.Forms.CheckBox cbxShowPassword;
        private System.Windows.Forms.Label lForgetPassword;
        private Guna.UI2.WinForms.Guna2Button bCreateAccount;
        private System.Windows.Forms.Label lNotification;
    }
}