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
    public partial class fStaffList : fMainForm
    {
        public fStaffList()
        {
            InitializeComponent();
            LoadStaffList();
        }

        void LoadStaffList()
        {
            dgvList.DataSource = StaffDAO.Instance.LoadStaffList();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            fStaffAdd f = new fStaffAdd();
            f.ShowDialog();
        }

        private void bView_Click(object sender, EventArgs e)
        {
            fStaffInfo f = new fStaffInfo();
            f.ShowDialog();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            fStaffInfo f = new fStaffInfo();
            f.ShowDialog();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
