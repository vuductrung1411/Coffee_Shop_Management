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

            this.cbKindStaff.SelectedIndex = 0;
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

        private void cbKindStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Danh sách đang làm việc
            if (this.cbKindStaff.SelectedIndex == 0)
            {
                this.dgvShow.DataSource = StaffDAO.Instance.LoadStaffList();
            }

            // Danh sách đã nghỉ việc
            if (this.cbKindStaff.SelectedIndex == 1)
            {
                this.dgvShow.DataSource = StaffDAO.Instance.LoadLayOffStaffList();
            }

            // Danh sách admin
            if (this.cbKindStaff.SelectedIndex == 2)
            {
                this.dgvShow.DataSource = StaffDAO.Instance.LoadAdminList();
            }

        }
    }
}
