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
    public partial class fFoodList : fMainForm
    {
        public fFoodList()
        {
            InitializeComponent();
            LoadFoodList();
        }

        void LoadFoodList()
        {
            dgvListFood.DataSource = FoodDAO.Instance.LoadFoodList();
        }


        private void bAdd_Click(object sender, EventArgs e)
        {
            fFoodAdd f = new fFoodAdd();
            f.ShowDialog();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            fFoodEdit f = new fFoodEdit();
            f.ShowDialog();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
