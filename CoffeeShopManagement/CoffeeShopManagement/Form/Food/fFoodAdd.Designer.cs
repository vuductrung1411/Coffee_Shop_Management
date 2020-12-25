namespace CoffeeShopManagement
{
    partial class fFoodAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFoodAdd));
            this.lTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lUpload = new System.Windows.Forms.Label();
            this.pbAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bCancel = new Guna.UI2.WinForms.Guna2Button();
            this.bOK = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lNotificationFoodName = new System.Windows.Forms.Label();
            this.lNotificationPrice = new System.Windows.Forms.Label();
            this.nudPrice = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.tbUnit = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.Color.Transparent;
            this.lTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(21, 13);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(117, 21);
            this.lTitle.TabIndex = 3;
            this.lTitle.Text = "Thêm món mới";
            // 
            // lUpload
            // 
            this.lUpload.AutoSize = true;
            this.lUpload.BackColor = System.Drawing.Color.Transparent;
            this.lUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUpload.ForeColor = System.Drawing.Color.Red;
            this.lUpload.Location = new System.Drawing.Point(544, 296);
            this.lUpload.Name = "lUpload";
            this.lUpload.Size = new System.Drawing.Size(79, 18);
            this.lUpload.TabIndex = 23;
            this.lUpload.Text = "Tải ảnh lên";
            // 
            // pbAvatar
            // 
            this.pbAvatar.AutoRoundedCorners = true;
            this.pbAvatar.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Food_Avatar__Demo_;
            this.pbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAvatar.BorderRadius = 89;
            this.pbAvatar.Location = new System.Drawing.Point(495, 45);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.ShadowDecoration.Parent = this.pbAvatar;
            this.pbAvatar.Size = new System.Drawing.Size(181, 248);
            this.pbAvatar.TabIndex = 22;
            this.pbAvatar.TabStop = false;
            // 
            // bCancel
            // 
            this.bCancel.AutoRoundedCorners = true;
            this.bCancel.BackColor = System.Drawing.Color.Transparent;
            this.bCancel.BorderRadius = 21;
            this.bCancel.BorderThickness = 1;
            this.bCancel.CheckedState.Parent = this.bCancel;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.CustomImages.Parent = this.bCancel;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.FillColor = System.Drawing.Color.Red;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.bCancel.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.bCancel.HoverState.Parent = this.bCancel;
            this.bCancel.Location = new System.Drawing.Point(262, 296);
            this.bCancel.Name = "bCancel";
            this.bCancel.ShadowDecoration.Parent = this.bCancel;
            this.bCancel.Size = new System.Drawing.Size(200, 44);
            this.bCancel.TabIndex = 6;
            this.bCancel.Text = "Quay lại";
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bOK
            // 
            this.bOK.AutoRoundedCorners = true;
            this.bOK.BackColor = System.Drawing.Color.Transparent;
            this.bOK.BorderRadius = 21;
            this.bOK.BorderThickness = 1;
            this.bOK.CheckedState.Parent = this.bOK;
            this.bOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOK.CustomImages.Parent = this.bOK;
            this.bOK.FillColor = System.Drawing.Color.Chocolate;
            this.bOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOK.ForeColor = System.Drawing.Color.White;
            this.bOK.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.bOK.HoverState.Parent = this.bOK;
            this.bOK.Location = new System.Drawing.Point(35, 296);
            this.bOK.Name = "bOK";
            this.bOK.ShadowDecoration.Parent = this.bOK;
            this.bOK.Size = new System.Drawing.Size(200, 44);
            this.bOK.TabIndex = 5;
            this.bOK.Text = "Thêm";
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(74, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "*";
            // 
            // tbName
            // 
            this.tbName.AutoRoundedCorners = true;
            this.tbName.BackColor = System.Drawing.Color.Transparent;
            this.tbName.BorderColor = System.Drawing.Color.Black;
            this.tbName.BorderRadius = 19;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultText = "";
            this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.DisabledState.Parent = this.tbName;
            this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.FocusedState.Parent = this.tbName;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.HoverState.Parent = this.tbName;
            this.tbName.Location = new System.Drawing.Point(35, 73);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderText = "Tên món";
            this.tbName.SelectedText = "";
            this.tbName.ShadowDecoration.Parent = this.tbName;
            this.tbName.Size = new System.Drawing.Size(427, 40);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(32, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Đơn giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(32, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên món";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(79, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(94, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(35, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Đơn vị tính";
            // 
            // lNotificationFoodName
            // 
            this.lNotificationFoodName.AutoSize = true;
            this.lNotificationFoodName.BackColor = System.Drawing.Color.Transparent;
            this.lNotificationFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Underline);
            this.lNotificationFoodName.ForeColor = System.Drawing.Color.Red;
            this.lNotificationFoodName.Location = new System.Drawing.Point(36, 114);
            this.lNotificationFoodName.Name = "lNotificationFoodName";
            this.lNotificationFoodName.Size = new System.Drawing.Size(0, 13);
            this.lNotificationFoodName.TabIndex = 31;
            // 
            // lNotificationPrice
            // 
            this.lNotificationPrice.AutoSize = true;
            this.lNotificationPrice.BackColor = System.Drawing.Color.Transparent;
            this.lNotificationPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Underline);
            this.lNotificationPrice.ForeColor = System.Drawing.Color.Red;
            this.lNotificationPrice.Location = new System.Drawing.Point(35, 196);
            this.lNotificationPrice.Name = "lNotificationPrice";
            this.lNotificationPrice.Size = new System.Drawing.Size(0, 13);
            this.lNotificationPrice.TabIndex = 32;
            // 
            // nudPrice
            // 
            this.nudPrice.AutoRoundedCorners = true;
            this.nudPrice.BackColor = System.Drawing.Color.Transparent;
            this.nudPrice.BorderColor = System.Drawing.Color.Black;
            this.nudPrice.BorderRadius = 19;
            this.nudPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudPrice.DisabledState.Parent = this.nudPrice;
            this.nudPrice.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudPrice.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudPrice.FocusedState.Parent = this.nudPrice;
            this.nudPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nudPrice.ForeColor = System.Drawing.Color.Black;
            this.nudPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrice.Location = new System.Drawing.Point(35, 153);
            this.nudPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudPrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.ShadowDecoration.Parent = this.nudPrice;
            this.nudPrice.Size = new System.Drawing.Size(427, 40);
            this.nudPrice.TabIndex = 2;
            this.nudPrice.UseTransparentBackground = true;
            // 
            // tbUnit
            // 
            this.tbUnit.AutoRoundedCorners = true;
            this.tbUnit.BackColor = System.Drawing.Color.Transparent;
            this.tbUnit.BorderColor = System.Drawing.Color.Black;
            this.tbUnit.BorderRadius = 19;
            this.tbUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUnit.DefaultText = "";
            this.tbUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUnit.DisabledState.Parent = this.tbUnit;
            this.tbUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUnit.FocusedState.Parent = this.tbUnit;
            this.tbUnit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbUnit.ForeColor = System.Drawing.Color.Black;
            this.tbUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUnit.HoverState.Parent = this.tbUnit;
            this.tbUnit.Location = new System.Drawing.Point(38, 233);
            this.tbUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.PasswordChar = '\0';
            this.tbUnit.PlaceholderText = "Ví dụ: lít, ly, cốc, đĩa, tô,...";
            this.tbUnit.SelectedText = "";
            this.tbUnit.ShadowDecoration.Parent = this.tbUnit;
            this.tbUnit.Size = new System.Drawing.Size(424, 40);
            this.tbUnit.TabIndex = 4;
            // 
            // fFoodAdd
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Small_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.lNotificationPrice);
            this.Controls.Add(this.lNotificationFoodName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbUnit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lUpload);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fFoodAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lTitle;
        private System.Windows.Forms.Label lUpload;
        private Guna.UI2.WinForms.Guna2PictureBox pbAvatar;
        private Guna.UI2.WinForms.Guna2Button bCancel;
        private Guna.UI2.WinForms.Guna2Button bOK;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lNotificationFoodName;
        private System.Windows.Forms.Label lNotificationPrice;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudPrice;
        private Guna.UI2.WinForms.Guna2TextBox tbUnit;
    }
}