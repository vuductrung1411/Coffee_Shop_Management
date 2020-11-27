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
    public partial class fCustomerList : Form
    {
        public fCustomerList()
        {
            InitializeComponent();

            this.dgvShow.DataSource = CustomerDAO.Instance.LoadCustomerList();

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            fCustomerAdd f = new fCustomerAdd();
            f.ShowDialog();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            fCustomerAdd f = new fCustomerAdd(true);
            f.ShowDialog();
        }

        private void bInfo_Click(object sender, EventArgs e)
        {
            fCustomerInfo f = new fCustomerInfo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
