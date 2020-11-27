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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBillHistory));
            this.lTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bFilt = new Guna.UI2.WinForms.Guna2Button();
            this.bCancel = new Guna.UI2.WinForms.Guna2Button();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBillID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCustomerSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStaffID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvShow = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tbMinValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMaxValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.Color.Transparent;
            this.lTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lTitle.Location = new System.Drawing.Point(29, 23);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(194, 31);
            this.lTitle.TabIndex = 4;
            this.lTitle.Text = "Lịch sử hóa đơn";
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
            this.bFilt.Location = new System.Drawing.Point(1065, 375);
            this.bFilt.Name = "bFilt";
            this.bFilt.ShadowDecoration.Parent = this.bFilt;
            this.bFilt.Size = new System.Drawing.Size(343, 35);
            this.bFilt.TabIndex = 40;
            this.bFilt.Text = "Lọc";
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
            this.bCancel.Location = new System.Drawing.Point(1065, 680);
            this.bCancel.Name = "bCancel";
            this.bCancel.ShadowDecoration.Parent = this.bCancel;
            this.bCancel.Size = new System.Drawing.Size(343, 35);
            this.bCancel.TabIndex = 39;
            this.bCancel.Text = "Quay lại";
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
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
            this.dtpEndDate.Location = new System.Drawing.Point(1065, 283);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.ShadowDecoration.Parent = this.dtpEndDate;
            this.dtpEndDate.Size = new System.Drawing.Size(343, 30);
            this.dtpEndDate.TabIndex = 38;
            this.dtpEndDate.Value = new System.DateTime(2020, 11, 27, 0, 44, 52, 352);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(1062, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 37;
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
            this.dtpStartDate.Location = new System.Drawing.Point(1065, 233);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.ShadowDecoration.Parent = this.dtpStartDate;
            this.dtpStartDate.Size = new System.Drawing.Size(343, 30);
            this.dtpStartDate.TabIndex = 36;
            this.dtpStartDate.Value = new System.DateTime(2020, 11, 27, 0, 44, 52, 352);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(1062, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // tbBillID
            // 
            this.tbBillID.AutoRoundedCorners = true;
            this.tbBillID.BackColor = System.Drawing.Color.Transparent;
            this.tbBillID.BorderColor = System.Drawing.Color.Black;
            this.tbBillID.BorderRadius = 14;
            this.tbBillID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBillID.DefaultText = "";
            this.tbBillID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbBillID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbBillID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBillID.DisabledState.Parent = this.tbBillID;
            this.tbBillID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBillID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBillID.FocusedState.Parent = this.tbBillID;
            this.tbBillID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbBillID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBillID.HoverState.Parent = this.tbBillID;
            this.tbBillID.Location = new System.Drawing.Point(1065, 183);
            this.tbBillID.Name = "tbBillID";
            this.tbBillID.PasswordChar = '\0';
            this.tbBillID.PlaceholderText = "";
            this.tbBillID.SelectedText = "";
            this.tbBillID.ShadowDecoration.Parent = this.tbBillID;
            this.tbBillID.Size = new System.Drawing.Size(343, 30);
            this.tbBillID.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(1062, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mã hóa đơn";
            // 
            // tbCustomerSDT
            // 
            this.tbCustomerSDT.AutoRoundedCorners = true;
            this.tbCustomerSDT.BackColor = System.Drawing.Color.Transparent;
            this.tbCustomerSDT.BorderColor = System.Drawing.Color.Black;
            this.tbCustomerSDT.BorderRadius = 14;
            this.tbCustomerSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCustomerSDT.DefaultText = "";
            this.tbCustomerSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCustomerSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCustomerSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCustomerSDT.DisabledState.Parent = this.tbCustomerSDT;
            this.tbCustomerSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCustomerSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCustomerSDT.FocusedState.Parent = this.tbCustomerSDT;
            this.tbCustomerSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbCustomerSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCustomerSDT.HoverState.Parent = this.tbCustomerSDT;
            this.tbCustomerSDT.Location = new System.Drawing.Point(1065, 133);
            this.tbCustomerSDT.Name = "tbCustomerSDT";
            this.tbCustomerSDT.PasswordChar = '\0';
            this.tbCustomerSDT.PlaceholderText = "";
            this.tbCustomerSDT.SelectedText = "";
            this.tbCustomerSDT.ShadowDecoration.Parent = this.tbCustomerSDT;
            this.tbCustomerSDT.Size = new System.Drawing.Size(343, 30);
            this.tbCustomerSDT.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(1062, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "SDT khách hàng";
            // 
            // tbStaffID
            // 
            this.tbStaffID.AutoRoundedCorners = true;
            this.tbStaffID.BackColor = System.Drawing.Color.Transparent;
            this.tbStaffID.BorderColor = System.Drawing.Color.Black;
            this.tbStaffID.BorderRadius = 14;
            this.tbStaffID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStaffID.DefaultText = "";
            this.tbStaffID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbStaffID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbStaffID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbStaffID.DisabledState.Parent = this.tbStaffID;
            this.tbStaffID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbStaffID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStaffID.FocusedState.Parent = this.tbStaffID;
            this.tbStaffID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbStaffID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStaffID.HoverState.Parent = this.tbStaffID;
            this.tbStaffID.Location = new System.Drawing.Point(1065, 83);
            this.tbStaffID.Name = "tbStaffID";
            this.tbStaffID.PasswordChar = '\0';
            this.tbStaffID.PlaceholderText = "";
            this.tbStaffID.SelectedText = "";
            this.tbStaffID.ShadowDecoration.Parent = this.tbStaffID;
            this.tbStaffID.Size = new System.Drawing.Size(343, 30);
            this.tbStaffID.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1062, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã nhân viên";
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
            this.dgvShow.Location = new System.Drawing.Point(42, 65);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersVisible = false;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(986, 650);
            this.dgvShow.TabIndex = 28;
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
            // tbMinValue
            // 
            this.tbMinValue.AutoRoundedCorners = true;
            this.tbMinValue.BackColor = System.Drawing.Color.Transparent;
            this.tbMinValue.BorderColor = System.Drawing.Color.Black;
            this.tbMinValue.BorderRadius = 14;
            this.tbMinValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMinValue.DefaultText = "";
            this.tbMinValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMinValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMinValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMinValue.DisabledState.Parent = this.tbMinValue;
            this.tbMinValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMinValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMinValue.FocusedState.Parent = this.tbMinValue;
            this.tbMinValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbMinValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMinValue.HoverState.Parent = this.tbMinValue;
            this.tbMinValue.Location = new System.Drawing.Point(1065, 333);
            this.tbMinValue.Name = "tbMinValue";
            this.tbMinValue.PasswordChar = '\0';
            this.tbMinValue.PlaceholderText = "";
            this.tbMinValue.SelectedText = "";
            this.tbMinValue.ShadowDecoration.Parent = this.tbMinValue;
            this.tbMinValue.Size = new System.Drawing.Size(162, 30);
            this.tbMinValue.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(1062, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Giá trị đơn hàng khoảng từ:";
            // 
            // tbMaxValue
            // 
            this.tbMaxValue.AutoRoundedCorners = true;
            this.tbMaxValue.BackColor = System.Drawing.Color.Transparent;
            this.tbMaxValue.BorderColor = System.Drawing.Color.Black;
            this.tbMaxValue.BorderRadius = 14;
            this.tbMaxValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMaxValue.DefaultText = "";
            this.tbMaxValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMaxValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMaxValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaxValue.DisabledState.Parent = this.tbMaxValue;
            this.tbMaxValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaxValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaxValue.FocusedState.Parent = this.tbMaxValue;
            this.tbMaxValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbMaxValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaxValue.HoverState.Parent = this.tbMaxValue;
            this.tbMaxValue.Location = new System.Drawing.Point(1246, 333);
            this.tbMaxValue.Name = "tbMaxValue";
            this.tbMaxValue.PasswordChar = '\0';
            this.tbMaxValue.PlaceholderText = "";
            this.tbMaxValue.SelectedText = "";
            this.tbMaxValue.ShadowDecoration.Parent = this.tbMaxValue;
            this.tbMaxValue.Size = new System.Drawing.Size(162, 30);
            this.tbMaxValue.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(1243, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "đến:";
            // 
            // fBillHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.tbMaxValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMinValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bFilt);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbBillID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCustomerSDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbStaffID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.lTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fBillHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lTitle;
        private Guna.UI2.WinForms.Guna2Button bFilt;
        private Guna.UI2.WinForms.Guna2Button bCancel;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbBillID;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbCustomerSDT;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbStaffID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvShow;
        private Guna.UI2.WinForms.Guna2TextBox tbMinValue;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox tbMaxValue;
        private System.Windows.Forms.Label label7;
    }
}