namespace CoffeeShopManagement
{
    partial class fAccountAdd
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
            this.lTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.bCancel = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbConfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxShow1 = new System.Windows.Forms.CheckBox();
            this.cbxShow2 = new System.Windows.Forms.CheckBox();
            this.lNotificationUsername = new System.Windows.Forms.Label();
            this.lNotificationConfirmPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.Color.Transparent;
            this.lTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lTitle.Location = new System.Drawing.Point(19, 13);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(139, 21);
            this.lTitle.TabIndex = 101;
            this.lTitle.Text = "Tạo tài khoản mới";
            // 
            // bConfirm
            // 
            this.bConfirm.AutoRoundedCorners = true;
            this.bConfirm.BackColor = System.Drawing.Color.Transparent;
            this.bConfirm.BorderRadius = 19;
            this.bConfirm.CheckedState.Parent = this.bConfirm;
            this.bConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bConfirm.CustomImages.Parent = this.bConfirm;
            this.bConfirm.FillColor = System.Drawing.Color.DarkTurquoise;
            this.bConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConfirm.ForeColor = System.Drawing.SystemColors.Window;
            this.bConfirm.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.bConfirm.HoverState.Parent = this.bConfirm;
            this.bConfirm.Location = new System.Drawing.Point(42, 290);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.ShadowDecoration.Parent = this.bConfirm;
            this.bConfirm.Size = new System.Drawing.Size(211, 40);
            this.bConfirm.TabIndex = 4;
            this.bConfirm.Text = "Xác nhận";
            this.bConfirm.Click += new System.EventHandler(this.bConfirm_Click);
            // 
            // bCancel
            // 
            this.bCancel.AutoRoundedCorners = true;
            this.bCancel.BackColor = System.Drawing.Color.Transparent;
            this.bCancel.BorderRadius = 19;
            this.bCancel.CheckedState.Parent = this.bCancel;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.CustomImages.Parent = this.bCancel;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.FillColor = System.Drawing.Color.Red;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.bCancel.HoverState.Parent = this.bCancel;
            this.bCancel.Location = new System.Drawing.Point(443, 290);
            this.bCancel.Name = "bCancel";
            this.bCancel.ShadowDecoration.Parent = this.bCancel;
            this.bCancel.Size = new System.Drawing.Size(211, 40);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Quay lại";
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(136, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 110;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(89, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 109;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(117, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 108;
            this.label4.Text = "*";
            // 
            // tbConfirm
            // 
            this.tbConfirm.AutoRoundedCorners = true;
            this.tbConfirm.BackColor = System.Drawing.Color.Transparent;
            this.tbConfirm.BorderColor = System.Drawing.Color.Black;
            this.tbConfirm.BorderRadius = 16;
            this.tbConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirm.DefaultText = "";
            this.tbConfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfirm.DisabledState.Parent = this.tbConfirm;
            this.tbConfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfirm.FocusedState.Parent = this.tbConfirm;
            this.tbConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbConfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfirm.HoverState.Parent = this.tbConfirm;
            this.tbConfirm.Location = new System.Drawing.Point(42, 222);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.PasswordChar = '\0';
            this.tbConfirm.PlaceholderText = "";
            this.tbConfirm.SelectedText = "";
            this.tbConfirm.ShadowDecoration.Parent = this.tbConfirm;
            this.tbConfirm.Size = new System.Drawing.Size(612, 35);
            this.tbConfirm.TabIndex = 3;
            this.tbConfirm.UseSystemPasswordChar = true;
            this.tbConfirm.TextChanged += new System.EventHandler(this.tbConfirm_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(39, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // tbPassword
            // 
            this.tbPassword.AutoRoundedCorners = true;
            this.tbPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbPassword.BorderColor = System.Drawing.Color.Black;
            this.tbPassword.BorderRadius = 16;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.Parent = this.tbPassword;
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.FocusedState.Parent = this.tbPassword;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.HoverState.Parent = this.tbPassword;
            this.tbPassword.Location = new System.Drawing.Point(42, 142);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.PlaceholderText = "";
            this.tbPassword.SelectedText = "";
            this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
            this.tbPassword.Size = new System.Drawing.Size(612, 35);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(39, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Mật khẩu";
            // 
            // tbUsername
            // 
            this.tbUsername.AutoRoundedCorners = true;
            this.tbUsername.BackColor = System.Drawing.Color.Transparent;
            this.tbUsername.BorderColor = System.Drawing.Color.Black;
            this.tbUsername.BorderRadius = 16;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.DefaultText = "";
            this.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.DisabledState.Parent = this.tbUsername;
            this.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.FocusedState.Parent = this.tbUsername;
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.HoverState.Parent = this.tbUsername;
            this.tbUsername.Location = new System.Drawing.Point(42, 62);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PlaceholderText = "";
            this.tbUsername.SelectedText = "";
            this.tbUsername.ShadowDecoration.Parent = this.tbUsername;
            this.tbUsername.Size = new System.Drawing.Size(612, 35);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(39, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = "Tên đăng nhập";
            // 
            // cbxShow1
            // 
            this.cbxShow1.AutoSize = true;
            this.cbxShow1.BackColor = System.Drawing.Color.Transparent;
            this.cbxShow1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxShow1.FlatAppearance.BorderSize = 0;
            this.cbxShow1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxShow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.cbxShow1.Location = new System.Drawing.Point(550, 180);
            this.cbxShow1.Name = "cbxShow1";
            this.cbxShow1.Size = new System.Drawing.Size(104, 17);
            this.cbxShow1.TabIndex = 113;
            this.cbxShow1.TabStop = false;
            this.cbxShow1.Text = "Hiển thị mật khẩu";
            this.cbxShow1.UseVisualStyleBackColor = false;
            this.cbxShow1.CheckedChanged += new System.EventHandler(this.cbxShow1_CheckedChanged);
            // 
            // cbxShow2
            // 
            this.cbxShow2.AutoSize = true;
            this.cbxShow2.BackColor = System.Drawing.Color.Transparent;
            this.cbxShow2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxShow2.FlatAppearance.BorderSize = 0;
            this.cbxShow2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxShow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.cbxShow2.Location = new System.Drawing.Point(550, 259);
            this.cbxShow2.Name = "cbxShow2";
            this.cbxShow2.Size = new System.Drawing.Size(104, 17);
            this.cbxShow2.TabIndex = 114;
            this.cbxShow2.TabStop = false;
            this.cbxShow2.Text = "Hiển thị mật khẩu";
            this.cbxShow2.UseVisualStyleBackColor = false;
            this.cbxShow2.CheckedChanged += new System.EventHandler(this.cbxShow2_CheckedChanged);
            // 
            // lNotificationUsername
            // 
            this.lNotificationUsername.AutoSize = true;
            this.lNotificationUsername.BackColor = System.Drawing.Color.Transparent;
            this.lNotificationUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Underline);
            this.lNotificationUsername.ForeColor = System.Drawing.Color.Red;
            this.lNotificationUsername.Location = new System.Drawing.Point(39, 100);
            this.lNotificationUsername.Name = "lNotificationUsername";
            this.lNotificationUsername.Size = new System.Drawing.Size(0, 13);
            this.lNotificationUsername.TabIndex = 115;
            // 
            // lNotificationConfirmPassword
            // 
            this.lNotificationConfirmPassword.AutoSize = true;
            this.lNotificationConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lNotificationConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Underline);
            this.lNotificationConfirmPassword.ForeColor = System.Drawing.Color.Red;
            this.lNotificationConfirmPassword.Location = new System.Drawing.Point(39, 260);
            this.lNotificationConfirmPassword.Name = "lNotificationConfirmPassword";
            this.lNotificationConfirmPassword.Size = new System.Drawing.Size(0, 13);
            this.lNotificationConfirmPassword.TabIndex = 116;
            // 
            // fAccountAdd
            // 
            this.AcceptButton = this.bConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Small_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.lNotificationConfirmPassword);
            this.Controls.Add(this.lNotificationUsername);
            this.Controls.Add(this.cbxShow2);
            this.Controls.Add(this.cbxShow1);
            this.Controls.Add(this.bConfirm);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lTitle);
            this.Name = "fAccountAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cà phê";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lTitle;
        private Guna.UI2.WinForms.Guna2Button bConfirm;
        private Guna.UI2.WinForms.Guna2Button bCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbConfirm;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxShow1;
        private System.Windows.Forms.CheckBox cbxShow2;
        private System.Windows.Forms.Label lNotificationUsername;
        private System.Windows.Forms.Label lNotificationConfirmPassword;
    }
}