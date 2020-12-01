using CoffeeShopManagement.DAO;
using CoffeeShopManagement.DTO;
using Guna.UI2.WinForms;
using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class fSell : Form
    {
        // Danh sách khách hàng trong quán
        List<CustomerInShop> CustomerList = new List<CustomerInShop> { new CustomerInShop(0) };
        
        // Tài khoản của nhân viên/chủ quán đang đăng nhập vào
        Account account;

        // Lưu khách hàng hiện tại đang đặt món
        CustomerInShop CustomerNow;

        // Quản lý bàn đã được sử dụng hay chưa? UsedTableID[i] = false: chưa sử dụng, = true: đang được sử dụng
        bool[] UsedTableID;

        // Danh sách màu được khai báo để random tạo màu button ở panel Quản lý quán
        Color[] color = new Color[] {Color.Red, Color.Orange, Color.Goldenrod, Color.Green, Color.Blue, Color.Indigo, Color.Violet};

        public fSell(string userName)
        {
            Infomation.Instance.LoadInfo();
            this.UsedTableID = new bool[Int32.Parse(Infomation.Instance.shopTableID) + 1];
            for (int i = 0; i <= Int32.Parse(Infomation.Instance.shopTableID); i++)
            {
                this.UsedTableID[i] = false;
            }

            InitializeComponent();

            account = new Account(userName);

            #region Load dữ liệu
            LoadTableID();
            LoadMenu();
            LoadFood();
            #endregion
        }

        #region Method

        // Load menu (Món, giá) 
        void LoadMenu()
        {
            DataTable menu = FoodDAO.Instance.LoadMenu();

            this.dgvMenu.DataSource = menu;
        }
        
        // Load thông tin hóa đơn
        void LoadBillDetails()
        {
            this.dgvBill.DataSource = BillDetailDAO.Instance.LoadBillDetailsByBillID(this.CustomerNow.billID);
        }

        // Load danh sách món ăn ra phía của combobox Món
        void LoadFood()
        {
            DataTable food = FoodDAO.Instance.LoadOnlyFoodName();

            foreach (DataRow row in food.Rows)
            {
                cbFood.Items.Add(row["TENMON"]);
            }
        }

        // Load danh sách bàn đang có trong quán
        void LoadTableID()
        {
            this.cbTableID.Items.Clear();
            for (int i = 1; i <= Int32.Parse(Infomation.Instance.shopTableID); i++)
            {
                if (this.UsedTableID[i] == false)
                {
                    cbTableID.Items.Add(i);
                }
            }    
        }

        // Xóa bỏ dấu cách trong khi nhập SDT
        string ChuanHoaXau(string s)
        {
            if (s == "") return s;

            while (s[0] == ' ')
            {
                s = s.Remove(0, 1);
                if (s == "") return s;
            }
            while (s.IndexOf(' ') != -1)
            {
                s = s.Remove(s.IndexOf(' '), 1);
                if (s == "") return s;
            }
            while (s[s.Length - 1] == ' ')
            {
                s = s.Remove(s.Length - 1, 1);
                if (s == "") return s;
            }
            
            return s;
        }

        #endregion

        #region Events

        private void bAddCustomer_Click(object sender, EventArgs e)
        {
            fCustomerAdd f = new fCustomerAdd();
            f.ShowDialog();
        }

        private void bCustomerInfo_Click(object sender, EventArgs e)
        {
            fCustomerInfo f = new fCustomerInfo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void lGetOutOfFood_Click(object sender, EventArgs e)
        {
            fGetOutOfFoodList f = new fGetOutOfFoodList();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void lBillHistory_Click(object sender, EventArgs e)
        {
            fBillHistory f = new fBillHistory();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán");
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCustomerInfo f = new fCustomerInfo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thôngTinQuánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fShopInfomation f = new fShopInfomation();
            f.ShowDialog();
        }

        private void danhSáchMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFoodList f = new fFoodList();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStaffList f = new fStaffList();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCustomerList f = new fCustomerList();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void chươngTrìnhKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDiscountList f = new fDiscountList();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void lịchSửHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBillHistory f = new fBillHistory();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void lịchSửNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fImportHistory f = new fImportHistory();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void lịchSửHoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fActionHistory f = new fActionHistory();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void liênHệVớiNhàPhátTriểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(DataProvider.Instance.linkToConnectDeveloper);
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStaffInfo f = new fStaffInfo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hàngTrongKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStockList f = new fStockList();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void nhậpThêmHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStockAdd f = new fStockAdd();
            f.ShowDialog();
        }

        private void báoCáoVàThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fReport f = new fReport();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bAddFood_Click(object sender, EventArgs e)
        {
            // Kiểm tra chọn đầy đủ thông tin
            #region Kiểm tra 
            bool lackOfInfomation = false;
            if (this.cbTableID.Text == "")
            {
                this.cbTableID.BorderColor = Color.Red;
                lackOfInfomation = true;
            }
            if (this.cbFood.Text == "")
            {
                lackOfInfomation = true;
                this.cbFood.BorderColor = Color.Red;
            }
            if (lackOfInfomation == true)
            {
                return;
            }
            #endregion

            // Vẽ 1 button lên trên panel
            #region Vẽ button
            Random rand = new Random();

            Guna2GradientButton btn = new Guna2GradientButton();
            btn.Size = new Size(375, 27);
            btn.AutoRoundedCorners = true;
            btn.BackColor = Color.Transparent;
            btn.CheckedState.Parent = btn;
            btn.BorderRadius = 14;
            btn.CustomImages.Parent = btn;
            btn.Cursor = Cursors.Hand;
            btn.FillColor = this.color[rand.Next(0, color.Length)];
            btn.FillColor2 = this.color[rand.Next(0, color.Length)];
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            btn.ForeColor = Color.White;
            btn.HoverState.Parent = btn;
            btn.ShadowDecoration.Parent = btn;
            btn.BorderColor = Color.Black;
            btn.BorderThickness = 1; 

            btn.Click += Btn_Click;
            #endregion

            int idStaff = account.id;
            string SDT = this.tbCustomerSDT.Text;
            SDT = ChuanHoaXau(SDT);

            // Nếu có nhập sdt
            if (SDT != "")
            {
                // Không tồn tại khách hàng trong database sau khi tìm kiếm sdt
                if (!CustomerDAO.Instance.CheckExistCustomerInDatabaseBySDT(SDT))
                {
                    this.tbCustomerSDT.BorderColor = Color.Red;
                    this.tbCustomerName.BorderColor = Color.Red;
                    return;
                }
                // tồn tại
                else
                {
                    this.tbCustomerSDT.BorderColor = Color.Green;
                    this.tbCustomerName.BorderColor = Color.Green;
                }

                // Biến mất, vô hiệu hóa nút "Khách hàng mới"
                this.bNewCustomerInShop.Enabled = false;
                this.bNewCustomerInShop.BackColor = Color.Transparent;
                this.bNewCustomerInShop.FillColor = Color.Transparent;
                this.bNewCustomerInShop.Text = "";

                // id của khách hàng thông qua sdt
                int idCustomer = CustomerDAO.Instance.GetIDCustomerBySDT(SDT);

                // Nếu khách chưa tồn tại trong quán (đặt món đầu tiên) thì thêm một hóa đơn mới
                if (!this.UsedTableID[Int32.Parse(cbTableID.Text)])
                {
                    // thêm 1 hóa đơn mới vào database
                    BillDAO.Instance.CreateNewBill(idStaff, idCustomer);

                    // Thêm 1 khách hàng vào trong danh sách khách hàng
                    CustomerInShop newCustomer = new CustomerInShop(Int32.Parse(this.cbTableID.Text), SDT);
                    CustomerList.Add(newCustomer);

                    // Điều chỉnh lại khách hàng hiện tại
                    this.CustomerNow = newCustomer;

                    // Đánh dấu bàn đã được sử dụng
                    this.UsedTableID[Int32.Parse(cbTableID.Text)] = true;

                    btn.Name = SDT;
                    btn.Text = cbTableID.Text + " | " + (tbCustomerName.Text == "" ? "NULL" : tbCustomerName.Text + " | " + SDT);
                    // Thêm button vào panel
                    this.pnlManage.Controls.Add(btn);
                }
            }
            // Không nhập sdt (Khách hàng ẩn danh)
            else
            {
                // Nếu bàn này chưa có người sử dụng <=> khách hàng đặt món đầu tiên
                if (!this.UsedTableID[Int32.Parse(cbTableID.Text)])
                {
                    // thêm 1 hóa đơn mới vào database
                    BillDAO.Instance.CreateNewBill(idStaff);

                    // Thêm 1 khách hàng vào trong danh sách khách hàng
                    CustomerInShop newCustomer = new CustomerInShop(Int32.Parse(this.cbTableID.Text));
                    CustomerList.Add(newCustomer);

                    // Điều chỉnh lại khách hàng hiện tại
                    this.CustomerNow = newCustomer;

                    // Đánh dấu bàn đã được sử dụng
                    this.UsedTableID[Int32.Parse(cbTableID.Text)] = true;

                    btn.Name = "";
                    btn.Text = cbTableID.Text + " | " + "NULL" + " | " + "NULL";
                    // Thêm button vào panel
                    this.pnlManage.Controls.Add(btn);

                    // Mở lại nút "Khách hàng mới"
                    this.bNewCustomerInShop.Enabled = true;
                    this.bNewCustomerInShop.BackColor = Color.Transparent;
                    this.bNewCustomerInShop.FillColor = Color.MediumTurquoise;
                    this.bNewCustomerInShop.Text = "Khách hàng mới";
                } 
            }

            // Lấy ra ID của món ăn đang được chọn
            int idFood = FoodDAO.Instance.GetIDByNameFood(cbFood.Text);

            // Thêm món này vào hóa đơn
            FoodDAO.Instance.InsertFoodIntoBill(this.CustomerNow.billID, idFood, Convert.ToInt32(this.nudSL.Value), this.tbNote.Text);

            // Hiển thị lại thông tin hóa đơn
            LoadBillDetails();


            // Reset lại thông tin tránh để đặt nhầm nhiều lần
            this.cbFood.SelectedItem = null;
            this.nudSL.Value = 1;
            this.tbNote.Text = "";

            // Nếu khách đã đặt rồi thì không cho phép đổi bàn (Muốn đổi bản thì bấm button đổi bản, tránh trường hợp 1 khách mà đặt nhiều bàn)
            this.cbTableID.Text = this.CustomerNow.tableID.ToString();
            this.cbTableID.Enabled = false;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            
            string tableIDstr = "";
            for (int i = 0; i < btn.Text.IndexOf('|') - 1; i++)
            {
                tableIDstr = tableIDstr + btn.Text[i];
            }
            int tableID = Int32.Parse(tableIDstr);
            foreach (CustomerInShop item in CustomerList)
            {
                if (item.tableID == tableID)
                {
                    CustomerNow = item;

                    this.tbCustomerSDT.Text = item.sdt;
                    if (item.sdt != "")
                    {
                        this.tbCustomerName.Text = CustomerDAO.Instance.GetNameCustomerBySDT(item.sdt);
                    }
                    LoadBillDetails();
                    
                }
            }
        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbFood.BorderColor = Color.Black;
            if (this.cbFood.Text != "")
            {
                this.tbPrice.Text = FoodDAO.Instance.GetPriceByNameFood(cbFood.Text).ToString();
            }
        }
        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvMenu.SelectedRows[0];
            cbFood.Text = row.Cells["Món"].Value.ToString();
        }

        private void cbTableID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbTableID.BorderColor = Color.Black;
        }

        private void tbCustomerSDT_TextChanged(object sender, EventArgs e)
        {
            // Reset lại thông tin (tránh để bị giữ lại thông tin của khách trước đó)
            this.cbFood.SelectedItem = null;
            this.cbTableID.SelectedItem = null;
            this.dgvBill.DataSource = null;
            
            string SDT = this.tbCustomerSDT.Text;
            SDT = ChuanHoaXau(SDT);

            if (SDT == "")
            {
                this.tbCustomerSDT.BorderColor = Color.Black;
                this.tbCustomerName.BorderColor = Color.Black;
                this.tbCustomerName.Text = "";
                return;
            }

            // Không tồn tại SDT này trong Database
            if (!CustomerDAO.Instance.CheckExistCustomerInDatabaseBySDT(SDT))
            {
                this.tbCustomerName.BorderColor = Color.Red;
                this.tbCustomerSDT.BorderColor = Color.Red;
                this.tbCustomerName.Text = "";
            } 
            // Có tồn tại
            else
            {
                // Load lại combobox chọn bàn và cho phép sửa đổi nó
                LoadTableID();
                this.cbTableID.Enabled = true;

                this.tbCustomerSDT.BorderColor = Color.Green;
                this.tbCustomerName.BorderColor = Color.Green;

                // load ra tên
                this.tbCustomerName.Text = CustomerDAO.Instance.GetNameCustomerBySDT(SDT);
            }

            // Cho phép chọn bàn
            this.cbTableID.Enabled = true;
        }
        private void tbCustomerSDT_KeyPress(object sender, KeyPressEventArgs e)
        { 
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }
        private void bNewCustomerInShop_Click(object sender, EventArgs e)
        {
            // Biến mất, vô hiệu hóa nút "Khách hàng mới"
            this.bNewCustomerInShop.Enabled = false;
            this.bNewCustomerInShop.BackColor = Color.Transparent;
            this.bNewCustomerInShop.FillColor = Color.Transparent;
            this.bNewCustomerInShop.Text = "";

            // Reset lại bill
            this.dgvBill.DataSource = null;

            // dánh dấu là không có khách hàng
            this.CustomerNow = null;

            // Reset lại combobox chọn bàn
            this.cbTableID.Enabled = true;
            LoadTableID();
        }
        #endregion


    }
}
