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
    public partial class fPasswordChange : fMainForm
    {
        public fPasswordChange()
        {
            InitializeComponent();
        }

        private void pbShowOldPassword_Click(object sender, EventArgs e)
        {
            this.tbOldPassword.UseSystemPasswordChar = !this.tbOldPassword.UseSystemPasswordChar;
        }

        private void pbShowNewPassword_Click(object sender, EventArgs e)
        {
            this.tbNewPassword.UseSystemPasswordChar = !this.tbNewPassword.UseSystemPasswordChar;
        }

        private void pbShowConfirm_Click(object sender, EventArgs e)
        {
            this.tbConfirm.UseSystemPasswordChar = !this.tbConfirm.UseSystemPasswordChar;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
