namespace CoffeeShopManagement
{
    partial class fBillHistory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bSearch = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(873, 685);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chartreuse;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::CoffeeShopManagement.Properties.Resources.Vàng_nhẹ;
            this.label1.Location = new System.Drawing.Point(947, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "abcbcsdibcs";
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Location = new System.Drawing.Point(951, 346);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(424, 58);
            this.bSearch.TabIndex = 3;
            this.bSearch.Text = "Tìm kiếm";
            this.bSearch.UseVisualStyleBackColor = false;
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Red;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Location = new System.Drawing.Point(951, 697);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(424, 58);
            this.bExit.TabIndex = 4;
            this.bExit.Text = "Thoát";
            this.bExit.UseVisualStyleBackColor = false;
            // 
            // fBillHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.BillHistory1;
            this.ClientSize = new System.Drawing.Size(1500, 795);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fBillHistory";
            this.Text = "Phần mềm quản lý quán cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bExit;
    }
}