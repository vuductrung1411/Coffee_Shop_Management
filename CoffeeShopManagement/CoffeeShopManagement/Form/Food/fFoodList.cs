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
    public partial class fFoodList : Form
    {
        public fFoodList()
        {
            InitializeComponent();

            this.dgvShow.DataSource = FoodDAO.Instance.LoadFoodList();

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            fFoodAdd f = new fFoodAdd();
            f.ShowDialog();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            fFoodAdd f = new fFoodAdd(1);
            f.ShowDialog();
        }

        private void bInfo_Click(object sender, EventArgs e)
        {
            fFoodAdd f = new fFoodAdd(2);
            f.ShowDialog();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
