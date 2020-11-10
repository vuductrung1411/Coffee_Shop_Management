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
    public partial class fDiscountList : fMainForm
    {
        public fDiscountList()
        {
            InitializeComponent();
            LoadDisconntList();
        }

        void LoadDisconntList()
        {
            dgvList.DataSource = DiscountDAO.Instance.LoadDiscountList();
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            fDiscountAdd f = new fDiscountAdd();
            f.ShowDialog();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            fDiscountEdit f = new fDiscountEdit();
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
