namespace CoffeeShopManagement
{
    partial class fStaffList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStaffList));
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.cbSelectAll = new System.Windows.Forms.CheckBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bView = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(34, 88);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(1072, 653);
            this.dgvList.TabIndex = 0;
            // 
            // cbSelectAll
            // 
            this.cbSelectAll.AutoSize = true;
            this.cbSelectAll.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Vàng_nhẹ;
            this.cbSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectAll.Location = new System.Drawing.Point(35, 744);
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.Size = new System.Drawing.Size(93, 20);
            this.cbSelectAll.TabIndex = 1;
            this.cbSelectAll.Text = "Chọn tất cả";
            this.cbSelectAll.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.ForeColor = System.Drawing.Color.Black;
            this.bAdd.Location = new System.Drawing.Point(1129, 477);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(322, 48);
            this.bAdd.TabIndex = 2;
            this.bAdd.Text = "Thêm nhân viên mới";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bView
            // 
            this.bView.BackColor = System.Drawing.Color.Lime;
            this.bView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bView.ForeColor = System.Drawing.Color.Black;
            this.bView.Location = new System.Drawing.Point(1129, 531);
            this.bView.Name = "bView";
            this.bView.Size = new System.Drawing.Size(322, 48);
            this.bView.TabIndex = 3;
            this.bView.Text = "Xem thông tin chi tiết";
            this.bView.UseVisualStyleBackColor = false;
            this.bView.Click += new System.EventHandler(this.bView_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.Yellow;
            this.bEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEdit.ForeColor = System.Drawing.Color.Black;
            this.bEdit.Location = new System.Drawing.Point(1129, 585);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(322, 48);
            this.bEdit.TabIndex = 4;
            this.bEdit.Text = "Chỉnh sửa thông tin";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.ForeColor = System.Drawing.Color.Black;
            this.bDelete.Location = new System.Drawing.Point(1129, 639);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(322, 48);
            this.bDelete.TabIndex = 5;
            this.bDelete.Text = "Sa thải nhân viên";
            this.bDelete.UseVisualStyleBackColor = false;
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Red;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.ForeColor = System.Drawing.Color.Black;
            this.bCancel.Location = new System.Drawing.Point(1129, 693);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(322, 48);
            this.bCancel.TabIndex = 6;
            this.bCancel.Text = "Thoát";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = global::CoffeeShopManagement.Properties.Resources.avatar_demo;
            this.pbAvatar.Location = new System.Drawing.Point(1129, 88);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(322, 380);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 7;
            this.pbAvatar.TabStop = false;
            // 
            // fStaffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1475, 784);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bView);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.cbSelectAll);
            this.Controls.Add(this.dgvList);
            this.Name = "fStaffList";
            this.Text = "Phần mềm quản lý quán cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.CheckBox cbSelectAll;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bView;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.PictureBox pbAvatar;
    }
}