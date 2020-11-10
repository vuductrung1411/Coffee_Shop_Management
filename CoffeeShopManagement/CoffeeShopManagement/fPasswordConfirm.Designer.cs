namespace CoffeeShopManagement
{
    partial class fPasswordConfirm
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pbShowPassword = new System.Windows.Forms.PictureBox();
            this.bAccept = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(64, 153);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(576, 37);
            this.tbPassword.TabIndex = 0;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // pbShowPassword
            // 
            this.pbShowPassword.BackColor = System.Drawing.Color.White;
            this.pbShowPassword.Image = global::CoffeeShopManagement.Properties.Resources.ShowPassword;
            this.pbShowPassword.Location = new System.Drawing.Point(646, 153);
            this.pbShowPassword.Name = "pbShowPassword";
            this.pbShowPassword.Size = new System.Drawing.Size(40, 37);
            this.pbShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowPassword.TabIndex = 1;
            this.pbShowPassword.TabStop = false;
            this.pbShowPassword.Click += new System.EventHandler(this.pbShowPassword_Click);
            // 
            // bAccept
            // 
            this.bAccept.BackColor = System.Drawing.Color.Aqua;
            this.bAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAccept.Location = new System.Drawing.Point(64, 261);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(226, 46);
            this.bAccept.TabIndex = 2;
            this.bAccept.Text = "Đồng ý";
            this.bAccept.UseVisualStyleBackColor = false;
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Tomato;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(450, 261);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(226, 46);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Quay lại";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // fPasswordConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.ConfirmPassword1;
            this.ClientSize = new System.Drawing.Size(747, 403);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.pbShowPassword);
            this.Controls.Add(this.tbPassword);
            this.Name = "fPasswordConfirm";
            this.Text = "Phần mềm quản lý quán cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pbShowPassword;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.Button bCancel;
    }
}