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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.lConnectToDeveloper = new System.Windows.Forms.Label();
            this.bLogin = new System.Windows.Forms.Button();
            this.lNotification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(980, 366);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(485, 55);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Text = "admin";
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.White;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(980, 242);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(485, 55);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.Text = "admin";
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.BackColor = System.Drawing.Color.White;
            this.cbShowPassword.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Vàng_nhẹ;
            this.cbShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPassword.Location = new System.Drawing.Point(979, 435);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbShowPassword.Size = new System.Drawing.Size(123, 24);
            this.cbShowPassword.TabIndex = 4;
            this.cbShowPassword.TabStop = false;
            this.cbShowPassword.Text = "Hiển thị mật khẩu";
            this.cbShowPassword.UseVisualStyleBackColor = false;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // lConnectToDeveloper
            // 
            this.lConnectToDeveloper.AutoSize = true;
            this.lConnectToDeveloper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lConnectToDeveloper.Cursor = System.Windows.Forms.Cursors.Help;
            this.lConnectToDeveloper.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lConnectToDeveloper.Image = global::CoffeeShopManagement.Properties.Resources.Frame;
            this.lConnectToDeveloper.Location = new System.Drawing.Point(19, 739);
            this.lConnectToDeveloper.Name = "lConnectToDeveloper";
            this.lConnectToDeveloper.Size = new System.Drawing.Size(141, 13);
            this.lConnectToDeveloper.TabIndex = 5;
            this.lConnectToDeveloper.Text = "@ Liên hệ với nhà phát triển";
            this.lConnectToDeveloper.Click += new System.EventHandler(this.lConnectToDeveloper_Click);
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.Color.Salmon;
            this.bLogin.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.ButtonColor;
            this.bLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bLogin.Location = new System.Drawing.Point(979, 509);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(493, 64);
            this.bLogin.TabIndex = 3;
            this.bLogin.Text = "Đăng nhập";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // lNotification
            // 
            this.lNotification.AutoSize = true;
            this.lNotification.BackColor = System.Drawing.Color.Black;
            this.lNotification.Cursor = System.Windows.Forms.Cursors.No;
            this.lNotification.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNotification.ForeColor = System.Drawing.Color.Red;
            this.lNotification.Image = global::CoffeeShopManagement.Properties.Resources.Vàng_nhẹ;
            this.lNotification.Location = new System.Drawing.Point(982, 465);
            this.lNotification.Name = "lNotification";
            this.lNotification.Size = new System.Drawing.Size(0, 22);
            this.lNotification.TabIndex = 6;
            // 
            // fLogin
            // 
            this.AcceptButton = this.bLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Login4;
            this.ClientSize = new System.Drawing.Size(1499, 761);
            this.Controls.Add(this.lNotification);
            this.Controls.Add(this.lConnectToDeveloper);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.bLogin);
            this.Name = "fLogin";
            this.Text = "Phần mềm quản lý quán cà phê";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.Label lConnectToDeveloper;
        private System.Windows.Forms.Label lNotification;
    }
}