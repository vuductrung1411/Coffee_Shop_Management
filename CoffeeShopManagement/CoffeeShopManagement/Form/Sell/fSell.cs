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
        AccountInfo account; // Tài khoản của nhân viên/chủ quán đang đăng nhập vào

        // Danh sách màu được khai báo để random tạo màu button ở panel Quản lý quán
        Color[] color = new Color[] {Color.Red, Color.Orange, Color.Goldenrod, Color.Green, Color.Blue, Color.Indigo, Color.Violet};

        Customer customerNow = new Customer();

        public fSell(string userName)
        {
            account = AccountDAO.Instance.GetAccountInfoByUsername(userName);

            InitializeComponent();

            

            #region Load dữ liệu
            LoadMenu();
            LoadFood();
            LoadTableID();
            #endregion
        }

        #region METHODS

        // Load menu (Món, giá) 
        void LoadMenu()
        {
            DataTable menu = FoodDAO.Instance.LoadMenu();

            this.dgvMenu.DataSource = menu;
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

        // Load số bàn/id ra combobox Bàn/ID
        void LoadTableID()
        {
            for (int i = 0; i < ShopInfo.Instance.soban; i++)
            {
                this.cbTableID.Items.Add(i);
            }    
        }


        // Tô màu và Enable Thông tin khách hàng
        void SetLayoutCustomerInfo(bool allowEnable, Color color)
        {
            this.tbCustomerSDT.Enabled = allowEnable;
            this.tbCustomerName.Enabled = allowEnable;
            this.tbCustomerMember.Enabled = allowEnable;
            this.tbCustomerAge.Enabled = allowEnable;
            this.tbFavoriteFood.Enabled = allowEnable;

            this.tbCustomerSDT.BorderColor = color;
            this.tbCustomerName.BorderColor = color;
            this.tbCustomerMember.BorderColor = color;
            this.tbCustomerAge.BorderColor = color;
            this.tbFavoriteFood.BorderColor = color;
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

            // Load lại thông tin
            string tmp = this.tbCustomerSDT.Text;
            this.tbCustomerSDT.Text = "";
            this.tbCustomerSDT.Text = tmp;
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

        private void tbCustomerSDT_KeyPress(object sender, KeyPressEventArgs e)
        { 
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        #endregion

        private void bNewCustomer_Click(object sender, EventArgs e)
        {
            this.rbKhachVangLai.Checked = true;
            SetLayoutCustomerInfo(false, Color.Black);
        }

        private void tbCustomerSDT_TextChanged(object sender, EventArgs e)
        {
            // Nếu không nhập gì
            if (this.tbCustomerSDT.Text == "")
            {
                SetLayoutCustomerInfo(true, Color.Black);
                this.lNotificationCustomer.Text = "";
                return;
            }

            string sdt = this.tbCustomerSDT.Text;

            // Nếu sdt đang nhập không tồn tại trong cơ sở dữ liệu
            if (CustomerDAO.Instance.CheckExistCustomerInDatabaseBySDT(sdt) == false)
            {
                SetLayoutCustomerInfo(true, Color.Red);
                this.lNotificationCustomer.Text = "Khách hàng này chưa tồn tại trong cơ sở dữ liệu.";

                this.tbCustomerName.Text = "";
                this.tbCustomerMember.Text = "";
                this.tbCustomerAge.Text = "";
                this.tbFavoriteFood.Text = "";
            }
            // Nếu sdt này đã tồn tại trong cơ sở dữ liệu
            else
            {
                SetLayoutCustomerInfo(true, Color.Green);
                this.lNotificationCustomer.Text = "";

                // Lấy ra thông tin khách hàng
                this.customerNow = CustomerDAO.Instance.getCustomerBySDT(sdt);

                this.tbCustomerName.Text = this.customerNow.hoten;
                this.tbCustomerAge.Text = (DateTime.Today.Year - this.customerNow.ngaysinh.Year).ToString();
                // Kiểm tra xem hôm nay có phải sinh nhật khách hay không
                if (DateTime.Today.Month == this.customerNow.ngaysinh.Month && DateTime.Today.Day == this.customerNow.ngaysinh.Day)
                {
                    this.tbCustomerAge.Text += " (Hôm nay là sinh nhật của khách)";
                }    

            }    
        }

        private void rbKhachVangLai_CheckedChanged(object sender, EventArgs e)
        {
            SetLayoutCustomerInfo(false, Color.Black);
        }

        private void rbKhachCoTheThanhVien_CheckedChanged(object sender, EventArgs e)
        {
            SetLayoutCustomerInfo(true, Color.Black);
        }

        private void cbTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            this.cbTableID.SelectedIndex = -1;
            this.cbTableID.Enabled = !this.cbTableID.Enabled;
        }
    }
}
