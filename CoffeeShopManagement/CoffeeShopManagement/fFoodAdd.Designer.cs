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
            this.pbFoodAvatar = new System.Windows.Forms.PictureBox();
            this.lChangeAvatar = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFoodAvatar
            // 
            this.pbFoodAvatar.Cursor = System.Windows.Forms.Cursors.No;
            this.pbFoodAvatar.Image = global::CoffeeShopManagement.Properties.Resources.CoffeeAvatar_Demo;
            this.pbFoodAvatar.Location = new System.Drawing.Point(549, 78);
            this.pbFoodAvatar.Name = "pbFoodAvatar";
            this.pbFoodAvatar.Size = new System.Drawing.Size(172, 208);
            this.pbFoodAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoodAvatar.TabIndex = 0;
            this.pbFoodAvatar.TabStop = false;
            // 
            // lChangeAvatar
            // 
            this.lChangeAvatar.AutoSize = true;
            this.lChangeAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lChangeAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lChangeAvatar.ForeColor = System.Drawing.Color.Red;
            this.lChangeAvatar.Image = global::CoffeeShopManagement.Properties.Resources.Vàng_nhẹ;
            this.lChangeAvatar.Location = new System.Drawing.Point(598, 301);
            this.lChangeAvatar.Name = "lChangeAvatar";
            this.lChangeAvatar.Size = new System.Drawing.Size(74, 16);
            this.lChangeAvatar.TabIndex = 1;
            this.lChangeAvatar.Text = "Tải ảnh lên";
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(34, 117);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(493, 33);
            this.tbName.TabIndex = 2;
            // 
            // tbPrice
            // 
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(33, 216);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(493, 33);
            this.tbPrice.TabIndex = 3;
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Aqua;
            this.bAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(52, 301);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(153, 45);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "Thêm";
            this.bAdd.UseVisualStyleBackColor = false;
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Salmon;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(339, 301);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(153, 45);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Quay lại";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // fFoodAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.AddFood;
            this.ClientSize = new System.Drawing.Size(750, 395);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lChangeAvatar);
            this.Controls.Add(this.pbFoodAvatar);
            this.Name = "fFoodAdd";
            this.Text = "Phần mềm quản lý quán cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFoodAvatar;
        private System.Windows.Forms.Label lChangeAvatar;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bCancel;
    }
}