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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFoodList));
            this.lTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbxSelectAll = new System.Windows.Forms.CheckBox();
            this.bAdd = new Guna.UI2.WinForms.Guna2Button();
            this.bEdit = new Guna.UI2.WinForms.Guna2Button();
            this.bCancel = new Guna.UI2.WinForms.Guna2Button();
            this.bInfo = new Guna.UI2.WinForms.Guna2Button();
            this.pbAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dgvShow = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.Color.Transparent;
            this.lTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lTitle.Location = new System.Drawing.Point(28, 23);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(182, 31);
            this.lTitle.TabIndex = 3;
            this.lTitle.Text = "Danh sách món";
            // 
            // cbxSelectAll
            // 
            this.cbxSelectAll.AutoSize = true;
            this.cbxSelectAll.BackColor = System.Drawing.Color.Transparent;
            this.cbxSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cbxSelectAll.Location = new System.Drawing.Point(45, 712);
            this.cbxSelectAll.Name = "cbxSelectAll";
            this.cbxSelectAll.Size = new System.Drawing.Size(99, 21);
            this.cbxSelectAll.TabIndex = 34;
            this.cbxSelectAll.Text = "Chọn tất cả";
            this.cbxSelectAll.UseVisualStyleBackColor = false;
            // 
            // bAdd
            // 
            this.bAdd.AutoRoundedCorners = true;
            this.bAdd.BackColor = System.Drawing.Color.Transparent;
            this.bAdd.BorderRadius = 23;
            this.bAdd.CheckedState.Parent = this.bAdd;
            this.bAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAdd.CustomImages.Parent = this.bAdd;
            this.bAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.ForeColor = System.Drawing.Color.White;
            this.bAdd.HoverState.Parent = this.bAdd;
            this.bAdd.Location = new System.Drawing.Point(1159, 449);
            this.bAdd.Name = "bAdd";
            this.bAdd.ShadowDecoration.Parent = this.bAdd;
            this.bAdd.Size = new System.Drawing.Size(271, 48);
            this.bAdd.TabIndex = 33;
            this.bAdd.Text = "Thêm món mới";
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bEdit
            // 
            this.bEdit.AutoRoundedCorners = true;
            this.bEdit.BackColor = System.Drawing.Color.Transparent;
            this.bEdit.BorderRadius = 23;
            this.bEdit.CheckedState.Parent = this.bEdit;
            this.bEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEdit.CustomImages.Parent = this.bEdit;
            this.bEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEdit.ForeColor = System.Drawing.Color.White;
            this.bEdit.HoverState.Parent = this.bEdit;
            this.bEdit.Location = new System.Drawing.Point(1159, 519);
            this.bEdit.Name = "bEdit";
            this.bEdit.ShadowDecoration.Parent = this.bEdit;
            this.bEdit.Size = new System.Drawing.Size(271, 48);
            this.bEdit.TabIndex = 32;
            this.bEdit.Text = "Chỉnh sửa";
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bCancel
            // 
            this.bCancel.AutoRoundedCorners = true;
            this.bCancel.BackColor = System.Drawing.Color.Transparent;
            this.bCancel.BorderRadius = 23;
            this.bCancel.CheckedState.Parent = this.bCancel;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.CustomImages.Parent = this.bCancel;
            this.bCancel.FillColor = System.Drawing.Color.Red;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.HoverState.Parent = this.bCancel;
            this.bCancel.Location = new System.Drawing.Point(1159, 659);
            this.bCancel.Name = "bCancel";
            this.bCancel.ShadowDecoration.Parent = this.bCancel;
            this.bCancel.Size = new System.Drawing.Size(271, 48);
            this.bCancel.TabIndex = 31;
            this.bCancel.Text = "Thoát";
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bInfo
            // 
            this.bInfo.AutoRoundedCorners = true;
            this.bInfo.BackColor = System.Drawing.Color.Transparent;
            this.bInfo.BorderRadius = 23;
            this.bInfo.CheckedState.Parent = this.bInfo;
            this.bInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bInfo.CustomImages.Parent = this.bInfo;
            this.bInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInfo.ForeColor = System.Drawing.Color.White;
            this.bInfo.HoverState.Parent = this.bInfo;
            this.bInfo.Location = new System.Drawing.Point(1159, 589);
            this.bInfo.Name = "bInfo";
            this.bInfo.ShadowDecoration.Parent = this.bInfo;
            this.bInfo.Size = new System.Drawing.Size(271, 48);
            this.bInfo.TabIndex = 30;
            this.bInfo.Text = "Thông tin chi tiết";
            this.bInfo.Click += new System.EventHandler(this.bInfo_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.AutoRoundedCorners = true;
            this.pbAvatar.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Food_Avatar__Demo_;
            this.pbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAvatar.BorderRadius = 134;
            this.pbAvatar.Location = new System.Drawing.Point(1159, 62);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.ShadowDecoration.Parent = this.pbAvatar;
            this.pbAvatar.Size = new System.Drawing.Size(271, 372);
            this.pbAvatar.TabIndex = 29;
            this.pbAvatar.TabStop = false;
            // 
            // dgvShow
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvShow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvShow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShow.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShow.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShow.EnableHeadersVisualStyles = false;
            this.dgvShow.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShow.Location = new System.Drawing.Point(45, 62);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersVisible = false;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(1064, 645);
            this.dgvShow.TabIndex = 28;
            this.dgvShow.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvShow.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShow.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvShow.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvShow.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvShow.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvShow.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvShow.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShow.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvShow.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvShow.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvShow.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvShow.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvShow.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvShow.ThemeStyle.ReadOnly = false;
            this.dgvShow.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShow.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvShow.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvShow.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvShow.ThemeStyle.RowsStyle.Height = 22;
            this.dgvShow.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShow.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // fFoodList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.cbxSelectAll);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bInfo);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.lTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fFoodList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lTitle;
        private System.Windows.Forms.CheckBox cbxSelectAll;
        private Guna.UI2.WinForms.Guna2Button bAdd;
        private Guna.UI2.WinForms.Guna2Button bEdit;
        private Guna.UI2.WinForms.Guna2Button bCancel;
        private Guna.UI2.WinForms.Guna2Button bInfo;
        private Guna.UI2.WinForms.Guna2PictureBox pbAvatar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvShow;
    }
}