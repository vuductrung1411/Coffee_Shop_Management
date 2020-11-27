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
            this.tbPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lUpload = new System.Windows.Forms.Label();
            this.tbProvider = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.Color.Transparent;
            this.lTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(24, 13);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(129, 21);
            this.lTitle.TabIndex = 5;
            this.lTitle.Text = "Nhập thêm hàng";
            // 
            // bCancel
            // 
            this.bCancel.AutoRoundedCorners = true;
            this.bCancel.BackColor = System.Drawing.Color.Transparent;
            this.bCancel.BorderRadius = 16;
            this.bCancel.CheckedState.Parent = this.bCancel;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.CustomImages.Parent = this.bCancel;
            this.bCancel.FillColor = System.Drawing.Color.Red;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.bCancel.HoverState.Parent = this.bCancel;
            this.bCancel.Location = new System.Drawing.Point(240, 302);
            this.bCancel.Name = "bCancel";
            this.bCancel.ShadowDecoration.Parent = this.bCancel;
            this.bCancel.Size = new System.Drawing.Size(135, 35);
            this.bCancel.TabIndex = 30;
            this.bCancel.Text = "Quay lại";
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click_1);
            // 
            // bOK
            // 
            this.bOK.AutoRoundedCorners = true;
            this.bOK.BackColor = System.Drawing.Color.Transparent;
            this.bOK.BorderRadius = 16;
            this.bOK.CheckedState.Parent = this.bOK;
            this.bOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOK.CustomImages.Parent = this.bOK;
            this.bOK.FillColor = System.Drawing.Color.Chocolate;
            this.bOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOK.ForeColor = System.Drawing.Color.White;
            this.bOK.HoverState.Parent = this.bOK;
            this.bOK.Location = new System.Drawing.Point(32, 302);
            this.bOK.Name = "bOK";
            this.bOK.ShadowDecoration.Parent = this.bOK;
            this.bOK.Size = new System.Drawing.Size(135, 35);
            this.bOK.TabIndex = 29;
            this.bOK.Text = "Thêm";
            // 
            // dtpDate
            // 
            this.dtpDate.AutoRoundedCorners = true;
            this.dtpDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpDate.BorderRadius = 14;
            this.dtpDate.BorderThickness = 1;
            this.dtpDate.CheckedState.Parent = this.dtpDate;
            this.dtpDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDate.FillColor = System.Drawing.Color.White;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDate.HoverState.Parent = this.dtpDate;
            this.dtpDate.Location = new System.Drawing.Point(32, 258);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShadowDecoration.Parent = this.dtpDate;
            this.dtpDate.Size = new System.Drawing.Size(343, 30);
            this.dtpDate.TabIndex = 27;
            this.dtpDate.Value = new System.DateTime(2020, 11, 27, 0, 44, 52, 352);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(29, 242);
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
            this.tbCountry.BorderRadius = 14;
            this.tbCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCountry.DefaultText = "";
            this.tbCountry.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCountry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCountry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCountry.DisabledState.Parent = this.tbCountry;
            this.tbCountry.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCountry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCountry.FocusedState.Parent = this.tbCountry;
            this.tbCountry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbCountry.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCountry.HoverState.Parent = this.tbCountry;
            this.tbCountry.Location = new System.Drawing.Point(32, 158);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.PasswordChar = '\0';
            this.tbCountry.PlaceholderText = "";
            this.tbCountry.SelectedText = "";
            this.tbCountry.ShadowDecoration.Parent = this.tbCountry;
            this.tbCountry.Size = new System.Drawing.Size(343, 30);
            this.tbCountry.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(29, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nước sản xuất";
            // 
            // tbPrice
            // 
            this.tbPrice.AutoRoundedCorners = true;
            this.tbPrice.BackColor = System.Drawing.Color.Transparent;
            this.tbPrice.BorderColor = System.Drawing.Color.Black;
            this.tbPrice.BorderRadius = 14;
            this.tbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrice.DefaultText = "";
            this.tbPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.DisabledState.Parent = this.tbPrice;
            this.tbPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.FocusedState.Parent = this.tbPrice;
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.HoverState.Parent = this.tbPrice;
            this.tbPrice.Location = new System.Drawing.Point(32, 108);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.PlaceholderText = "";
            this.tbPrice.SelectedText = "";
            this.tbPrice.ShadowDecoration.Parent = this.tbPrice;
            this.tbPrice.Size = new System.Drawing.Size(343, 30);
            this.tbPrice.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(29, 92);
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
            this.tbName.BorderRadius = 14;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultText = "";
            this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.DisabledState.Parent = this.tbName;
            this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.FocusedState.Parent = this.tbName;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.HoverState.Parent = this.tbName;
            this.tbName.Location = new System.Drawing.Point(32, 58);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderText = "";
            this.tbName.SelectedText = "";
            this.tbName.ShadowDecoration.Parent = this.tbName;
            this.tbName.Size = new System.Drawing.Size(343, 30);
            this.tbName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(29, 42);
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
            this.lUpload.Location = new System.Drawing.Point(506, 289);
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
            this.tbProvider.BorderRadius = 14;
            this.tbProvider.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbProvider.DefaultText = "";
            this.tbProvider.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbProvider.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbProvider.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbProvider.DisabledState.Parent = this.tbProvider;
            this.tbProvider.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbProvider.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbProvider.FocusedState.Parent = this.tbProvider;
            this.tbProvider.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbProvider.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbProvider.HoverState.Parent = this.tbProvider;
            this.tbProvider.Location = new System.Drawing.Point(32, 208);
            this.tbProvider.Name = "tbProvider";
            this.tbProvider.PasswordChar = '\0';
            this.tbProvider.PlaceholderText = "";
            this.tbProvider.SelectedText = "";
            this.tbProvider.ShadowDecoration.Parent = this.tbProvider;
            this.tbProvider.Size = new System.Drawing.Size(343, 30);
            this.tbProvider.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(29, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Nhà cung cấp";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(400, 60);
            this.pbImage.Name = "pbImage";
            this.pbImage.ShadowDecoration.Parent = this.pbImage;
            this.pbImage.Size = new System.Drawing.Size(300, 226);
            this.pbImage.TabIndex = 34;
            this.pbImage.TabStop = false;
            // 
            // fStockAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Small_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 361);
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
            this.Controls.Add(this.tbPrice);
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
        private Guna.UI2.WinForms.Guna2TextBox tbPrice;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lUpload;
        private Guna.UI2.WinForms.Guna2TextBox tbProvider;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
    }
}