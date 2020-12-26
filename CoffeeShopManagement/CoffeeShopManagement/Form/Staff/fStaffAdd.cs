using CoffeeShopManagement.DTO;
using QuanLyQuanCafe.DAO;
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
    public partial class fStaffAdd : Form
    {
        public fStaffAdd()
        {
            InitializeComponent();

            LoadPositionList();

            this.tbID.Text = ((int)DataProvider.Instance.ExecuteScalar("Select count(*) from accountinfo")).ToString();
        }

        #region METHODS

        // Đọc ra danh sách chức vụ rồi đưa vào combobox Chức vụ
        void LoadPositionList()
        {
            for (int i = 0; i < ShopInfo.Instance.nPosition; i++)
            {
                this.cbPosition.Items.Add(ShopInfo.Instance.PositionList[i]);
            }

            this.cbPosition.Items.Add("ADMIN");
        }

        // Reset thông tin
        void ResetInfomation()
        {
            this.tbName.Text = "";
            this.tbName.BorderColor = Color.Black;

            this.tbSDT.Text = "";
            this.tbSDT.BorderColor = Color.Black;

            this.cbPosition.SelectedItem = null;
            this.cbPosition.BorderColor = Color.Black;

            this.nudSalary.Value = 0;
            this.nudSalary.BorderColor = Color.Black;

            this.tbCMND.Text = "";
            this.tbCMND.BorderColor = Color.Black;

            this.dtpStartWorking.Value = DateTime.Now;
            this.dtpStartWorking.BorderColor = Color.Black;

            this.dtpBirthDate.Value = DateTime.Now;
            this.dtpBirthDate.BorderColor = Color.Black;

            this.cbGender.SelectedItem = null;
            this.cbGender.BorderColor = Color.Black;

            this.tbAddress.Text = "";
            this.tbAddress.BorderColor = Color.Black;
        }

        // Kiểm tra xem thông tin đầu vào đã ok chưa? Nếu không ok không cho phép thêm vào database
        bool CheckInputInfo()
        {
            bool ok = true;

            if (this.tbName.Text == "")
            {
                this.tbName.BorderColor = Color.Red;
                
                ok = false;
            }    
            else
            {
                this.tbName.BorderColor = Color.Green;
            }

            if (this.tbSDT.Text == "")
            {
                this.tbSDT.BorderColor = Color.Red;
                this.lNotificationSDT.Text = "Vui lòng nhập số điện thoại";

                ok = false;
            }
            else
            {
                this.tbSDT.BorderColor = Color.Green;
                this.lNotificationSDT.Text = "";

                // Check xem SDT đã tồn tại hay chưa
                if (AccountDAO.Instance.CheckExistAccountInDatabaseBySDT(this.tbSDT.Text))
                {
                    this.tbSDT.BorderColor = Color.Red;
                    this.lNotificationSDT.Text = "SDT này đã tồn tại trong database";

                    ok = false;
                }
            }    

            if (this.cbPosition.SelectedItem == null)
            {
                this.cbPosition.BorderColor = Color.Red;

                ok = false;
            }    
            else
            {
                this.cbPosition.BorderColor = Color.Green;
            }    
            
            if (this.nudSalary.Value == 0)
            {
                this.nudSalary.BorderColor = Color.Red;
                
                ok = false;
            }    
            else
            {
                this.nudSalary.BorderColor = Color.Green;
            }    

            if (this.tbCMND.Text == "")
            {
                this.tbCMND.BorderColor = Color.Red;
                this.lNotificationCMND.Text = "Vui lòng nhập CMND/CCCD";

                ok = false;
            }
            else
            {
                this.tbCMND.BorderColor = Color.Green;
                this.lNotificationCMND.Text = "";

                if (AccountDAO.Instance.CheckExistAccountInDatabaseByCMND(this.tbCMND.Text))
                {
                    this.tbCMND.BorderColor = Color.Red;
                    this.lNotificationCMND.Text = "Số CMND/CCCD này đã tồn tại trong database";

                    ok = false;
                }    
            }

            if (DateTime.Now.Year - this.dtpBirthDate.Value.Year < 18)
            {
                this.dtpBirthDate.BorderColor = Color.Red;
                this.lNotificationBirthdate.Text = "Sử dụng lao động dưới 18 tuổi là vi phạm pháp luật";

                ok = false;
            }
            else
            {
                this.dtpBirthDate.BorderColor = Color.Green;
                this.lNotificationBirthdate.Text = "";
            }    

            if (this.cbGender.SelectedItem == null)
            {
                this.cbGender.BorderColor = Color.Red;

                ok = false;
            }
            else
            {
                this.cbGender.BorderColor = Color.Green;
            }

            if (this.tbAddress.Text == "")
            {
                this.tbAddress.BorderColor = Color.Red;

                ok = false;
            }
            else
            {
                this.tbAddress.BorderColor = Color.Green;
            }


            return ok;
        }

        #endregion


        #region EVENTS

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tbSDT_TextChanged(object sender, EventArgs e)
        {
            string SDT = this.tbSDT.Text;

            if (AccountDAO.Instance.CheckExistAccountInDatabaseBySDT(SDT))
            {
                this.lNotificationSDT.Text = "SDT này đã tồn tại trong database";
                this.tbSDT.BorderColor = Color.Red;

                return;
            }

            this.lNotificationSDT.Text = "";
            this.tbSDT.BorderColor = Color.Black;
        }

        private void tbCMND_TextChanged(object sender, EventArgs e)
        {
            string cmnd = this.tbCMND.Text;

            if (AccountDAO.Instance.CheckExistAccountInDatabaseByCMND(cmnd))
            {
                this.lNotificationCMND.Text = "Số CMND/CCCD này đã tồn tại trong database";
                this.tbCMND.BorderColor = Color.Red;

                return;
            }

            this.lNotificationCMND.Text = "";
            this.tbCMND.BorderColor = Color.Black;
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
            // Kiểm tra thông tin đầu vào
            if (!CheckInputInfo())
            {
                return;
            }

            AccountInfo account = new AccountInfo(
                this.tbName.Text, this.tbSDT.Text, this.cbPosition.Text, 
                (this.cbPosition.Text == "ADMIN" ? 1 : 0), (int)this.nudSalary.Value,
                this.tbCMND.Text, this.dtpBirthDate.Value,
                this.tbAddress.Text, this.dtpStartWorking.Value,
                this.cbGender.Text);

            fAccountAdd f = new fAccountAdd(account);
            f.ShowDialog();

            this.Close();
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Now.Year - this.dtpBirthDate.Value.Year < 18)
            {
                this.dtpBirthDate.BorderColor = Color.Red;
                this.lNotificationBirthdate.Text = "Sử dụng lao động dưới 18 tuổi là vi phạm pháp luật";
            }
            else
            {
                this.dtpBirthDate.BorderColor = Color.Green;
                this.lNotificationBirthdate.Text = "";
            }
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbGender.Text != "")
            {
                this.cbGender.BorderColor = Color.Black;
            }
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            if (this.tbAddress.Text != "")
            {
                this.tbAddress.BorderColor = Color.Black;
            }
        }

        private void tbCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        #endregion


    }
}
