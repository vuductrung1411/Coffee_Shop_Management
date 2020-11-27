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
    public partial class fStaffInfo : Form
    {
        public fStaffInfo()
        {
            InitializeComponent();
        }

        private void bChangePassword_Click(object sender, EventArgs e)
        {
            fPasswordChange f = new fPasswordChange();
            f.ShowDialog();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bChangePassword_Click_1(object sender, EventArgs e)
        {
            fPasswordChange f = new fPasswordChange();
            f.ShowDialog();
        }
    }
}
