namespace CoffeeShopManagement
{
    partial class fCustomerList
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
            this.cbSelectAll = new System.Windows.Forms.CheckBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.bView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSelectAll
            // 
            this.cbSelectAll.AutoSize = true;
            this.cbSelectAll.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Vàng_nhẹ;
            this.cbSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectAll.Location = new System.Drawing.Point(41, 732);
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.Size = new System.Drawing.Size(103, 22);
            this.cbSelectAll.TabIndex = 17;
            this.cbSelectAll.Text = "Chọn tất cả";
            this.cbSelectAll.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Red;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(973, 674);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(459, 52);
            this.bCancel.TabIndex = 16;
            this.bCancel.Text = "Thoát";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEdit.Location = new System.Drawing.Point(973, 553);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(459, 52);
            this.bEdit.TabIndex = 14;
            this.bEdit.Text = "Chỉnh sửa";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Aqua;
            this.bAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(973, 493);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(459, 52);
            this.bAdd.TabIndex = 13;
            this.bAdd.Text = "Thêm";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = global::CoffeeShopManagement.Properties.Resources.CoffeeAvatar_Demo;
            this.pbAvatar.Location = new System.Drawing.Point(973, 81);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(459, 397);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 12;
            this.pbAvatar.TabStop = false;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(41, 81);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(898, 645);
            this.dgvList.TabIndex = 11;
            // 
            // bView
            // 
            this.bView.BackColor = System.Drawing.Color.Lime;
            this.bView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bView.ForeColor = System.Drawing.Color.Black;
            this.bView.Location = new System.Drawing.Point(973, 614);
            this.bView.Name = "bView";
            this.bView.Size = new System.Drawing.Size(459, 52);
            this.bView.TabIndex = 18;
            this.bView.Text = "Xem thông tin chi tiết";
            this.bView.UseVisualStyleBackColor = false;
            this.bView.Click += new System.EventHandler(this.bView_Click);
            // 
            // fCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.CustomerList;
            this.ClientSize = new System.Drawing.Size(1478, 785);
            this.Controls.Add(this.bView);
            this.Controls.Add(this.cbSelectAll);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.dgvList);
            this.Name = "fCustomerList";
            this.Text = "Phần mềm quản lý quán cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbSelectAll;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button bView;
    }
}