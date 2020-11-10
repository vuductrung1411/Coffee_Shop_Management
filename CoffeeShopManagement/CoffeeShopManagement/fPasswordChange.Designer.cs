namespace CoffeeShopManagement
{
    partial class fPasswordChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPasswordChange));
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.bAccept = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.pbShowOldPassword = new System.Windows.Forms.PictureBox();
            this.pbShowNewPassword = new System.Windows.Forms.PictureBox();
            this.pbShowConfirm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowOldPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOldPassword.Location = new System.Drawing.Point(66, 89);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.Size = new System.Drawing.Size(531, 31);
            this.tbOldPassword.TabIndex = 0;
            this.tbOldPassword.UseSystemPasswordChar = true;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPassword.Location = new System.Drawing.Point(66, 176);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(531, 31);
            this.tbNewPassword.TabIndex = 1;
            this.tbNewPassword.UseSystemPasswordChar = true;
            // 
            // tbConfirm
            // 
            this.tbConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirm.Location = new System.Drawing.Point(66, 266);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.Size = new System.Drawing.Size(531, 31);
            this.tbConfirm.TabIndex = 2;
            this.tbConfirm.UseSystemPasswordChar = true;
            // 
            // bAccept
            // 
            this.bAccept.BackColor = System.Drawing.Color.DodgerBlue;
            this.bAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAccept.Location = new System.Drawing.Point(163, 322);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(167, 41);
            this.bAccept.TabIndex = 3;
            this.bAccept.Text = "Xác nhận";
            this.bAccept.UseVisualStyleBackColor = false;
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Red;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(400, 322);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(167, 41);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Hủy";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // pbShowOldPassword
            // 
            this.pbShowOldPassword.BackColor = System.Drawing.Color.White;
            this.pbShowOldPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowOldPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbShowOldPassword.Image")));
            this.pbShowOldPassword.Location = new System.Drawing.Point(603, 89);
            this.pbShowOldPassword.Name = "pbShowOldPassword";
            this.pbShowOldPassword.Size = new System.Drawing.Size(49, 31);
            this.pbShowOldPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowOldPassword.TabIndex = 5;
            this.pbShowOldPassword.TabStop = false;
            this.pbShowOldPassword.Click += new System.EventHandler(this.pbShowOldPassword_Click);
            // 
            // pbShowNewPassword
            // 
            this.pbShowNewPassword.BackColor = System.Drawing.Color.White;
            this.pbShowNewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowNewPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbShowNewPassword.Image")));
            this.pbShowNewPassword.Location = new System.Drawing.Point(603, 176);
            this.pbShowNewPassword.Name = "pbShowNewPassword";
            this.pbShowNewPassword.Size = new System.Drawing.Size(49, 31);
            this.pbShowNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowNewPassword.TabIndex = 6;
            this.pbShowNewPassword.TabStop = false;
            this.pbShowNewPassword.Click += new System.EventHandler(this.pbShowNewPassword_Click);
            // 
            // pbShowConfirm
            // 
            this.pbShowConfirm.BackColor = System.Drawing.Color.White;
            this.pbShowConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowConfirm.Image = ((System.Drawing.Image)(resources.GetObject("pbShowConfirm.Image")));
            this.pbShowConfirm.Location = new System.Drawing.Point(603, 266);
            this.pbShowConfirm.Name = "pbShowConfirm";
            this.pbShowConfirm.Size = new System.Drawing.Size(49, 31);
            this.pbShowConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowConfirm.TabIndex = 7;
            this.pbShowConfirm.TabStop = false;
            this.pbShowConfirm.Click += new System.EventHandler(this.pbShowConfirm_Click);
            // 
            // fPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(749, 396);
            this.Controls.Add(this.pbShowConfirm);
            this.Controls.Add(this.pbShowNewPassword);
            this.Controls.Add(this.pbShowOldPassword);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.tbConfirm);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.tbOldPassword);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fPasswordChange";
            this.Text = "Phần mềm quản lý quán cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.pbShowOldPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbConfirm;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.PictureBox pbShowOldPassword;
        private System.Windows.Forms.PictureBox pbShowNewPassword;
        private System.Windows.Forms.PictureBox pbShowConfirm;
    }
}