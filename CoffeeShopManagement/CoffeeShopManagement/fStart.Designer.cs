namespace CoffeeShopManagement
{
    partial class fStart
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
            this.pbProcessStart = new System.Windows.Forms.ProgressBar();
            this.lConnectToDeveloper = new System.Windows.Forms.Label();
            this.lChangeDatabase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbProcessStart
            // 
            this.pbProcessStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbProcessStart.ForeColor = System.Drawing.Color.Gold;
            this.pbProcessStart.Location = new System.Drawing.Point(-3, 709);
            this.pbProcessStart.Name = "pbProcessStart";
            this.pbProcessStart.Size = new System.Drawing.Size(1198, 7);
            this.pbProcessStart.TabIndex = 0;
            this.pbProcessStart.Value = 70;
            // 
            // lConnectToDeveloper
            // 
            this.lConnectToDeveloper.AutoSize = true;
            this.lConnectToDeveloper.BackColor = System.Drawing.Color.Black;
            this.lConnectToDeveloper.Cursor = System.Windows.Forms.Cursors.Help;
            this.lConnectToDeveloper.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lConnectToDeveloper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lConnectToDeveloper.Location = new System.Drawing.Point(3, 735);
            this.lConnectToDeveloper.Name = "lConnectToDeveloper";
            this.lConnectToDeveloper.Size = new System.Drawing.Size(143, 14);
            this.lConnectToDeveloper.TabIndex = 1;
            this.lConnectToDeveloper.Text = "@ Liên hệ với nhà phát triển";
            this.lConnectToDeveloper.Click += new System.EventHandler(this.lConnectToDeveloper_Click);
            // 
            // lChangeDatabase
            // 
            this.lChangeDatabase.AutoSize = true;
            this.lChangeDatabase.BackColor = System.Drawing.Color.Black;
            this.lChangeDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lChangeDatabase.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lChangeDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lChangeDatabase.Location = new System.Drawing.Point(3, 757);
            this.lChangeDatabase.Name = "lChangeDatabase";
            this.lChangeDatabase.Size = new System.Drawing.Size(85, 14);
            this.lChangeDatabase.TabIndex = 2;
            this.lChangeDatabase.Text = "@ Đổi database";
            this.lChangeDatabase.Click += new System.EventHandler(this.lChangeDatabase_Click);
            // 
            // fStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.StartImage2;
            this.ClientSize = new System.Drawing.Size(1194, 775);
            this.Controls.Add(this.lChangeDatabase);
            this.Controls.Add(this.lConnectToDeveloper);
            this.Controls.Add(this.pbProcessStart);
            this.Name = "fStart";
            this.Text = "Phần mềm quản lý quán cà phê";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbProcessStart;
        private System.Windows.Forms.Label lConnectToDeveloper;
        private System.Windows.Forms.Label lChangeDatabase;
    }
}