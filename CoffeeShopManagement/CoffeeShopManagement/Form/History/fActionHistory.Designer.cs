namespace CoffeeShopManagement
{
    partial class fActionHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fActionHistory));
            this.lTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvShow = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAction = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIDObject = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIDAction = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bCancel = new Guna.UI2.WinForms.Guna2Button();
            this.bFilt = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.Color.Transparent;
            this.lTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lTitle.Location = new System.Drawing.Point(35, 23);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(215, 31);
            this.lTitle.TabIndex = 4;
            this.lTitle.Text = "Lịch sử hoạt động";
            // 
            // dgvShow
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvShow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.BackgroundColor = System.Drawing.Color.White;
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
            this.dgvShow.ColumnHeadersHeight = 4;
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
            this.dgvShow.Location = new System.Drawing.Point(35, 73);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersVisible = false;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(986, 631);
            this.dgvShow.TabIndex = 5;
            this.dgvShow.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvShow.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShow.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvShow.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvShow.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvShow.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvShow.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvShow.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShow.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvShow.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvShow.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvShow.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvShow.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvShow.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvShow.ThemeStyle.ReadOnly = false;
            this.dgvShow.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShow.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvShow.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvShow.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvShow.ThemeStyle.RowsStyle.Height = 22;
            this.dgvShow.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShow.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.AutoRoundedCorners = true;
            this.dtpEndDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpEndDate.BorderRadius = 14;
            this.dtpEndDate.BorderThickness = 1;
            this.dtpEndDate.CheckedState.Parent = this.dtpEndDate;
            this.dtpEndDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpEndDate.FillColor = System.Drawing.Color.White;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEndDate.HoverState.Parent = this.dtpEndDate;
            this.dtpEndDate.Location = new System.Drawing.Point(1058, 291);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.ShadowDecoration.Parent = this.dtpEndDate;
            this.dtpEndDate.Size = new System.Drawing.Size(343, 30);
            this.dtpEndDate.TabIndex = 5;
            this.dtpEndDate.Value = new System.DateTime(2020, 11, 27, 0, 44, 52, 352);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(1055, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ngày kết thúc";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.AutoRoundedCorners = true;
            this.dtpStartDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpStartDate.BorderRadius = 14;
            this.dtpStartDate.BorderThickness = 1;
            this.dtpStartDate.CheckedState.Parent = this.dtpStartDate;
            this.dtpStartDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpStartDate.FillColor = System.Drawing.Color.White;
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartDate.HoverState.Parent = this.dtpStartDate;
            this.dtpStartDate.Location = new System.Drawing.Point(1058, 241);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.ShadowDecoration.Parent = this.dtpStartDate;
            this.dtpStartDate.Size = new System.Drawing.Size(343, 30);
            this.dtpStartDate.TabIndex = 4;
            this.dtpStartDate.Value = new System.DateTime(2020, 11, 27, 0, 44, 52, 352);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(1055, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // tbAction
            // 
            this.tbAction.AutoRoundedCorners = true;
            this.tbAction.BackColor = System.Drawing.Color.Transparent;
            this.tbAction.BorderColor = System.Drawing.Color.Black;
            this.tbAction.BorderRadius = 14;
            this.tbAction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAction.DefaultText = "";
            this.tbAction.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAction.DisabledState.Parent = this.tbAction;
            this.tbAction.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAction.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAction.FocusedState.Parent = this.tbAction;
            this.tbAction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbAction.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAction.HoverState.Parent = this.tbAction;
            this.tbAction.Location = new System.Drawing.Point(1058, 191);
            this.tbAction.Name = "tbAction";
            this.tbAction.PasswordChar = '\0';
            this.tbAction.PlaceholderText = "";
            this.tbAction.SelectedText = "";
            this.tbAction.ShadowDecoration.Parent = this.tbAction;
            this.tbAction.Size = new System.Drawing.Size(343, 30);
            this.tbAction.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(1055, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Hành động";
            // 
            // tbIDObject
            // 
            this.tbIDObject.AutoRoundedCorners = true;
            this.tbIDObject.BackColor = System.Drawing.Color.Transparent;
            this.tbIDObject.BorderColor = System.Drawing.Color.Black;
            this.tbIDObject.BorderRadius = 14;
            this.tbIDObject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIDObject.DefaultText = "";
            this.tbIDObject.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbIDObject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbIDObject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIDObject.DisabledState.Parent = this.tbIDObject;
            this.tbIDObject.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIDObject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDObject.FocusedState.Parent = this.tbIDObject;
            this.tbIDObject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbIDObject.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDObject.HoverState.Parent = this.tbIDObject;
            this.tbIDObject.Location = new System.Drawing.Point(1058, 141);
            this.tbIDObject.Name = "tbIDObject";
            this.tbIDObject.PasswordChar = '\0';
            this.tbIDObject.PlaceholderText = "";
            this.tbIDObject.SelectedText = "";
            this.tbIDObject.ShadowDecoration.Parent = this.tbIDObject;
            this.tbIDObject.Size = new System.Drawing.Size(343, 30);
            this.tbIDObject.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(1055, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "SDT người bị tác động";
            // 
            // tbIDAction
            // 
            this.tbIDAction.AutoRoundedCorners = true;
            this.tbIDAction.BackColor = System.Drawing.Color.Transparent;
            this.tbIDAction.BorderColor = System.Drawing.Color.Black;
            this.tbIDAction.BorderRadius = 14;
            this.tbIDAction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIDAction.DefaultText = "";
            this.tbIDAction.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbIDAction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbIDAction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIDAction.DisabledState.Parent = this.tbIDAction;
            this.tbIDAction.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIDAction.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDAction.FocusedState.Parent = this.tbIDAction;
            this.tbIDAction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbIDAction.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDAction.HoverState.Parent = this.tbIDAction;
            this.tbIDAction.Location = new System.Drawing.Point(1058, 91);
            this.tbIDAction.Name = "tbIDAction";
            this.tbIDAction.PasswordChar = '\0';
            this.tbIDAction.PlaceholderText = "";
            this.tbIDAction.SelectedText = "";
            this.tbIDAction.ShadowDecoration.Parent = this.tbIDAction;
            this.tbIDAction.Size = new System.Drawing.Size(343, 30);
            this.tbIDAction.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1055, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "SDT người tác động";
            // 
            // bCancel
            // 
            this.bCancel.AutoRoundedCorners = true;
            this.bCancel.BackColor = System.Drawing.Color.Transparent;
            this.bCancel.BorderRadius = 16;
            this.bCancel.CheckedState.Parent = this.bCancel;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.CustomImages.Parent = this.bCancel;
            this.bCancel.FillColor = System.Drawing.Color.Red;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.bCancel.HoverState.Parent = this.bCancel;
            this.bCancel.Location = new System.Drawing.Point(1058, 669);
            this.bCancel.Name = "bCancel";
            this.bCancel.ShadowDecoration.Parent = this.bCancel;
            this.bCancel.Size = new System.Drawing.Size(343, 35);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "Quay lại";
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bFilt
            // 
            this.bFilt.AutoRoundedCorners = true;
            this.bFilt.BackColor = System.Drawing.Color.Transparent;
            this.bFilt.BorderRadius = 16;
            this.bFilt.CheckedState.Parent = this.bFilt;
            this.bFilt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFilt.CustomImages.Parent = this.bFilt;
            this.bFilt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bFilt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFilt.ForeColor = System.Drawing.SystemColors.Window;
            this.bFilt.HoverState.Parent = this.bFilt;
            this.bFilt.Location = new System.Drawing.Point(1058, 338);
            this.bFilt.Name = "bFilt";
            this.bFilt.ShadowDecoration.Parent = this.bFilt;
            this.bFilt.Size = new System.Drawing.Size(343, 35);
            this.bFilt.TabIndex = 6;
            this.bFilt.Text = "Lọc";
            // 
            // fActionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.bFilt);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbIDObject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIDAction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.lTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fActionHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvShow;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbAction;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbIDObject;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbIDAction;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button bCancel;
        private Guna.UI2.WinForms.Guna2Button bFilt;
    }
}