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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStart));
            this.pbProcessStart = new System.Windows.Forms.ProgressBar();
            this.lConnectToDeveloper = new System.Windows.Forms.Label();
            this.lChangeDatabase = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lShopName1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lShopOwner = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lSlogan1 = new System.Windows.Forms.Label();
            this.lShopName2 = new System.Windows.Forms.Label();
            this.lSlogan2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbProcessStart
            // 
            this.pbProcessStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbProcessStart.ForeColor = System.Drawing.Color.Gold;
            this.pbProcessStart.Location = new System.Drawing.Point(-3, 686);
            this.pbProcessStart.Name = "pbProcessStart";
            this.pbProcessStart.Size = new System.Drawing.Size(1498, 7);
            this.pbProcessStart.TabIndex = 0;
            // 
            // lConnectToDeveloper
            // 
            this.lConnectToDeveloper.AutoSize = true;
            this.lConnectToDeveloper.BackColor = System.Drawing.Color.Transparent;
            this.lConnectToDeveloper.Cursor = System.Windows.Forms.Cursors.Help;
            this.lConnectToDeveloper.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lConnectToDeveloper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lConnectToDeveloper.Location = new System.Drawing.Point(6, 722);
            this.lConnectToDeveloper.Name = "lConnectToDeveloper";
            this.lConnectToDeveloper.Size = new System.Drawing.Size(143, 14);
            this.lConnectToDeveloper.TabIndex = 1;
            this.lConnectToDeveloper.Text = "@ Liên hệ với nhà phát triển";
            // 
            // lChangeDatabase
            // 
            this.lChangeDatabase.AutoSize = true;
            this.lChangeDatabase.BackColor = System.Drawing.Color.Transparent;
            this.lChangeDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lChangeDatabase.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lChangeDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lChangeDatabase.Location = new System.Drawing.Point(6, 738);
            this.lChangeDatabase.Name = "lChangeDatabase";
            this.lChangeDatabase.Size = new System.Drawing.Size(85, 14);
            this.lChangeDatabase.TabIndex = 2;
            this.lChangeDatabase.Text = "@ Đổi database";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lText
            // 
            this.lText.AutoSize = true;
            this.lText.BackColor = System.Drawing.Color.Transparent;
            this.lText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lText.ForeColor = System.Drawing.Color.White;
            this.lText.Location = new System.Drawing.Point(12, 660);
            this.lText.Name = "lText";
            this.lText.Size = new System.Drawing.Size(20, 18);
            this.lText.TabIndex = 3;
            this.lText.Text = "...";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lShopName1);
            this.panel1.Location = new System.Drawing.Point(9, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1463, 143);
            this.panel1.TabIndex = 4;
            // 
            // lShopName1
            // 
            this.lShopName1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lShopName1.Font = new System.Drawing.Font("Oswald", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShopName1.ForeColor = System.Drawing.Color.Gold;
            this.lShopName1.Location = new System.Drawing.Point(0, 0);
            this.lShopName1.Name = "lShopName1";
            this.lShopName1.Size = new System.Drawing.Size(1463, 143);
            this.lShopName1.TabIndex = 0;
            this.lShopName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lShopOwner);
            this.panel2.Location = new System.Drawing.Point(9, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1463, 69);
            this.panel2.TabIndex = 5;
            // 
            // lShopOwner
            // 
            this.lShopOwner.AutoSize = false;
            this.lShopOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lShopOwner.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShopOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lShopOwner.Location = new System.Drawing.Point(0, 0);
            this.lShopOwner.Name = "lShopOwner";
            this.lShopOwner.Size = new System.Drawing.Size(0, 33);
            this.lShopOwner.TabIndex = 0;
            this.lShopOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lSlogan1);
            this.panel3.Location = new System.Drawing.Point(9, 465);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1463, 85);
            this.panel3.TabIndex = 6;
            // 
            // lSlogan1
            // 
            this.lSlogan1.AutoSize = false;
            this.lSlogan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lSlogan1.Font = new System.Drawing.Font("Montserrat Medium", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSlogan1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lSlogan1.Location = new System.Drawing.Point(0, 0);
            this.lSlogan1.Name = "lSlogan1";
            this.lSlogan1.Size = new System.Drawing.Size(0, 34);
            this.lSlogan1.TabIndex = 0;
            this.lSlogan1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lSlogan1.Click += new System.EventHandler(this.lSlogan1_Click);
            // 
            // lShopName2
            // 
            this.lShopName2.AutoSize = true;
            this.lShopName2.BackColor = System.Drawing.Color.Transparent;
            this.lShopName2.Font = new System.Drawing.Font("Gidole", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShopName2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lShopName2.Location = new System.Drawing.Point(50, 36);
            this.lShopName2.Name = "lShopName2";
            this.lShopName2.Size = new System.Drawing.Size(0, 29);
            this.lShopName2.TabIndex = 7;
            // 
            // lSlogan2
            // 
            this.lSlogan2.AutoSize = true;
            this.lSlogan2.BackColor = System.Drawing.Color.Transparent;
            this.lSlogan2.Font = new System.Drawing.Font("Gidole", 17.75F);
            this.lSlogan2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lSlogan2.Location = new System.Drawing.Point(38, 572);
            this.lSlogan2.Name = "lSlogan2";
            this.lSlogan2.Size = new System.Drawing.Size(0, 26);
            this.lSlogan2.TabIndex = 8;
            // 
            // fStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Start1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.lSlogan2);
            this.Controls.Add(this.lShopName2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lText);
            this.Controls.Add(this.lChangeDatabase);
            this.Controls.Add(this.lConnectToDeveloper);
            this.Controls.Add(this.pbProcessStart);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cà phê";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbProcessStart;
        private System.Windows.Forms.Label lConnectToDeveloper;
        private System.Windows.Forms.Label lChangeDatabase;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lShopName1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lShopOwner;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lSlogan1;
        private System.Windows.Forms.Label lShopName2;
        private System.Windows.Forms.Label lSlogan2;
    }
}