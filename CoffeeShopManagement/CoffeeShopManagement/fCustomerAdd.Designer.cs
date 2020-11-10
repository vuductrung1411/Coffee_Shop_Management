namespace CoffeeShopManagement
{
    partial class fCustomerAdd
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
            this.bAdd = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.lChangeAvatar = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbMember = new System.Windows.Forms.ComboBox();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.DarkTurquoise;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(128, 560);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(304, 62);
            this.bAdd.TabIndex = 13;
            this.bAdd.Text = "Thêm ";
            this.bAdd.UseVisualStyleBackColor = false;
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Red;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(693, 560);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(304, 62);
            this.bCancel.TabIndex = 14;
            this.bCancel.Text = "Quay lại";
            this.bCancel.UseVisualStyleBackColor = false;
            // 
            // lChangeAvatar
            // 
            this.lChangeAvatar.AutoSize = true;
            this.lChangeAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lChangeAvatar.ForeColor = System.Drawing.Color.Red;
            this.lChangeAvatar.Image = global::CoffeeShopManagement.Properties.Resources.Vàng_nhẹ;
            this.lChangeAvatar.Location = new System.Drawing.Point(1238, 542);
            this.lChangeAvatar.Name = "lChangeAvatar";
            this.lChangeAvatar.Size = new System.Drawing.Size(132, 29);
            this.lChangeAvatar.TabIndex = 15;
            this.lChangeAvatar.Text = "Tải ảnh lên";
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = global::CoffeeShopManagement.Properties.Resources.avatar_demo;
            this.pbAvatar.Location = new System.Drawing.Point(1155, 128);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(295, 404);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 16;
            this.pbAvatar.TabStop = false;
            // 
            // tbSDT
            // 
            this.tbSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDT.Location = new System.Drawing.Point(57, 140);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(486, 37);
            this.tbSDT.TabIndex = 17;
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(57, 251);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(486, 37);
            this.tbName.TabIndex = 18;
            // 
            // cbMember
            // 
            this.cbMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMember.FormattingEnabled = true;
            this.cbMember.Location = new System.Drawing.Point(56, 362);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(486, 45);
            this.cbMember.TabIndex = 19;
            // 
            // tbIndex
            // 
            this.tbIndex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIndex.Location = new System.Drawing.Point(612, 140);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(472, 37);
            this.tbIndex.TabIndex = 20;
            // 
            // cbSex
            // 
            this.cbSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(611, 361);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(478, 45);
            this.cbSex.TabIndex = 21;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(610, 248);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(480, 47);
            this.dtpBirthday.TabIndex = 22;
            // 
            // fCustomerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.AddCustomer1;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.tbIndex);
            this.Controls.Add(this.cbMember);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.lChangeAvatar);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Name = "fCustomerAdd";
            this.Text = "Phần mềm quản lý quán cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lChangeAvatar;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbMember;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
    }
}