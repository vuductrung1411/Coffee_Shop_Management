﻿using System;
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
    public partial class fCustomerInfo : fMainForm
    {
        public fCustomerInfo()
        {
            InitializeComponent();
        }

        private void lEditCustomerName_Click(object sender, EventArgs e)
        {
            this.tbCustomerName.ReadOnly = false;
            this.tbCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
    }
}
