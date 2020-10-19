namespace Coffee_Shop_Management
{
    partial class fChangeInfoUser
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
            this.lChangeInfoUser_title = new System.Windows.Forms.Label();
            this.gbChangeInfo = new System.Windows.Forms.GroupBox();
            this.gbConfirm = new System.Windows.Forms.GroupBox();
            this.bAccept = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.lUsername = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.tbStaffIndex = new System.Windows.Forms.TextBox();
            this.lStaffIndex = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.lPosition = new System.Windows.Forms.Label();
            this.lSalary = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.lSDT = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lAddress = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.lSex = new System.Windows.Forms.Label();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.lCMND = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.gbChangeInfo.SuspendLayout();
            this.gbConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Location = new System.Drawing.Point(840, 422);
            this.Logo.Size = new System.Drawing.Size(137, 84);
            // 
            // lChangeInfoUser_title
            // 
            this.lChangeInfoUser_title.AutoSize = true;
            this.lChangeInfoUser_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lChangeInfoUser_title.Location = new System.Drawing.Point(164, 25);
            this.lChangeInfoUser_title.Name = "lChangeInfoUser_title";
            this.lChangeInfoUser_title.Size = new System.Drawing.Size(621, 54);
            this.lChangeInfoUser_title.TabIndex = 62;
            this.lChangeInfoUser_title.Text = "Thay đổi thông tin tài khoản";
            // 
            // gbChangeInfo
            // 
            this.gbChangeInfo.Controls.Add(this.gbConfirm);
            this.gbChangeInfo.Controls.Add(this.tbStaffIndex);
            this.gbChangeInfo.Controls.Add(this.lStaffIndex);
            this.gbChangeInfo.Controls.Add(this.cbPosition);
            this.gbChangeInfo.Controls.Add(this.lPosition);
            this.gbChangeInfo.Controls.Add(this.lSalary);
            this.gbChangeInfo.Controls.Add(this.tbSalary);
            this.gbChangeInfo.Controls.Add(this.lSDT);
            this.gbChangeInfo.Controls.Add(this.tbSDT);
            this.gbChangeInfo.Controls.Add(this.tbAddress);
            this.gbChangeInfo.Controls.Add(this.lAddress);
            this.gbChangeInfo.Controls.Add(this.cbSex);
            this.gbChangeInfo.Controls.Add(this.lSex);
            this.gbChangeInfo.Controls.Add(this.tbCMND);
            this.gbChangeInfo.Controls.Add(this.tbName);
            this.gbChangeInfo.Controls.Add(this.lName);
            this.gbChangeInfo.Controls.Add(this.lCMND);
            this.gbChangeInfo.Location = new System.Drawing.Point(91, 82);
            this.gbChangeInfo.Name = "gbChangeInfo";
            this.gbChangeInfo.Size = new System.Drawing.Size(743, 368);
            this.gbChangeInfo.TabIndex = 63;
            this.gbChangeInfo.TabStop = false;
            this.gbChangeInfo.Text = "Thay đổi thông tin";
            // 
            // gbConfirm
            // 
            this.gbConfirm.Controls.Add(this.bAccept);
            this.gbConfirm.Controls.Add(this.tbUsername);
            this.gbConfirm.Controls.Add(this.tbPassword);
            this.gbConfirm.Controls.Add(this.lPassword);
            this.gbConfirm.Controls.Add(this.bCancel);
            this.gbConfirm.Controls.Add(this.lUsername);
            this.gbConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConfirm.ForeColor = System.Drawing.Color.Green;
            this.gbConfirm.Location = new System.Drawing.Point(41, 194);
            this.gbConfirm.Name = "gbConfirm";
            this.gbConfirm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbConfirm.Size = new System.Drawing.Size(660, 166);
            this.gbConfirm.TabIndex = 69;
            this.gbConfirm.TabStop = false;
            this.gbConfirm.Text = "Nhập thông tin tài khoản và mật khẩu để xác nhận";
            // 
            // bAccept
            // 
            this.bAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAccept.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bAccept.Location = new System.Drawing.Point(177, 96);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(135, 46);
            this.bAccept.TabIndex = 10;
            this.bAccept.Text = "Đồng ý";
            this.bAccept.UseVisualStyleBackColor = false;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(177, 30);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(450, 27);
            this.tbUsername.TabIndex = 7;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(177, 63);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(450, 27);
            this.tbPassword.TabIndex = 8;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lPassword
            // 
            this.lPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPassword.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lPassword.Location = new System.Drawing.Point(13, 63);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(158, 27);
            this.lPassword.TabIndex = 47;
            this.lPassword.Text = "Mật khẩu:";
            this.lPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lUsername
            // 
            this.lUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsername.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lUsername.Location = new System.Drawing.Point(6, 28);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(165, 27);
            this.lUsername.TabIndex = 52;
            this.lUsername.Text = "Tên đăng nhập:";
            this.lUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bCancel.Location = new System.Drawing.Point(492, 96);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(135, 46);
            this.bCancel.TabIndex = 11;
            this.bCancel.Text = "Hủy";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // tbStaffIndex
            // 
            this.tbStaffIndex.Enabled = false;
            this.tbStaffIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStaffIndex.HideSelection = false;
            this.tbStaffIndex.Location = new System.Drawing.Point(522, 159);
            this.tbStaffIndex.Name = "tbStaffIndex";
            this.tbStaffIndex.Size = new System.Drawing.Size(146, 27);
            this.tbStaffIndex.TabIndex = 68;
            this.tbStaffIndex.Text = "NV0013";
            // 
            // lStaffIndex
            // 
            this.lStaffIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStaffIndex.Location = new System.Drawing.Point(428, 162);
            this.lStaffIndex.Name = "lStaffIndex";
            this.lStaffIndex.Size = new System.Drawing.Size(97, 27);
            this.lStaffIndex.TabIndex = 67;
            this.lStaffIndex.Text = "Mã NV:";
            this.lStaffIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbPosition
            // 
            this.cbPosition.DisplayMember = "Bảo vệ";
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.IntegralHeight = false;
            this.cbPosition.Items.AddRange(new object[] {
            "Thu ngân",
            "Phục vụ",
            "Bảo vệ",
            "Chế biến"});
            this.cbPosition.Location = new System.Drawing.Point(522, 92);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(146, 28);
            this.cbPosition.TabIndex = 4;
            // 
            // lPosition
            // 
            this.lPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPosition.Location = new System.Drawing.Point(428, 92);
            this.lPosition.Name = "lPosition";
            this.lPosition.Size = new System.Drawing.Size(97, 27);
            this.lPosition.TabIndex = 65;
            this.lPosition.Text = "Chức vụ:";
            this.lPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSalary
            // 
            this.lSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSalary.Location = new System.Drawing.Point(76, 159);
            this.lSalary.Name = "lSalary";
            this.lSalary.Size = new System.Drawing.Size(136, 27);
            this.lSalary.TabIndex = 64;
            this.lSalary.Text = "Lương:";
            this.lSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSalary
            // 
            this.tbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalary.Location = new System.Drawing.Point(218, 159);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(202, 27);
            this.tbSalary.TabIndex = 6;
            // 
            // lSDT
            // 
            this.lSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSDT.Location = new System.Drawing.Point(76, 92);
            this.lSDT.Name = "lSDT";
            this.lSDT.Size = new System.Drawing.Size(136, 27);
            this.lSDT.TabIndex = 62;
            this.lSDT.Text = "SDT:";
            this.lSDT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSDT
            // 
            this.tbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDT.Location = new System.Drawing.Point(218, 92);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(204, 27);
            this.tbSDT.TabIndex = 3;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(218, 126);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(450, 27);
            this.tbAddress.TabIndex = 5;
            // 
            // lAddress
            // 
            this.lAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAddress.Location = new System.Drawing.Point(76, 126);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(136, 27);
            this.lAddress.TabIndex = 59;
            this.lAddress.Text = "Địa chỉ:";
            this.lAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbSex.Location = new System.Drawing.Point(522, 58);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(146, 28);
            this.cbSex.TabIndex = 2;
            // 
            // lSex
            // 
            this.lSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSex.Location = new System.Drawing.Point(422, 59);
            this.lSex.Name = "lSex";
            this.lSex.Size = new System.Drawing.Size(103, 27);
            this.lSex.TabIndex = 57;
            this.lSex.Text = "Giới Tính:";
            this.lSex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCMND
            // 
            this.tbCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCMND.Location = new System.Drawing.Point(218, 59);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(204, 27);
            this.tbCMND.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(218, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(450, 27);
            this.tbName.TabIndex = 0;
            // 
            // lName
            // 
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(52, 25);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(160, 27);
            this.lName.TabIndex = 56;
            this.lName.Text = "Tên nhân viên:";
            this.lName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lCMND
            // 
            this.lCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCMND.Location = new System.Drawing.Point(76, 59);
            this.lCMND.Name = "lCMND";
            this.lCMND.Size = new System.Drawing.Size(136, 27);
            this.lCMND.TabIndex = 54;
            this.lCMND.Text = "Số CMMD:";
            this.lCMND.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fChangeInfoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 506);
            this.Controls.Add(this.gbChangeInfo);
            this.Controls.Add(this.lChangeInfoUser_title);
            this.Name = "fChangeInfoUser";
            this.Text = "Thay đổi thông tin tài khoản";
            this.Controls.SetChildIndex(this.lChangeInfoUser_title, 0);
            this.Controls.SetChildIndex(this.Logo, 0);
            this.Controls.SetChildIndex(this.gbChangeInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.gbChangeInfo.ResumeLayout(false);
            this.gbChangeInfo.PerformLayout();
            this.gbConfirm.ResumeLayout(false);
            this.gbConfirm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lChangeInfoUser_title;
        private System.Windows.Forms.GroupBox gbChangeInfo;
        private System.Windows.Forms.TextBox tbStaffIndex;
        private System.Windows.Forms.Label lStaffIndex;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label lPosition;
        private System.Windows.Forms.Label lSalary;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label lSDT;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label lSex;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lCMND;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.GroupBox gbConfirm;
    }
}