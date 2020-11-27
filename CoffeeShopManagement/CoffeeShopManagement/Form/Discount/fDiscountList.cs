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
    public partial class fDiscountList : Form
    {
        public fDiscountList()
        {
            InitializeComponent();

            this.dgvShow.DataSource = DiscountDAO.Instance.LoadDiscountList();

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            fDiscountAdd f = new fDiscountAdd();
            f.ShowDialog();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            fDiscountAdd f = new fDiscountAdd(1);
            f.ShowDialog();
        }

        private void bInfo_Click(object sender, EventArgs e)
        {
            fDiscountAdd f = new fDiscountAdd(2);
            f.ShowDialog();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
