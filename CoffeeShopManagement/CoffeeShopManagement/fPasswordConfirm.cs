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
    public partial class fPasswordConfirm : fMainForm
    {
        public fPasswordConfirm()
        {
            InitializeComponent();
        }

        private void pbShowPassword_Click(object sender, EventArgs e)
        {
            this.tbPassword.UseSystemPasswordChar = !this.tbPassword.UseSystemPasswordChar;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
