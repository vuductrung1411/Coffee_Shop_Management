namespace CoffeeShopManagement
{
    partial class fStockList
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
            this.bDelete = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.bImport = new System.Windows.Forms.Button();
            this.bUse = new System.Windows.Forms.Button();
            this.lSL = new System.Windows.Forms.Label();
            this.nudImport = new System.Windows.Forms.NumericUpDown();
            this.nudUse = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUse)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSelectAll
            // 
            this.cbSelectAll.AutoSize = true;
            this.cbSelectAll.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Vàng_nhẹ;
            this.cbSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectAll.Location = new System.Drawing.Point(43, 722);
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.Size = new System.Drawing.Size(103, 22);
            this.cbSelectAll.TabIndex = 16;
            this.cbSelectAll.Text = "Chọn tất cả";
            this.cbSelectAll.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Red;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(1241, 438);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(204, 52);
            this.bCancel.TabIndex = 15;
            this.bCancel.Text = "Thoát";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Location = new System.Drawing.Point(1242, 245);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(203, 52);
            this.bDelete.TabIndex = 14;
            this.bDelete.Text = "Xóa";
            this.bDelete.UseVisualStyleBackColor = false;
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEdit.Location = new System.Drawing.Point(1242, 159);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(203, 52);
            this.bEdit.TabIndex = 13;
            this.bEdit.Text = "Chỉnh sửa";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Aqua;
            this.bAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(1241, 75);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(203, 52);
            this.bAdd.TabIndex = 12;
            this.bAdd.Text = "Thêm hàng nhập vào";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(43, 75);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(639, 645);
            this.dgvList.TabIndex = 11;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = global::CoffeeShopManagement.Properties.Resources.CoffeeAvatar_Demo;
            this.pbAvatar.Location = new System.Drawing.Point(709, 75);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(509, 415);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 18;
            this.pbAvatar.TabStop = false;
            // 
            // tbSL
            // 
            this.tbSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSL.Location = new System.Drawing.Point(709, 597);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(509, 62);
            this.tbSL.TabIndex = 19;
            // 
            // bImport
            // 
            this.bImport.BackColor = System.Drawing.Color.DodgerBlue;
            this.bImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImport.Location = new System.Drawing.Point(780, 675);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(178, 45);
            this.bImport.TabIndex = 20;
            this.bImport.Text = "Nhập hàng (+)";
            this.bImport.UseVisualStyleBackColor = false;
            // 
            // bUse
            // 
            this.bUse.BackColor = System.Drawing.Color.LightCoral;
            this.bUse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUse.ForeColor = System.Drawing.Color.Black;
            this.bUse.Location = new System.Drawing.Point(964, 675);
            this.bUse.Name = "bUse";
            this.bUse.Size = new System.Drawing.Size(178, 45);
            this.bUse.TabIndex = 21;
            this.bUse.Text = "Sử dụng (-)";
            this.bUse.UseVisualStyleBackColor = false;
            // 
            // lSL
            // 
            this.lSL.AutoSize = true;
            this.lSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSL.Image = global::CoffeeShopManagement.Properties.Resources.Vàng_nhẹ;
            this.lSL.Location = new System.Drawing.Point(859, 554);
            this.lSL.Name = "lSL";
            this.lSL.Size = new System.Drawing.Size(205, 31);
            this.lSL.TabIndex = 22;
            this.lSL.Text = "Số lượng còn lại";
            // 
            // nudImport
            // 
            this.nudImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudImport.Location = new System.Drawing.Point(709, 682);
            this.nudImport.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudImport.Name = "nudImport";
            this.nudImport.Size = new System.Drawing.Size(65, 38);
            this.nudImport.TabIndex = 23;
            this.nudImport.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudUse
            // 
            this.nudUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudUse.Location = new System.Drawing.Point(1153, 680);
            this.nudUse.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudUse.Name = "nudUse";
            this.nudUse.Size = new System.Drawing.Size(65, 38);
            this.nudUse.TabIndex = 24;
            this.nudUse.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudUse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fStockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.StockManagement;
            this.ClientSize = new System.Drawing.Size(1477, 783);
            this.Controls.Add(this.nudUse);
            this.Controls.Add(this.nudImport);
            this.Controls.Add(this.lSL);
            this.Controls.Add(this.bUse);
            this.Controls.Add(this.bImport);
            this.Controls.Add(this.tbSL);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.cbSelectAll);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.dgvList);
            this.Name = "fStockList";
            this.Text = "Phần mềm quản lý quán cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbSelectAll;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.Button bImport;
        private System.Windows.Forms.Button bUse;
        private System.Windows.Forms.Label lSL;
        private System.Windows.Forms.NumericUpDown nudImport;
        private System.Windows.Forms.NumericUpDown nudUse;
    }
}