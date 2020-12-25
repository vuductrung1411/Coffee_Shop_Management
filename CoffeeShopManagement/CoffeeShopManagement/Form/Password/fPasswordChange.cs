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
    public partial class fPasswordChange : Form
    {
        AccountInfo account;

        string password;

        bool okOldPass = true, okNewPass;

        public fPasswordChange()
        {
            InitializeComponent();
        }

        public fPasswordChange(AccountInfo staff)
        {
            InitializeComponent();

            this.account = staff;

            // Lấy ra Password
            this.password = AccountDAO.Instance.GetPasswordByID(this.account.id);
            
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbOldPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.tbOldPassword.Text == "")
            {
                this.tbOldPassword.BorderColor = Color.Black;
                this.lOldPassNotification.Text = "";
            }    

            // Nếu mật khẩu không chính xác
            if (AccountDAO.Instance.Encode(this.tbOldPassword.Text) != this.password)
            {
                this.lOldPassNotification.Text = "Mật khẩu không chính xác";
                this.lOldPassNotification.ForeColor = Color.Red;

                this.tbOldPassword.BorderColor = Color.Red;

                this.okOldPass = false;
            }
            // Mật khẩu chính xác
            else
            {
                this.lOldPassNotification.Text = "Mật khẩu chính xác";
                this.lOldPassNotification.ForeColor = Color.Green;

                this.tbOldPassword.BorderColor = Color.Green;

                this.okOldPass = true;
            }
        }

        private void cbxShow2_CheckedChanged(object sender, EventArgs e)
        {
            this.tbNewPassword.UseSystemPasswordChar = !this.tbNewPassword.UseSystemPasswordChar;
        }

        private void cbShow3_CheckedChanged(object sender, EventArgs e)
        {
            this.tbConfirm.UseSystemPasswordChar = !this.tbConfirm.UseSystemPasswordChar;
        }

        private void bConfirm_Click(object sender, EventArgs e)
        {
            if (this.okOldPass == true && this.okNewPass == true)
            {
                AccountDAO.Instance.UpdatePasswordByID(account.id, this.tbNewPassword.Text);

                MessageBox.Show("Thay đổi mật khẩu thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void cbxShow1_CheckedChanged(object sender, EventArgs e)
        {
            this.tbOldPassword.UseSystemPasswordChar = !this.tbOldPassword.UseSystemPasswordChar;
        }

        private void tbConfirm_TextChanged(object sender, EventArgs e)
        {
            if (this.tbConfirm.Text == "")
            {
                this.lPasswordNotification.Text = "";
                this.okNewPass = false;
            }

            // Mật khẩu không khớp nhau
            if (this.tbConfirm.Text != this.tbNewPassword.Text)
            {
                this.lPasswordNotification.Text = "Mật khẩu không khớp";
                this.lPasswordNotification.ForeColor = Color.Red;

                this.tbNewPassword.BorderColor = Color.Red;
                this.tbConfirm.BorderColor = Color.Red;

                this.okNewPass = false;
            }
            // Mật khẩu khớp nhau
            else
            {
                this.lPasswordNotification.Text = "Mật khẩu khớp";
                this.lPasswordNotification.ForeColor = Color.Green;

                this.tbConfirm.BorderColor = Color.Green;
                this.tbNewPassword.BorderColor = Color.Green;

                this.okNewPass = true;
            }
            
        }
    }
}
