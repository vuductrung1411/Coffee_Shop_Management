namespace CoffeeShopManagement
{
    partial class fStaffInfo
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
            this.bChangePassword = new System.Windows.Forms.Button();
            this.lEditStaffName = new System.Windows.Forms.Label();
            this.tbStaffName = new System.Windows.Forms.TextBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.tbStaffSearch = new System.Windows.Forms.TextBox();
            this.tbStaffSDT = new System.Windows.Forms.TextBox();
            this.tbIndexOfStaff = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.lChangeAvatar = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.bSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // bChangePassword
            // 
            this.bChangePassword.BackColor = System.Drawing.Color.Peru;
            this.bChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bChangePassword.Location = new System.Drawing.Point(325, 326);
            this.bChangePassword.Name = "bChangePassword";
            this.bChangePassword.Size = new System.Drawing.Size(282, 38);
            this.bChangePassword.TabIndex = 17;
            this.bChangePassword.Text = "Thay đổi mật khẩu";
            this.bChangePassword.UseVisualStyleBackColor = false;
            this.bChangePassword.Click += new System.EventHandler(this.bChangePassword_Click);
            // 
            // lEditStaffName
            // 
            this.lEditStaffName.AutoSize = true;
            this.lEditStaffName.BackColor = System.Drawing.Color.White;
            this.lEditStaffName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEditStaffName.ForeColor = System.Drawing.Color.Red;
            this.lEditStaffName.Location = new System.Drawing.Point(1242, 446);
            this.lEditStaffName.Name = "lEditStaffName";
            this.lEditStaffName.Size = new System.Drawing.Size(172, 22);
            this.lEditStaffName.TabIndex = 16;
            this.lEditStaffName.Text = "Chỉnh sửa thông tin";
            // 
            // tbStaffName
            // 
            this.tbStaffName.BackColor = System.Drawing.Color.White;
            this.tbStaffName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStaffName.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStaffName.Location = new System.Drawing.Point(325, 234);
            this.tbStaffName.Name = "tbStaffName";
            this.tbStaffName.ReadOnly = true;
            this.tbStaffName.Size = new System.Drawing.Size(888, 56);
            this.tbStaffName.TabIndex = 15;
            this.tbStaffName.TabStop = false;
            this.tbStaffName.Text = "ABC DEF";
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = global::CoffeeShopManagement.Properties.Resources.avatar_demo;
            this.pbAvatar.Location = new System.Drawing.Point(76, 114);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(207, 250);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 14;
            this.pbAvatar.TabStop = false;
            // 
            // tbStaffSearch
            // 
            this.tbStaffSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStaffSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStaffSearch.Location = new System.Drawing.Point(770, 135);
            this.tbStaffSearch.Name = "tbStaffSearch";
            this.tbStaffSearch.Size = new System.Drawing.Size(529, 50);
            this.tbStaffSearch.TabIndex = 18;
            // 
            // tbStaffSDT
            // 
            this.tbStaffSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStaffSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStaffSDT.Location = new System.Drawing.Point(63, 518);
            this.tbStaffSDT.Name = "tbStaffSDT";
            this.tbStaffSDT.Size = new System.Drawing.Size(302, 24);
            this.tbStaffSDT.TabIndex = 19;
            // 
            // tbIndexOfStaff
            // 
            this.tbIndexOfStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIndexOfStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIndexOfStaff.Location = new System.Drawing.Point(63, 603);
            this.tbIndexOfStaff.Name = "tbIndexOfStaff";
            this.tbIndexOfStaff.Size = new System.Drawing.Size(302, 24);
            this.tbIndexOfStaff.TabIndex = 20;
            // 
            // tbSalary
            // 
            this.tbSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalary.Location = new System.Drawing.Point(459, 518);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(302, 24);
            this.tbSalary.TabIndex = 22;
            // 
            // tbCMND
            // 
            this.tbCMND.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCMND.Location = new System.Drawing.Point(459, 602);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(302, 24);
            this.tbCMND.TabIndex = 23;
            // 
            // tbAddress
            // 
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(854, 518);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(302, 24);
            this.tbAddress.TabIndex = 25;
            // 
            // cbSex
            // 
            this.cbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbSex.Location = new System.Drawing.Point(857, 687);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(299, 32);
            this.cbSex.TabIndex = 26;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(857, 598);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(299, 29);
            this.dtpDateOfBirth.TabIndex = 27;
            // 
            // cbPosition
            // 
            this.cbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(63, 687);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(302, 32);
            this.cbPosition.TabIndex = 28;
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.Color.Aqua;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Location = new System.Drawing.Point(1239, 503);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(175, 44);
            this.bSave.TabIndex = 30;
            this.bSave.Text = "Lưu";
            this.bSave.UseVisualStyleBackColor = false;
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Red;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.ForeColor = System.Drawing.Color.Cornsilk;
            this.bExit.Location = new System.Drawing.Point(1239, 680);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(175, 44);
            this.bExit.TabIndex = 31;
            this.bExit.Text = "Thoát";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Location = new System.Drawing.Point(1239, 590);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(175, 44);
            this.bDelete.TabIndex = 32;
            this.bDelete.Text = "Xóa nhân viên này";
            this.bDelete.UseVisualStyleBackColor = false;
            // 
            // lChangeAvatar
            // 
            this.lChangeAvatar.AutoSize = true;
            this.lChangeAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lChangeAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lChangeAvatar.ForeColor = System.Drawing.Color.Red;
            this.lChangeAvatar.Image = global::CoffeeShopManagement.Properties.Resources.Đậm_hơn_màu_trắng_1_chút_xíu;
            this.lChangeAvatar.Location = new System.Drawing.Point(126, 369);
            this.lChangeAvatar.Name = "lChangeAvatar";
            this.lChangeAvatar.Size = new System.Drawing.Size(86, 20);
            this.lChangeAvatar.TabIndex = 33;
            this.lChangeAvatar.Text = "Tải ảnh lên";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(459, 689);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(299, 29);
            this.dtpBirthday.TabIndex = 34;
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Location = new System.Drawing.Point(1321, 126);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(113, 70);
            this.bSearch.TabIndex = 35;
            this.bSearch.Text = "Tìm kiếm!";
            this.bSearch.UseVisualStyleBackColor = false;
            // 
            // fStaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.StaffInfo2;
            this.ClientSize = new System.Drawing.Size(1484, 783);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.lChangeAvatar);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbCMND);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbIndexOfStaff);
            this.Controls.Add(this.tbStaffSDT);
            this.Controls.Add(this.tbStaffSearch);
            this.Controls.Add(this.bChangePassword);
            this.Controls.Add(this.lEditStaffName);
            this.Controls.Add(this.tbStaffName);
            this.Controls.Add(this.pbAvatar);
            this.Name = "fStaffInfo";
            this.Text = "Phần mềm quản lý quán cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bChangePassword;
        private System.Windows.Forms.Label lEditStaffName;
        private System.Windows.Forms.TextBox tbStaffName;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.TextBox tbStaffSearch;
        private System.Windows.Forms.TextBox tbStaffSDT;
        private System.Windows.Forms.TextBox tbIndexOfStaff;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Label lChangeAvatar;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Button bSearch;
    }
}