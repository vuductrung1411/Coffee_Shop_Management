namespace CoffeeShopManagement
{
    partial class fDiscountEdit
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
            this.bAdd = new System.Windows.Forms.Button();
            this.tbNotification = new System.Windows.Forms.TextBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.nudDiscountValue = new System.Windows.Forms.NumericUpDown();
            this.tbMaxDiscount = new System.Windows.Forms.TextBox();
            this.tbMinBill = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountValue)).BeginInit();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.Location = new System.Drawing.Point(554, 316);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(124, 40);
            this.bCancel.TabIndex = 16;
            this.bCancel.Text = "Quay lại";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Aqua;
            this.bAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAdd.Location = new System.Drawing.Point(401, 316);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(124, 40);
            this.bAdd.TabIndex = 15;
            this.bAdd.Text = "Thêm";
            this.bAdd.UseVisualStyleBackColor = false;
            // 
            // tbNotification
            // 
            this.tbNotification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNotification.Location = new System.Drawing.Point(401, 83);
            this.tbNotification.Multiline = true;
            this.tbNotification.Name = "tbNotification";
            this.tbNotification.Size = new System.Drawing.Size(277, 212);
            this.tbNotification.TabIndex = 14;
            this.tbNotification.Text = "Thông báo: Nhân dịp sinh nhật lần thứ 5 quán cà phê TPT Coffee, giảm giá 5% cho t" +
    "ất cả các hóa đơn!";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(53, 327);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(274, 29);
            this.dtpEnd.TabIndex = 13;
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(53, 266);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(274, 29);
            this.dtpStart.TabIndex = 12;
            // 
            // nudDiscountValue
            // 
            this.nudDiscountValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudDiscountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiscountValue.Location = new System.Drawing.Point(53, 85);
            this.nudDiscountValue.Name = "nudDiscountValue";
            this.nudDiscountValue.Size = new System.Drawing.Size(274, 25);
            this.nudDiscountValue.TabIndex = 11;
            // 
            // tbMaxDiscount
            // 
            this.tbMaxDiscount.BackColor = System.Drawing.Color.White;
            this.tbMaxDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMaxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaxDiscount.Location = new System.Drawing.Point(53, 207);
            this.tbMaxDiscount.Name = "tbMaxDiscount";
            this.tbMaxDiscount.Size = new System.Drawing.Size(274, 22);
            this.tbMaxDiscount.TabIndex = 10;
            this.tbMaxDiscount.Text = "Không giới hạn";
            // 
            // tbMinBill
            // 
            this.tbMinBill.BackColor = System.Drawing.Color.White;
            this.tbMinBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMinBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinBill.Location = new System.Drawing.Point(53, 148);
            this.tbMinBill.Name = "tbMinBill";
            this.tbMinBill.Size = new System.Drawing.Size(274, 22);
            this.tbMinBill.TabIndex = 9;
            this.tbMinBill.Text = "0";
            // 
            // fDiscountEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.DiscountEdit1;
            this.ClientSize = new System.Drawing.Size(750, 399);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tbNotification);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.nudDiscountValue);
            this.Controls.Add(this.tbMaxDiscount);
            this.Controls.Add(this.tbMinBill);
            this.Name = "fDiscountEdit";
            this.Text = "Phần mềm quản lý quán cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox tbNotification;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.NumericUpDown nudDiscountValue;
        private System.Windows.Forms.TextBox tbMaxDiscount;
        private System.Windows.Forms.TextBox tbMinBill;
    }
}