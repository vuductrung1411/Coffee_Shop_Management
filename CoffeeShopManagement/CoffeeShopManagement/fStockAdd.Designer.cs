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
            this.bCancel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
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
            this.bCancel.Location = new System.Drawing.Point(339, 304);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(153, 45);
            this.bCancel.TabIndex = 9;
            this.bCancel.Text = "Quay lại";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Aqua;
            this.bAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(52, 304);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(153, 45);
            this.bAdd.TabIndex = 8;
            this.bAdd.Text = "Thêm";
            this.bAdd.UseVisualStyleBackColor = false;
            // 
            // lChangeAvatar
            // 
            this.lChangeAvatar.AutoSize = true;
            this.lChangeAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lChangeAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lChangeAvatar.ForeColor = System.Drawing.Color.Red;
            this.lChangeAvatar.Image = global::CoffeeShopManagement.Properties.Resources.Vàng_nhẹ;
            this.lChangeAvatar.Location = new System.Drawing.Point(598, 304);
            this.lChangeAvatar.Name = "lChangeAvatar";
            this.lChangeAvatar.Size = new System.Drawing.Size(74, 16);
            this.lChangeAvatar.TabIndex = 7;
            this.lChangeAvatar.Text = "Tải ảnh lên";
            // 
            // pbFoodAvatar
            // 
            this.pbFoodAvatar.Cursor = System.Windows.Forms.Cursors.No;
            this.pbFoodAvatar.Image = global::CoffeeShopManagement.Properties.Resources.CoffeeAvatar_Demo;
            this.pbFoodAvatar.Location = new System.Drawing.Point(549, 81);
            this.pbFoodAvatar.Name = "pbFoodAvatar";
            this.pbFoodAvatar.Size = new System.Drawing.Size(172, 208);
            this.pbFoodAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoodAvatar.TabIndex = 6;
            this.pbFoodAvatar.TabStop = false;
            // 
            // fStockAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.AddStock;
            this.ClientSize = new System.Drawing.Size(750, 398);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.lChangeAvatar);
            this.Controls.Add(this.pbFoodAvatar);
            this.Name = "fStockAdd";
            this.Text = "Phần mềm quản lý quán cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label lChangeAvatar;
        private System.Windows.Forms.PictureBox pbFoodAvatar;
    }
}