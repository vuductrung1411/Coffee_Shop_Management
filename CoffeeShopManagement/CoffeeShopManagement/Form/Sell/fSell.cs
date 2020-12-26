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
        AccountInfo account;                        // Tài khoản của nhân viên/chủ quán đang đăng nhập vào

        Customer customerNow = new Customer();      // Khách hàng đang xét, nếu là khách vãng lai thì mặc định SDT = 0

        Table[] tableList = new Table[ShopInfo.Instance.soban + 1];

        public fSell(string userName)
        {
            this.account = AccountDAO.Instance.GetAccountInfoByUsername(userName);

            for (int i = 0; i <= ShopInfo.Instance.soban; i++)
            {
                this.tableList[i] = new Table();
            }


            InitializeComponent();

            this.rbKhachCoTheThanhVien.Checked = true;

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
            this.cbTable.Items.Clear();

            for (int i = 1; i <= ShopInfo.Instance.soban; i++)
            {
                this.cbTable.Items.Add((this.tableList[i].isEmpty == true ? "Bàn " + i.ToString() : "Bàn " + i.ToString() + " (Đã có khách)"));
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

        // Thêm button vào bên Manage
        void AddButton()
        {
            this.customerNow.btn.Name = (this.cbTable.SelectedIndex + 1).ToString() + (this.customerNow.isVangLai == true ? "VangLai" : this.customerNow.id.ToString());
            this.customerNow.btn.Text = "Bàn " + (this.cbTable.SelectedIndex + 1).ToString() + " | " + (this.customerNow.isVangLai == true ? "Khách vãng lai" : this.customerNow.hoten);

            this.pnlManage.Controls.Add(this.customerNow.btn);
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
            this.customerNow = new Customer();

            this.cbTable.Enabled = true;

            //this.rbKhachVangLai.Checked = true;
            //SetLayoutCustomerInfo(false, Color.Black);

            //this.rbKhachCoTheThanhVien.Checked = true;
            //SetLayoutCustomerInfo(true, Color.Black);

            this.tbCustomerSDT.Text = "";
            this.tbCustomerName.Text = "";
            this.tbCustomerMember.Text = "";
            this.tbCustomerAge.Text = "";
            this.tbFavoriteFood.Text = "";
            this.lNotificationCustomer.Text = "";

            this.cbTable.SelectedIndex = -1;
            this.cbTable.Enabled = true;
            this.cbTakeAway.Checked = false;
            this.cbTakeAway.Enabled = true;
            this.nudSLCustomer.Value = 1;
            this.cbFood.SelectedIndex = -1;
            this.nudSL.Value = 1;
            this.tbPrice.Text = "";
            this.lNoficationAddFood.Text = "";

            this.dgvBill.DataSource = null;

            this.tbTotalValue.Text = "";
            this.tbDiscountValue.Text = "";
            this.tbValuePayment.Text = "";
            this.bCheckout.Text = "Thanh toán";

            this.dgvBill.DataSource = null;
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
            this.bNewCustomer.PerformClick();
        }

        private void rbKhachCoTheThanhVien_CheckedChanged(object sender, EventArgs e)
        {
            SetLayoutCustomerInfo(true, Color.Black);
            this.bNewCustomer.PerformClick();
        }

        private void cbTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            this.cbTable.SelectedIndex = -1;
            this.cbTable.Enabled = !this.cbTable.Enabled;
        }

        private void bAddFood_Click(object sender, EventArgs e)
        {
            #region Xét các trường hợp chưa nhập đủ hoặc sai thông tin
            // Chưa chọn loại khách hàng
            if (this.rbKhachVangLai.Checked == false && this.rbKhachCoTheThanhVien.Checked == false)
            {
                this.lNoficationAddFood.Text = "Vui lòng chọn loại khách hàng.";

                return;
            }
            else
            {
                this.lNoficationAddFood.Text = "";
            }

            // Chưa chọn số bàn hay mua về
            if (this.cbTakeAway.Checked == false & this.cbTable.SelectedIndex == -1)
            {
                this.lNoficationAddFood.Text = "Vui lòng chọn Bàn/Mua mang về.";
                this.cbTable.BorderColor = Color.Red;

                return;
            }
            else
            {
                this.cbTable.BorderColor = Color.Black;
                this.lNoficationAddFood.Text = "";
            }

            // Chưa chọn món
            if (this.cbFood.SelectedIndex == -1)
            {
                this.lNoficationAddFood.Text = "Vui lòng chọn món.";
                this.cbFood.BorderColor = Color.Red;

                return;
            }
            else
            {
                this.cbFood.BorderColor = Color.Black;
                this.lNoficationAddFood.Text = "";
            }

            // Nhập số điện thoại nhưng sdt không tồn tại trong database
            if (this.rbKhachVangLai.Checked == false && CustomerDAO.Instance.CheckExistCustomerInDatabaseBySDT(this.tbCustomerSDT.Text) == false)
            {
                this.lNoficationAddFood.Text = "Khách hàng này không tồn tại trong cơ sở dữ liệu";
                return;
            }  
            else
            {
                this.lNoficationAddFood.Text = "";
            }

            #endregion

            // Nếu là khách vãng lai thì SDT của KH = 0
            if (this.rbKhachVangLai.Checked == true)
            {
                this.customerNow.isVangLai = true;
            }    
            // Nếu là khách có thẻ thành viên
            else
            {
                Customer tmp = CustomerDAO.Instance.getCustomerBySDT(this.tbCustomerSDT.Text);
                this.customerNow.isVangLai = false;
                this.customerNow.id = tmp.id;
                this.customerNow.sdt = tmp.sdt;
                this.customerNow.hoten = tmp.hoten;
                this.customerNow.gioitinh = tmp.gioitinh;
                this.customerNow.ngaysinh = tmp.ngaysinh;
            }


            // Nếu dùng tại quán
            if (this.cbTakeAway.Checked != true)
            {
                // Nếu là lần đầu thì thêm button đồng thời khóa bàn lại, và check lại bàn đã có người sử dụng
                if (this.customerNow.bill.nFood == 0)
                {
                    AddButton();
                    //this.cbTable.Enabled = false;
                    //this.cbTakeAway.Enabled = false;

                    this.customerNow.inTable = this.cbTable.SelectedIndex + 1;
                    this.tableList[this.customerNow.inTable].isEmpty = false;
                    LoadTableID();

                    this.cbTable.SelectedIndex = this.customerNow.inTable - 1;
                }
                // Nếu thêm món lần 2 trở đi
                else
                {
                    // Nếu có thay đổi số bàn
                    if (this.customerNow.inTable != this.cbTable.SelectedIndex + 1)
                    {
                        this.tableList[this.customerNow.inTable].isEmpty = true;

                        // Lưu lại số bàn mới
                        this.customerNow.inTable = this.cbTable.SelectedIndex + 1;
                        
                        this.tableList[this.cbTable.SelectedIndex + 1].isEmpty = false;
                        LoadTableID();

                        this.cbTable.SelectedIndex = this.customerNow.inTable - 1;

                        // Cập nhật lại Tên và Text của btn
                        this.customerNow.btn.Name = (this.cbTable.SelectedIndex + 1).ToString() + (this.customerNow.isVangLai == true ? "VangLai" : this.customerNow.id.ToString());
                        this.customerNow.btn.Text = "Bàn " + (this.cbTable.SelectedIndex + 1).ToString() + " | " + (this.customerNow.isVangLai == true ? "Khách vãng lai" : this.customerNow.hoten);
                    }
                }    
            }

            int foodID = FoodDAO.Instance.GetIDByNameFood(this.cbFood.Text);
            int foodSL = Convert.ToInt32(this.nudSL.Value);

            bool foodExist = false;         // Món này đã tồn tại trong hóa đơn hay chưa?

            for (int i = 0; i < this.customerNow.bill.nFood; i++)
            {
                if (this.customerNow.bill.arrFoodID[i] == foodID)
                {
                    foodExist = true;
                    this.customerNow.bill.arrFoodSL[i] += foodSL;

                    break;
                }    
            }    

            if (foodExist == false)
            {
                this.customerNow.bill.arrFoodID[this.customerNow.bill.nFood] = foodID;
                this.customerNow.bill.arrFoodSL[this.customerNow.bill.nFood] = foodSL;
                this.customerNow.bill.nFood++;
            }    

            this.dgvBill.DataSource = this.customerNow.bill.TakeBill();

            this.customerNow.bill.CalTotalValue();
            this.tbTotalValue.Text = this.customerNow.bill.TotalValue.ToString();
            if (this.tbDiscountValue.Text == "") this.tbDiscountValue.Text = "0";
            this.tbValuePayment.Text = (Int32.Parse(this.tbTotalValue.Text) - Int32.Parse(this.tbDiscountValue.Text) < 0 ? 0 : Int32.Parse(this.tbTotalValue.Text) - Int32.Parse(this.tbDiscountValue.Text)).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbDiscountValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbDiscountValue_TextChanged(object sender, EventArgs e)
        {
            if (this.tbDiscountValue.Text == "") this.tbDiscountValue.Text = "0";

            if (Int32.Parse(this.tbDiscountValue.Text) > 1000000000) this.tbDiscountValue.Text = "100000000";

            
            this.tbValuePayment.Text = (Int32.Parse(this.tbTotalValue.Text) - Int32.Parse(this.tbDiscountValue.Text) < 0 ? 0 : Int32.Parse(this.tbTotalValue.Text) - Int32.Parse(this.tbDiscountValue.Text)).ToString();
        }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bDeleteFood_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgvBill.SelectedRows[0];
            string tenmon = row.Cells["Món"].Value.ToString();

            this.customerNow.bill.DeleteFood(tenmon);
            this.customerNow.bill.CalTotalValue();
            this.dgvBill.DataSource = this.customerNow.bill.TakeBill();
            this.tbTotalValue.Text = this.customerNow.bill.TotalValue.ToString();
            if (this.tbDiscountValue.Text == "") this.tbDiscountValue.Text = "0";
            this.tbValuePayment.Text = (Int32.Parse(this.tbTotalValue.Text) - Int32.Parse(this.tbDiscountValue.Text) < 0 ? 0 : Int32.Parse(this.tbTotalValue.Text) - Int32.Parse(this.tbDiscountValue.Text)).ToString();
        }
    }
}
