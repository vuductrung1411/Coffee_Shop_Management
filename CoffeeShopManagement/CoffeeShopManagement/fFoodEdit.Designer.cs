namespace CoffeeShopManagement
{
    partial class fFoodEdit
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
            this.bSave = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lChangeAvatar = new System.Windows.Forms.Label();
            this.pbFoodAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Salmon;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(336, 288);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(153, 45);
            this.bCancel.TabIndex = 11;
            this.bCancel.Text = "Quay lại";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.Color.Aqua;
            this.bSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Location = new System.Drawing.Point(49, 288);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(153, 45);
            this.bSave.TabIndex = 10;
            this.bSave.Text = "Lưu";
            this.bSave.UseVisualStyleBackColor = false;
            // 
            // tbPrice
            // 
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(30, 216);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(493, 33);
            this.tbPrice.TabIndex = 9;
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(30, 117);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(493, 33);
            this.tbName.TabIndex = 8;
            // 
            // lChangeAvatar
            // 
            this.lChangeAvatar.AutoSize = true;
            this.lChangeAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lChangeAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lChangeAvatar.ForeColor = System.Drawing.Color.Red;
            this.lChangeAvatar.Image = global::CoffeeShopManagement.Properties.Resources.Vàng_nhẹ;
            this.lChangeAvatar.Location = new System.Drawing.Point(595, 288);
            this.lChangeAvatar.Name = "lChangeAvatar";
            this.lChangeAvatar.Size = new System.Drawing.Size(74, 16);
            this.lChangeAvatar.TabIndex = 7;
            this.lChangeAvatar.Text = "Tải ảnh lên";
            // 
            // pbFoodAvatar
            // 
            this.pbFoodAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFoodAvatar.Image = global::CoffeeShopManagement.Properties.Resources.CoffeeAvatar_Demo;
            this.pbFoodAvatar.Location = new System.Drawing.Point(546, 65);
            this.pbFoodAvatar.Name = "pbFoodAvatar";
            this.pbFoodAvatar.Size = new System.Drawing.Size(172, 208);
            this.pbFoodAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoodAvatar.TabIndex = 6;
            this.pbFoodAvatar.TabStop = false;
            // 
            // fFoodEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.EditFood;
            this.ClientSize = new System.Drawing.Size(749, 399);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lChangeAvatar);
            this.Controls.Add(this.pbFoodAvatar);
            this.Name = "fFoodEdit";
            this.Text = "Phần mềm quản lý quán cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lChangeAvatar;
        private System.Windows.Forms.PictureBox pbFoodAvatar;
    }
}