namespace CoffeeShopManagement
{
    partial class fFoodList
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
            this.dgvListFood = new System.Windows.Forms.DataGridView();
            this.cbSelectAll = new System.Windows.Forms.CheckBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListFood
            // 
            this.dgvListFood.AllowUserToAddRows = false;
            this.dgvListFood.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvListFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListFood.Location = new System.Drawing.Point(42, 76);
            this.dgvListFood.Name = "dgvListFood";
            this.dgvListFood.Size = new System.Drawing.Size(898, 638);
            this.dgvListFood.TabIndex = 0;
            // 
            // cbSelectAll
            // 
            this.cbSelectAll.AutoSize = true;
            this.cbSelectAll.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Vàng_nhẹ;
            this.cbSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectAll.Location = new System.Drawing.Point(42, 720);
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.Size = new System.Drawing.Size(103, 22);
            this.cbSelectAll.TabIndex = 1;
            this.cbSelectAll.Text = "Chọn tất cả";
            this.cbSelectAll.UseVisualStyleBackColor = true;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = global::CoffeeShopManagement.Properties.Resources.CoffeeAvatar_Demo;
            this.pbAvatar.Location = new System.Drawing.Point(976, 76);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(459, 397);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 2;
            this.pbAvatar.TabStop = false;
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Red;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(976, 662);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(459, 52);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Thoát";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Aqua;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(976, 488);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(459, 52);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "Thêm món";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Location = new System.Drawing.Point(976, 604);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(459, 52);
            this.bDelete.TabIndex = 5;
            this.bDelete.Text = "Xóa món";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEdit.Location = new System.Drawing.Point(976, 546);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(459, 52);
            this.bEdit.TabIndex = 6;
            this.bEdit.Text = "Chỉnh sửa";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // fFoodList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.FoodList;
            this.ClientSize = new System.Drawing.Size(1484, 786);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.cbSelectAll);
            this.Controls.Add(this.dgvListFood);
            this.Name = "fFoodList";
            this.Text = "Phần mềm quản lý quán cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListFood;
        private System.Windows.Forms.CheckBox cbSelectAll;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bEdit;
    }
}