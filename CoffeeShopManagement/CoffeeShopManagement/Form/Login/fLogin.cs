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
            fSell f = new fSell();
            this.Hide();
            this.tbPassword.Text = "";
            this.tbPassword.UseSystemPasswordChar = false;
            cbxShowPassword.Checked = false;
            f.ShowDialog();
            this.Show();
        }

        private void bCreateAccount_Click(object sender, EventArgs e)
        {
            fStaffAdd f = new fStaffAdd();
            f.ShowDialog();
        }
    }
}
