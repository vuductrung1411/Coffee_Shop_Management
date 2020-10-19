namespace Sale
{
    partial class fChangePasswordUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAccept = new System.Windows.Forms.Button();
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lConfirm = new System.Windows.Forms.Label();
            this.lNewPassword = new System.Windows.Forms.Label();
            this.lOldPassword = new System.Windows.Forms.Label();
            this.lUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Location = new System.Drawing.Point(754, 371);
            this.Logo.Size = new System.Drawing.Size(121, 82);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bCancel);
            this.groupBox1.Controls.Add(this.bAccept);
            this.groupBox1.Controls.Add(this.tbConfirm);
            this.groupBox1.Controls.Add(this.tbNewPassword);
            this.groupBox1.Controls.Add(this.tbOldPassword);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.lConfirm);
            this.groupBox1.Controls.Add(this.lNewPassword);
            this.groupBox1.Controls.Add(this.lOldPassword);
            this.groupBox1.Controls.Add(this.lUsername);
            this.groupBox1.Location = new System.Drawing.Point(95, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đổi mật khẩu";
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(483, 210);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(135, 46);
            this.bCancel.TabIndex = 66;
            this.bCancel.Text = "Hủy";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAccept
            // 
            this.bAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAccept.Location = new System.Drawing.Point(207, 210);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(135, 46);
            this.bAccept.TabIndex = 65;
            this.bAccept.Text = "Đồng ý";
            this.bAccept.UseVisualStyleBackColor = false;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // tbConfirm
            // 
            this.tbConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirm.Location = new System.Drawing.Point(207, 170);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.Size = new System.Drawing.Size(411, 27);
            this.tbConfirm.TabIndex = 64;
            this.tbConfirm.UseSystemPasswordChar = true;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPassword.Location = new System.Drawing.Point(207, 130);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(411, 27);
            this.tbNewPassword.TabIndex = 63;
            this.tbNewPassword.UseSystemPasswordChar = true;
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOldPassword.Location = new System.Drawing.Point(207, 90);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.Size = new System.Drawing.Size(411, 27);
            this.tbOldPassword.TabIndex = 62;
            this.tbOldPassword.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(207, 50);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(411, 27);
            this.tbUsername.TabIndex = 61;
            // 
            // lConfirm
            // 
            this.lConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lConfirm.Location = new System.Drawing.Point(6, 170);
            this.lConfirm.Name = "lConfirm";
            this.lConfirm.Size = new System.Drawing.Size(195, 27);
            this.lConfirm.TabIndex = 60;
            this.lConfirm.Text = "Nhập lại mật khẩu:";
            this.lConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lNewPassword
            // 
            this.lNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNewPassword.Location = new System.Drawing.Point(41, 130);
            this.lNewPassword.Name = "lNewPassword";
            this.lNewPassword.Size = new System.Drawing.Size(160, 27);
            this.lNewPassword.TabIndex = 59;
            this.lNewPassword.Text = "Mật khẩu mới:";
            this.lNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lOldPassword
            // 
            this.lOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOldPassword.Location = new System.Drawing.Point(41, 88);
            this.lOldPassword.Name = "lOldPassword";
            this.lOldPassword.Size = new System.Drawing.Size(160, 27);
            this.lOldPassword.TabIndex = 58;
            this.lOldPassword.Text = "Mật khẩu cũ:";
            this.lOldPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lUsername
            // 
            this.lUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername.Location = new System.Drawing.Point(41, 50);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(160, 27);
            this.lUsername.TabIndex = 57;
            this.lUsername.Text = "Tên đăng nhập:";
            this.lUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(290, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 54);
            this.label1.TabIndex = 41;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // fChangePasswordUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "fChangePasswordUser";
            this.Text = "Thay đổi mật khẩu";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.Logo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lConfirm;
        private System.Windows.Forms.Label lNewPassword;
        private System.Windows.Forms.Label lOldPassword;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbConfirm;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAccept;
    }
}