using CoffeeShopManagement.DAO;
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
    public partial class fCustomerList : fMainForm
    {
        public fCustomerList()
        {
            InitializeComponent();
            LoadCustomerList();
        }

        void LoadCustomerList()
        {
            dgvList.DataSource = CustomerDAO.Instance.LoadCustomerList();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            fCustomerAdd f = new fCustomerAdd();
            f.ShowDialog();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            fCustomerInfo f = new fCustomerInfo();
            f.ShowDialog();
        }

        private void bView_Click(object sender, EventArgs e)
        {
            fCustomerInfo f = new fCustomerInfo();
            f.ShowDialog();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
