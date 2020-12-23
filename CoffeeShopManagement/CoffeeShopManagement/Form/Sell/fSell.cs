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
        List<Customer> CustomerList = new List<Customer> { new Customer(0) };
        
        // Tài khoản của nhân viên/chủ quán đang đăng nhập vào
        AccountInfo account;

        // Lưu khách hàng hiện tại đang đặt món
        Customer CustomerNow;

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

            account = AccountDAO.Instance.GetAccountInfoByUsername(userName);

            InitializeComponent();

            

            #region Load dữ liệu
            LoadTableID();
            LoadMenu();
            LoadFood();
            #endregion
        }

        #region METHODS

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

        /// <summary>
        /// Reset lại thông tin (Khi có khách hàng mới)
        /// </summary>
        /// <param name="kind"></param> 1: không xóa SDT
        void ResetInfomation(int kind = 0)
        {
            if (kind == 0)
                this.tbCustomerSDT.Text = "";
            this.tbCustomerName.Text = "";
            this.tbCustomerMember.Text = "";
            this.tbCustomerAge.Text = "";
            this.tbFavoriteFood.Text = "";

            this.nudSLCustomer.Value = 1;
            this.cbFood.SelectedItem = null;
            this.nudSL.Value = 1;
            this.tbPrice.Text = "";
            this.tbNote.Text = "";

            this.dgvBill.DataSource = null;
            this.cbTableID.SelectedItem = null;
            this.cbxTakeOut.Checked = false;

            this.tbTotalValue.Text = "";
            this.tbDiscountValue.Text = "";
            this.tbValuePayment.Text = "";
        }

        // Kiểm tra xem có tồn tại khách hàng hay không thông qua sdt được nhập
        // true: có, false: không
        bool CheckExistsCustomer(string sdt)
        {
            return CustomerDAO.Instance.CheckExistCustomerInDatabaseBySDT(sdt);
        }

        // Tô màu border cho mục "Thông tin khách hàng"
        // 0: màu đen (Không có gì); 1: màu đỏ (Thông tin sdt không có trong database); 2: màu xanh lá cây (Có tồn tại khách hàng)
        void BorderColorCustomer(int idColor)
        {
            switch (idColor)
            {
                case 0:
                    this.tbCustomerSDT.BorderColor = Color.Black;
                    this.tbCustomerName.BorderColor = Color.Black;
                    this.tbCustomerMember.BorderColor = Color.Black;
                    this.tbCustomerAge.BorderColor = Color.Black;
                    this.tbFavoriteFood.BorderColor = Color.Black;
                    break;
                case 1:
                    this.tbCustomerSDT.BorderColor = Color.Red;
                    this.tbCustomerName.BorderColor = Color.Red;
                    this.tbCustomerMember.BorderColor = Color.Red;
                    this.tbCustomerAge.BorderColor = Color.Red;
                    this.tbFavoriteFood.BorderColor = Color.Red;
                    break;
                case 2:
                    this.tbCustomerSDT.BorderColor = Color.Green;
                    this.tbCustomerName.BorderColor = Color.Green;
                    this.tbCustomerMember.BorderColor = Color.Green;
                    this.tbCustomerAge.BorderColor = Color.Green;
                    this.tbFavoriteFood.BorderColor = Color.Green;
                    break;
            }    
        }

        /// <summary>
        ///  Thêm khách hàng mới vào trong quán
        /// </summary>
        /// <param name="CustomerSDT"></param> SDT được nhập trong textbox
        /// <param name="btnName"></param> Tên của btn được tạo mới
        /// <param name="btnText"></param> Text của btn được tạo mới
        void NewCustomerInShop(string CustomerSDT, string btnName, string btnText)
        {
            // lấy ra id của nhân viên
            int idStaff = this.account.id;

            // id của khách hàng thông qua sdt
            int idCustomer = CustomerDAO.Instance.GetIDCustomerBySDT(CustomerSDT);

            // thêm 1 hóa đơn mới vào database
            BillDAO.Instance.CreateNewBill(idStaff, idCustomer);

            // Thêm 1 khách hàng vào trong danh sách khách hàng
            Customer newCustomer = new Customer(Int32.Parse(this.cbTableID.Text), CustomerSDT);
            CustomerList.Add(newCustomer);

            // Điều chỉnh lại khách hàng hiện tại
            this.CustomerNow = newCustomer;

            // Đánh dấu bàn đã được sử dụng
            this.UsedTableID[Int32.Parse(cbTableID.Text)] = true;

            // Vẽ thêm 1 button
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

            btn.Name = btnName;
            btn.Text = btnText;

            // Thêm button vào panel
            this.pnlManage.Controls.Add(btn);
        }

        #endregion

        #region EVENTS

        private void bAddCustomer_Click(object sender, EventArgs e)
        {
            if (CustomerDAO.Instance.CheckExistCustomerInDatabaseBySDT(this.tbCustomerSDT.Text))
            {
                this.lNotificationCustomer.Text = "Khách hàng này đã tồn tại trong dữ liệu";

                return;
            }    
            else
            {
                this.lNotificationCustomer.Text = "";
            }    

            fCustomerAdd f = new fCustomerAdd(this.tbCustomerSDT.Text, this.tbCustomerName.Text);
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
            fCustomerInfo f;

            if (CustomerDAO.Instance.CheckExistCustomerInDatabaseBySDT(this.tbCustomerSDT.Text))
            {
                f = new fCustomerInfo(this.tbCustomerSDT.Text);
            }
            else
            {
                f = new fCustomerInfo();
            }    
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
            fStaffInfo f = new fStaffInfo(account);
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
            
            if (this.cbTableID.Text == "" || this.cbFood.Text == "")
            {
                if (this.cbTableID.Text == "")
                    this.cbTableID.BorderColor = Color.Red;
                if (this.cbFood.Text == "")
                    this.cbFood.BorderColor = Color.Red;

                return;
            }
            
            #endregion

            string SDT = this.tbCustomerSDT.Text;

            // Nếu có nhập sdt
            if (SDT != "")
            {
                // Không tồn tại khách trong database
                if (!CheckExistsCustomer(SDT))
                {
                    BorderColorCustomer(1);
                    return;
                }    
                // Tồn tại khách trong database
                else
                {
                    BorderColorCustomer(2);
                }

                // Nếu khách chưa tồn tại trong quán (đặt món đầu tiên) thì thêm một hóa đơn mới
                if (!this.UsedTableID[Int32.Parse(cbTableID.Text)])
                {
                    string btnText = cbTableID.Text + " | " + (tbCustomerName.Text == "" ? "NULL" : tbCustomerName.Text + " | " + SDT);
                    NewCustomerInShop(SDT, SDT, btnText);
                }
            }
            // Không nhập sdt (Khách hàng ẩn danh)
            else
            {
                // Nếu bàn này chưa có người sử dụng <=> khách hàng đặt món đầu tiên
                if (!this.UsedTableID[Int32.Parse(cbTableID.Text)])
                {
                    string btnText = cbTableID.Text + " | " + "NULL" + " | " + "NULL";
                    NewCustomerInShop(SDT, SDT, btnText);
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
            foreach (Customer item in CustomerList)
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
            ResetInfomation(1);
            
            string SDT = this.tbCustomerSDT.Text;

            if (SDT == "")
            {
                BorderColorCustomer(0);
                ResetInfomation();
                this.lNotificationCustomer.Text = "";

                return;
            }

            // Không tồn tại SDT này trong Database
            if (!CheckExistsCustomer(SDT))
            {
                BorderColorCustomer(1);
                ResetInfomation(1);
                this.lNotificationCustomer.Text = "Không tồn tại khách hàng này trong dữ liệu";
            } 
            // Có tồn tại
            else
            {
                // Load lại combobox chọn bàn và cho phép sửa đổi nó
                LoadTableID();
                this.cbTableID.Enabled = true;

                this.lNotificationCustomer.Text = "";

                BorderColorCustomer(2);

                // load ra thông tin khách hàng
                this.tbCustomerName.Text = CustomerDAO.Instance.GetNameCustomerBySDT(SDT);
                /*Thêm mấy cái còn lại nữa*/
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
