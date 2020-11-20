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
    public partial class fLogin : fMainForm
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.tbPassword.UseSystemPasswordChar = !this.tbPassword.UseSystemPasswordChar;
        }

        private void lConnectToDeveloper_Click(object sender, EventArgs e)
        {
            Process.Start(DataProvider.Instance.linkToConnectDeveloper);
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            this.lNotification.Text = "";
            string userName = this.tbUsername.Text;
            string passWord = this.tbPassword.Text;
            if (Login(userName, passWord))
            {
                fSell f = new fSell();
                this.Hide();
                f.ShowDialog();
                this.tbPassword.Text = "";
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

        private void fLogin_Load(object sender, EventArgs e)
        {

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
