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
    public partial class fAccountAdd : Form
    {
        AccountInfo account;

        public fAccountAdd(AccountInfo infomation = null)
        {
            InitializeComponent();

            this.account = infomation;
        }

        private void cbxShow1_CheckedChanged(object sender, EventArgs e)
        {
            this.tbPassword.UseSystemPasswordChar = !this.tbPassword.UseSystemPasswordChar;
        }

        private void cbxShow2_CheckedChanged(object sender, EventArgs e)
        {
            this.tbConfirm.UseSystemPasswordChar = !this.tbConfirm.UseSystemPasswordChar;
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.CheckExistUsernameInDatabase(this.tbUsername.Text))
            {
                this.lNotificationUsername.Text = "Tên đăng nhập này đã tồn tại";
                this.tbUsername.BorderColor = Color.Red;
            }
            else
            {
                this.lNotificationUsername.Text = "";
                this.tbUsername.BorderColor = Color.Green;
            }

        }

        private void tbConfirm_TextChanged(object sender, EventArgs e)
        {
            if ((this.tbConfirm.Text.Length > this.tbPassword.Text.Length) || ((this.tbConfirm.Text.Length == this.tbPassword.Text.Length) && (this.tbConfirm.Text != this.tbPassword.Text)))
            {
                this.lNotificationConfirmPassword.ForeColor = Color.Red;
                this.lNotificationConfirmPassword.Text = "Mật khẩu không khớp";
                this.tbConfirm.BorderColor = Color.Red;

                return;
            }

            if (this.tbConfirm.Text == this.tbPassword.Text)
            {
                this.lNotificationConfirmPassword.ForeColor = Color.Green;
                this.lNotificationConfirmPassword.Text = "Mật khẩu khớp";
                this.tbConfirm.BorderColor = Color.Green;

                return;
            }    

            this.lNotificationConfirmPassword.Text = "";
            this.tbConfirm.BorderColor = Color.Black;

        }

        private void bConfirm_Click(object sender, EventArgs e)
        {
            string userName = this.tbUsername.Text;
            string passWord = this.tbPassword.Text;

            if (passWord != this.tbConfirm.Text)
            {
                return;
            }    

            if (AccountDAO.Instance.CheckExistUsernameInDatabase(userName))
            {
                this.lNotificationUsername.Text = "Tên đăng nhập này đã tồn tại";

                return;
            }
            
            this.lNotificationUsername.Text = "";

            AccountDAO.Instance.CreateNewAccountInfo(this.account);
            AccountDAO.Instance.CreateNewAccount(userName, passWord);

            int id = (int)DataProvider.Instance.ExecuteScalar("Select COUNT(*) from Accountinfo") - 1;

            MessageBox.Show("Tạo tài khoản thành công" + Environment.NewLine +
                "Mã nhân viên của bạn là: " + id, "THÀNH CÔNG!", MessageBoxButtons.OK);

            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
