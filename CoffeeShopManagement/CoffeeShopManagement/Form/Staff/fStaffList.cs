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
    public partial class fStaffList : Form
    {
        public fStaffList()
        {
            InitializeComponent();

            this.dgvShow.DataSource = StaffDAO.Instance.LoadStaffList();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bInfo_Click(object sender, EventArgs e)
        {
            fStaffInfo f = new fStaffInfo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            fStaffAdd f = new fStaffAdd();
            f.ShowDialog();
        }
    }
}
