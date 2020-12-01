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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.tbPassword.UseSystemPasswordChar = !this.tbPassword.UseSystemPasswordChar;
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            this.lNotification.Text = "";
            string userName = this.tbUsername.Text;
            string passWord = this.tbPassword.Text;
            if (Login(userName, passWord))
            {
                fSell f = new fSell(this.tbUsername.Text);
                this.Hide();
                f.ShowDialog();
                this.tbPassword.Text = "";
                this.cbxShowPassword.Checked = false;
                this.Show();
            }
            else
            {
                this.lNotification.Text = "Tên tài khoản hoặc mật khẩu không chính xác!";
            }
        }

        private bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void bCreateAccount_Click(object sender, EventArgs e)
        {
            fStaffAdd f = new fStaffAdd();
            f.ShowDialog();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            this.lNotification.Text = "";
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            this.lNotification.Text = "";
        }
    }
}
