namespace CoffeeShopManagement
{
    partial class fPasswordConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPasswordConfirm));
            this.lTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbxShow = new System.Windows.Forms.CheckBox();
            this.bConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.bCancel = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.Color.Transparent;
            this.lTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(24, 12);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(149, 21);
            this.lTitle.TabIndex = 5;
            this.lTitle.Text = "Xác nhận mật khẩu";
            // 
            // cbxShow
            // 
            this.cbxShow.AutoSize = true;
            this.cbxShow.BackColor = System.Drawing.Color.Transparent;
            this.cbxShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxShow.FlatAppearance.BorderSize = 0;
            this.cbxShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.cbxShow.Location = new System.Drawing.Point(569, 244);
            this.cbxShow.Name = "cbxShow";
            this.cbxShow.Size = new System.Drawing.Size(104, 17);
            this.cbxShow.TabIndex = 34;
            this.cbxShow.TabStop = false;
            this.cbxShow.Text = "Hiển thị mật khẩu";
            this.cbxShow.UseVisualStyleBackColor = false;
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
            this.bConfirm.HoverState.Parent = this.bConfirm;
            this.bConfirm.Location = new System.Drawing.Point(63, 289);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.ShadowDecoration.Parent = this.bConfirm;
            this.bConfirm.Size = new System.Drawing.Size(211, 40);
            this.bConfirm.TabIndex = 3;
            this.bConfirm.Text = "Xác nhận";
            // 
            // bCancel
            // 
            this.bCancel.AutoRoundedCorners = true;
            this.bCancel.BackColor = System.Drawing.Color.Transparent;
            this.bCancel.BorderRadius = 19;
            this.bCancel.CheckedState.Parent = this.bCancel;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.CustomImages.Parent = this.bCancel;
            this.bCancel.FillColor = System.Drawing.Color.Red;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.bCancel.HoverState.Parent = this.bCancel;
            this.bCancel.Location = new System.Drawing.Point(464, 288);
            this.bCancel.Name = "bCancel";
            this.bCancel.ShadowDecoration.Parent = this.bCancel;
            this.bCancel.Size = new System.Drawing.Size(211, 40);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Quay lại";
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(111, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(130, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "*";
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
            this.tbPassword.Location = new System.Drawing.Point(63, 207);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.PlaceholderText = "";
            this.tbPassword.SelectedText = "";
            this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
            this.tbPassword.Size = new System.Drawing.Size(612, 35);
            this.tbPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(60, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 28;
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
            this.tbUsername.Location = new System.Drawing.Point(63, 127);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PlaceholderText = "";
            this.tbUsername.SelectedText = "";
            this.tbUsername.ShadowDecoration.Parent = this.tbUsername;
            this.tbUsername.Size = new System.Drawing.Size(612, 35);
            this.tbUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(60, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tên tài khoản";
            // 
            // fPasswordConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Small_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.cbxShow);
            this.Controls.Add(this.bConfirm);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fPasswordConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cà phê";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lTitle;
        private System.Windows.Forms.CheckBox cbxShow;
        private Guna.UI2.WinForms.Guna2Button bConfirm;
        private Guna.UI2.WinForms.Guna2Button bCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbUsername;
        private System.Windows.Forms.Label label1;
    }
}