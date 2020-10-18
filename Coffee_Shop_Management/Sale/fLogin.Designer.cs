namespace Coffee_Shop_Management
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
            this.bCancel = new System.Windows.Forms.Button();
            this.bLogin = new System.Windows.Forms.Button();
            this.lPassword = new System.Windows.Forms.Label();
            this.lUsername = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.bgLogin = new System.Windows.Forms.GroupBox();
            this.lbLogin_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.bgLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Location = new System.Drawing.Point(650, 302);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(379, 149);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(140, 46);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Hủy";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.Location = new System.Drawing.Point(198, 149);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(141, 46);
            this.bLogin.TabIndex = 2;
            this.bLogin.Text = "Đăng nhập";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // lPassword
            // 
            this.lPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPassword.Location = new System.Drawing.Point(74, 96);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(118, 27);
            this.lPassword.TabIndex = 42;
            this.lPassword.Text = "Mật khẩu:";
            this.lPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lUsername
            // 
            this.lUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername.Location = new System.Drawing.Point(23, 43);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(169, 27);
            this.lUsername.TabIndex = 41;
            this.lUsername.Text = "Tên đăng nhập:";
            this.lUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(198, 96);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(321, 27);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(198, 45);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(321, 27);
            this.tbUsername.TabIndex = 0;
            // 
            // bgLogin
            // 
            this.bgLogin.Controls.Add(this.bCancel);
            this.bgLogin.Controls.Add(this.lUsername);
            this.bgLogin.Controls.Add(this.bLogin);
            this.bgLogin.Controls.Add(this.tbUsername);
            this.bgLogin.Controls.Add(this.tbPassword);
            this.bgLogin.Controls.Add(this.lPassword);
            this.bgLogin.Location = new System.Drawing.Point(153, 124);
            this.bgLogin.Name = "bgLogin";
            this.bgLogin.Size = new System.Drawing.Size(548, 230);
            this.bgLogin.TabIndex = 45;
            this.bgLogin.TabStop = false;
            this.bgLogin.Text = "Đăng nhập";
            // 
            // lbLogin_title
            // 
            this.lbLogin_title.AutoSize = true;
            this.lbLogin_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin_title.Location = new System.Drawing.Point(299, 39);
            this.lbLogin_title.Name = "lbLogin_title";
            this.lbLogin_title.Size = new System.Drawing.Size(260, 54);
            this.lbLogin_title.TabIndex = 46;
            this.lbLogin_title.Text = "Đăng nhập";
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.lbLogin_title);
            this.Controls.Add(this.bgLogin);
            this.Name = "fLogin";
            this.Text = "Đăng nhập";
            this.Controls.SetChildIndex(this.Logo, 0);
            this.Controls.SetChildIndex(this.bgLogin, 0);
            this.Controls.SetChildIndex(this.lbLogin_title, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.bgLogin.ResumeLayout(false);
            this.bgLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.GroupBox bgLogin;
        private System.Windows.Forms.Label lbLogin_title;
    }
}