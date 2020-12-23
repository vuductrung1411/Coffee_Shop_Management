using CoffeeShopManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class fCustomerAdd : Form
    {
        bool kindProcess;

        public fCustomerAdd(bool edit = false)
        {
            this.kindProcess = edit;

            InitializeComponent();
            
            if (edit == true)
            {
                this.lTitle.Text = "Chỉnh sửa thông tin khách hàng";
                this.bOK.Text = "Lưu";
            }
        }

        public fCustomerAdd(string sdt, string name)
        {
            InitializeComponent();

            this.tbName.Text = name;
            this.tbSDT.Text = sdt;
        }

        #region METHODS

        // Reset lại thông tin
        void ResetInformation()
        {
            this.tbName.Text = "";
            this.tbSDT.Text = "";
            this.cbGender.SelectedItem = null;
            this.cbGender.BorderColor = Color.Black;
        }

        #endregion

        #region EVENTS
        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            // Thêm khách hàng mới
            if (this.kindProcess == false)
            {
                string SDT = this.tbSDT.Text;

                // Kiểm tra xem đã nhập đủ thông tin cần thiết hay chưa
                #region Kiểm tra
                // SDT
                if (SDT == "")
                {
                    this.tbSDT.BorderColor = Color.Red;
                    this.lNotificationSDT.Text = "Vui lòng nhập số điện thoại";

                    return;
                }
                else
                {
                    this.tbSDT.BorderColor = Color.Black;
                    this.lNotificationSDT.Text = "";
                }
                // Giới tính
                if (this.cbGender.SelectedItem == null)
                {
                    this.cbGender.BorderColor = Color.Red;

                    return;
                }    
                else
                {
                    this.cbGender.BorderColor = Color.Green;
                }

                #endregion
                // Kiểm tra xem đã tồn tại SDT này trong Database hay chưa. Nếu tồn tại rồi thì từ chối thêm
                // Chưa tồn tại => Cho phép thêm
                if (!CustomerDAO.Instance.CheckExistCustomerInDatabaseBySDT(SDT))
                {
                    this.tbSDT.BorderColor = Color.Green;
                    this.lNotificationSDT.Text = "";

                    // Thêm khách hàng mới vào database
                    CustomerDAO.Instance.CreateNewCustomer(this.tbName.Text, SDT, this.cbGender.Text, this.dtpBirthdate.Value);

                    // Thông báo tạo tài khoản thành công
                    MessageBox.Show("Tạo khách hàng mới thành công", "THÔNG BÁO!", MessageBoxButtons.OK);

                    // Reset lại thông tin
                    ResetInformation();
                }
                // Đã tồn tại => Không cho phép thêm
                else
                {
                    this.lNotificationSDT.Text = "Số điện thoại này đã tồn tại trong cơ sở dữ liệu.";
                    this.tbSDT.BorderColor = Color.Red;             

                    return;
                }
            }
            // Sửa thông tin khách hàng
            else
            {

            }    
        }

        private void tbSDT_TextChanged(object sender, EventArgs e)
        {
            // Thêm khách hàng mới
            if (this.kindProcess == false)
            {
                string SDT = this.tbSDT.Text;

                if (SDT == "")
                {
                    this.tbSDT.BorderColor = Color.Black;
                    this.lNotificationSDT.Text = "";
                    return;
                }    

                if (!CustomerDAO.Instance.CheckExistCustomerInDatabaseBySDT(SDT))
                {
                    this.tbSDT.BorderColor = Color.Green;
                    this.lNotificationSDT.Text = "";
                }    
                else
                {
                    this.tbSDT.BorderColor = Color.Red;
                    this.lNotificationSDT.Text = "Khách hàng này đã tồn tại trong cơ sở dữ liệu!";
                }    
            }    
        }
        #endregion
    }
}
