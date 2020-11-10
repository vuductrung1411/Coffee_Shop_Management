namespace CoffeeShopManagement
{
    partial class fGetOutOfFoodList
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
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.dgvcbcFoodSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvtbcFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcFoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvcbcGetOutOfFoodSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvcbcGetOutOfFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcbcGetOutOfFoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbFoodSelectAll = new System.Windows.Forms.CheckBox();
            this.cbGetOutOfFoodSelectAll = new System.Windows.Forms.CheckBox();
            this.bClose = new System.Windows.Forms.Button();
            this.bOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.AllowUserToAddRows = false;
            this.dgvFoodList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvFoodList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcbcFoodSelect,
            this.dgvtbcFoodName,
            this.dgvtbcFoodPrice});
            this.dgvFoodList.Location = new System.Drawing.Point(39, 93);
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.RowHeadersVisible = false;
            this.dgvFoodList.Size = new System.Drawing.Size(682, 582);
            this.dgvFoodList.TabIndex = 0;
            // 
            // dgvcbcFoodSelect
            // 
            this.dgvcbcFoodSelect.HeaderText = "Chọn";
            this.dgvcbcFoodSelect.Name = "dgvcbcFoodSelect";
            // 
            // dgvtbcFoodName
            // 
            this.dgvtbcFoodName.HeaderText = "Tên";
            this.dgvtbcFoodName.Name = "dgvtbcFoodName";
            this.dgvtbcFoodName.ReadOnly = true;
            this.dgvtbcFoodName.Width = 390;
            // 
            // dgvtbcFoodPrice
            // 
            this.dgvtbcFoodPrice.HeaderText = "Giá";
            this.dgvtbcFoodPrice.Name = "dgvtbcFoodPrice";
            this.dgvtbcFoodPrice.ReadOnly = true;
            this.dgvtbcFoodPrice.Width = 191;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcbcGetOutOfFoodSelect,
            this.dgvcbcGetOutOfFoodName,
            this.dgvcbcGetOutOfFoodPrice});
            this.dataGridView1.Location = new System.Drawing.Point(780, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(682, 582);
            this.dataGridView1.TabIndex = 1;
            // 
            // dgvcbcGetOutOfFoodSelect
            // 
            this.dgvcbcGetOutOfFoodSelect.HeaderText = "Chọn";
            this.dgvcbcGetOutOfFoodSelect.Name = "dgvcbcGetOutOfFoodSelect";
            // 
            // dgvcbcGetOutOfFoodName
            // 
            this.dgvcbcGetOutOfFoodName.HeaderText = "Tên";
            this.dgvcbcGetOutOfFoodName.Name = "dgvcbcGetOutOfFoodName";
            this.dgvcbcGetOutOfFoodName.ReadOnly = true;
            this.dgvcbcGetOutOfFoodName.Width = 390;
            // 
            // dgvcbcGetOutOfFoodPrice
            // 
            this.dgvcbcGetOutOfFoodPrice.HeaderText = "Giá";
            this.dgvcbcGetOutOfFoodPrice.Name = "dgvcbcGetOutOfFoodPrice";
            this.dgvcbcGetOutOfFoodPrice.ReadOnly = true;
            this.dgvcbcGetOutOfFoodPrice.Width = 191;
            // 
            // cbFoodSelectAll
            // 
            this.cbFoodSelectAll.AutoSize = true;
            this.cbFoodSelectAll.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Vàng_nhẹ;
            this.cbFoodSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFoodSelectAll.Location = new System.Drawing.Point(39, 681);
            this.cbFoodSelectAll.Name = "cbFoodSelectAll";
            this.cbFoodSelectAll.Size = new System.Drawing.Size(93, 20);
            this.cbFoodSelectAll.TabIndex = 2;
            this.cbFoodSelectAll.Text = "Chọn tất cả";
            this.cbFoodSelectAll.UseVisualStyleBackColor = true;
            // 
            // cbGetOutOfFoodSelectAll
            // 
            this.cbGetOutOfFoodSelectAll.AutoSize = true;
            this.cbGetOutOfFoodSelectAll.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Vàng_nhẹ;
            this.cbGetOutOfFoodSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGetOutOfFoodSelectAll.Location = new System.Drawing.Point(780, 681);
            this.cbGetOutOfFoodSelectAll.Name = "cbGetOutOfFoodSelectAll";
            this.cbGetOutOfFoodSelectAll.Size = new System.Drawing.Size(93, 20);
            this.cbGetOutOfFoodSelectAll.TabIndex = 3;
            this.cbGetOutOfFoodSelectAll.Text = "Chọn tất cả";
            this.cbGetOutOfFoodSelectAll.UseVisualStyleBackColor = true;
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.OrangeRed;
            this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Location = new System.Drawing.Point(197, 696);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(333, 55);
            this.bClose.TabIndex = 4;
            this.bClose.Text = "Đã hết";
            this.bClose.UseVisualStyleBackColor = false;
            // 
            // bOpen
            // 
            this.bOpen.BackColor = System.Drawing.Color.Lime;
            this.bOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOpen.Location = new System.Drawing.Point(989, 696);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(333, 55);
            this.bOpen.TabIndex = 5;
            this.bOpen.Text = "Phục vụ tiếp";
            this.bOpen.UseVisualStyleBackColor = false;
            // 
            // fGetOutOfFoodList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.GetOutOfFood;
            this.ClientSize = new System.Drawing.Size(1499, 791);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.cbGetOutOfFoodSelectAll);
            this.Controls.Add(this.cbFoodSelectAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvFoodList);
            this.Name = "fGetOutOfFoodList";
            this.Text = "Phần mềm quản lý quán cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFoodList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcbcFoodSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcFoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcFoodPrice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cbFoodSelectAll;
        private System.Windows.Forms.CheckBox cbGetOutOfFoodSelectAll;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcbcGetOutOfFoodSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcbcGetOutOfFoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcbcGetOutOfFoodPrice;
    }
}