namespace CoffeeShopManagement
{
    partial class fStockAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStockAdd));
            this.lTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bCancel = new Guna.UI2.WinForms.Guna2Button();
            this.bOK = new Guna.UI2.WinForms.Guna2Button();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCountry = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lUpload = new System.Windows.Forms.Label();
            this.tbProvider = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dtpHSD = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPrice = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudSL = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.Color.Transparent;
            this.lTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lTitle.Location = new System.Drawing.Point(32, 24);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(154, 24);
            this.lTitle.TabIndex = 5;
            this.lTitle.Text = "Nhập thêm hàng";
            // 
            // bCancel
            // 
            this.bCancel.AutoRoundedCorners = true;
            this.bCancel.BackColor = System.Drawing.Color.Transparent;
            this.bCancel.BorderRadius = 19;
            this.bCancel.BorderThickness = 1;
            this.bCancel.CheckedState.Parent = this.bCancel;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.CustomImages.Parent = this.bCancel;
            this.bCancel.FillColor = System.Drawing.Color.Red;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.bCancel.HoverState.Parent = this.bCancel;
            this.bCancel.Location = new System.Drawing.Point(624, 458);
            this.bCancel.Name = "bCancel";
            this.bCancel.ShadowDecoration.Parent = this.bCancel;
            this.bCancel.Size = new System.Drawing.Size(140, 40);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "Quay lại";
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bOK
            // 
            this.bOK.AutoRoundedCorners = true;
            this.bOK.BackColor = System.Drawing.Color.Transparent;
            this.bOK.BorderRadius = 19;
            this.bOK.BorderThickness = 1;
            this.bOK.CheckedState.Parent = this.bOK;
            this.bOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOK.CustomImages.Parent = this.bOK;
            this.bOK.FillColor = System.Drawing.Color.Chocolate;
            this.bOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOK.ForeColor = System.Drawing.Color.White;
            this.bOK.HoverState.Parent = this.bOK;
            this.bOK.Location = new System.Drawing.Point(464, 458);
            this.bOK.Name = "bOK";
            this.bOK.ShadowDecoration.Parent = this.bOK;
            this.bOK.Size = new System.Drawing.Size(140, 40);
            this.bOK.TabIndex = 6;
            this.bOK.Text = "Thêm";
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.AutoRoundedCorners = true;
            this.dtpDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpDate.BorderRadius = 17;
            this.dtpDate.BorderThickness = 1;
            this.dtpDate.CheckedState.Parent = this.dtpDate;
            this.dtpDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDate.FillColor = System.Drawing.Color.White;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDate.HoverState.Parent = this.dtpDate;
            this.dtpDate.Location = new System.Drawing.Point(32, 399);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShadowDecoration.Parent = this.dtpDate;
            this.dtpDate.Size = new System.Drawing.Size(400, 36);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.Value = new System.DateTime(2020, 11, 27, 0, 44, 52, 352);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(32, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ngày nhập hàng";
            // 
            // tbCountry
            // 
            this.tbCountry.AutoRoundedCorners = true;
            this.tbCountry.BackColor = System.Drawing.Color.Transparent;
            this.tbCountry.BorderColor = System.Drawing.Color.Black;
            this.tbCountry.BorderRadius = 17;
            this.tbCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCountry.DefaultText = "";
            this.tbCountry.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCountry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCountry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCountry.DisabledState.Parent = this.tbCountry;
            this.tbCountry.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCountry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCountry.FocusedState.Parent = this.tbCountry;
            this.tbCountry.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbCountry.ForeColor = System.Drawing.Color.Black;
            this.tbCountry.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCountry.HoverState.Parent = this.tbCountry;
            this.tbCountry.Location = new System.Drawing.Point(32, 271);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.PasswordChar = '\0';
            this.tbCountry.PlaceholderText = "Nước sản xuất: Việt Nam, Nhật Bản, Mỹ...";
            this.tbCountry.SelectedText = "";
            this.tbCountry.ShadowDecoration.Parent = this.tbCountry;
            this.tbCountry.Size = new System.Drawing.Size(400, 36);
            this.tbCountry.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(32, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nước sản xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(32, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Giá nhập";
            // 
            // tbName
            // 
            this.tbName.AutoRoundedCorners = true;
            this.tbName.BackColor = System.Drawing.Color.Transparent;
            this.tbName.BorderColor = System.Drawing.Color.Black;
            this.tbName.BorderRadius = 17;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultText = "";
            this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.DisabledState.Parent = this.tbName;
            this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.FocusedState.Parent = this.tbName;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.HoverState.Parent = this.tbName;
            this.tbName.Location = new System.Drawing.Point(32, 79);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderText = "Tên hàng nhập";
            this.tbName.SelectedText = "";
            this.tbName.ShadowDecoration.Parent = this.tbName;
            this.tbName.Size = new System.Drawing.Size(400, 36);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(32, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên mặt hàng";
            // 
            // lUpload
            // 
            this.lUpload.AutoSize = true;
            this.lUpload.BackColor = System.Drawing.Color.Transparent;
            this.lUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lUpload.ForeColor = System.Drawing.Color.Red;
            this.lUpload.Location = new System.Drawing.Point(571, 419);
            this.lUpload.Name = "lUpload";
            this.lUpload.Size = new System.Drawing.Size(79, 17);
            this.lUpload.TabIndex = 31;
            this.lUpload.Text = "Tải ảnh lên";
            // 
            // tbProvider
            // 
            this.tbProvider.AutoRoundedCorners = true;
            this.tbProvider.BackColor = System.Drawing.Color.Transparent;
            this.tbProvider.BorderColor = System.Drawing.Color.Black;
            this.tbProvider.BorderRadius = 17;
            this.tbProvider.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbProvider.DefaultText = "";
            this.tbProvider.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbProvider.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbProvider.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbProvider.DisabledState.Parent = this.tbProvider;
            this.tbProvider.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbProvider.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbProvider.FocusedState.Parent = this.tbProvider;
            this.tbProvider.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbProvider.ForeColor = System.Drawing.Color.Black;
            this.tbProvider.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbProvider.HoverState.Parent = this.tbProvider;
            this.tbProvider.Location = new System.Drawing.Point(32, 335);
            this.tbProvider.Name = "tbProvider";
            this.tbProvider.PasswordChar = '\0';
            this.tbProvider.PlaceholderText = "Nhà cung cấp sản phẩm";
            this.tbProvider.SelectedText = "";
            this.tbProvider.ShadowDecoration.Parent = this.tbProvider;
            this.tbProvider.Size = new System.Drawing.Size(400, 36);
            this.tbProvider.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(32, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Nhà cung cấp";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(464, 79);
            this.pbImage.Name = "pbImage";
            this.pbImage.ShadowDecoration.Parent = this.pbImage;
            this.pbImage.Size = new System.Drawing.Size(300, 337);
            this.pbImage.TabIndex = 34;
            this.pbImage.TabStop = false;
            // 
            // dtpHSD
            // 
            this.dtpHSD.AutoRoundedCorners = true;
            this.dtpHSD.BackColor = System.Drawing.Color.Transparent;
            this.dtpHSD.BorderRadius = 17;
            this.dtpHSD.BorderThickness = 1;
            this.dtpHSD.CheckedState.Parent = this.dtpHSD;
            this.dtpHSD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpHSD.FillColor = System.Drawing.Color.White;
            this.dtpHSD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpHSD.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpHSD.HoverState.Parent = this.dtpHSD;
            this.dtpHSD.Location = new System.Drawing.Point(32, 462);
            this.dtpHSD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHSD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHSD.Name = "dtpHSD";
            this.dtpHSD.ShadowDecoration.Parent = this.dtpHSD;
            this.dtpHSD.Size = new System.Drawing.Size(400, 36);
            this.dtpHSD.TabIndex = 35;
            this.dtpHSD.Value = new System.DateTime(2020, 11, 27, 0, 44, 52, 352);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(32, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Hạn sử dụng";
            // 
            // nudPrice
            // 
            this.nudPrice.AutoRoundedCorners = true;
            this.nudPrice.BackColor = System.Drawing.Color.Transparent;
            this.nudPrice.BorderColor = System.Drawing.Color.Black;
            this.nudPrice.BorderRadius = 17;
            this.nudPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudPrice.DisabledState.Parent = this.nudPrice;
            this.nudPrice.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudPrice.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudPrice.FocusedState.Parent = this.nudPrice;
            this.nudPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudPrice.ForeColor = System.Drawing.Color.Black;
            this.nudPrice.Location = new System.Drawing.Point(32, 143);
            this.nudPrice.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.ShadowDecoration.Parent = this.nudPrice;
            this.nudPrice.Size = new System.Drawing.Size(400, 36);
            this.nudPrice.TabIndex = 37;
            // 
            // nudSL
            // 
            this.nudSL.AutoRoundedCorners = true;
            this.nudSL.BackColor = System.Drawing.Color.Transparent;
            this.nudSL.BorderColor = System.Drawing.Color.Black;
            this.nudSL.BorderRadius = 17;
            this.nudSL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudSL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudSL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudSL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudSL.DisabledState.Parent = this.nudSL;
            this.nudSL.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudSL.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudSL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudSL.FocusedState.Parent = this.nudSL;
            this.nudSL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudSL.ForeColor = System.Drawing.Color.Black;
            this.nudSL.Location = new System.Drawing.Point(32, 207);
            this.nudSL.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudSL.Name = "nudSL";
            this.nudSL.ShadowDecoration.Parent = this.nudSL;
            this.nudSL.Size = new System.Drawing.Size(400, 36);
            this.nudSL.TabIndex = 38;
            this.nudSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(32, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Số lượng";
            // 
            // fStockAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Small_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudSL);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpHSD);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.tbProvider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lUpload);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fStockAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lTitle;
        private Guna.UI2.WinForms.Guna2Button bCancel;
        private Guna.UI2.WinForms.Guna2Button bOK;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lUpload;
        private Guna.UI2.WinForms.Guna2TextBox tbProvider;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHSD;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudPrice;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudSL;
        private System.Windows.Forms.Label label7;
    }
}