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
    public partial class fStockList : fMainForm
    {
        public fStockList()
        {
            InitializeComponent();
            LoadStockList();
        }

        void LoadStockList()
        {
            dgvList.DataSource = StockDAO.Instance.LoadStockList();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            fStockAdd f = new fStockAdd();
            f.ShowDialog();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            fStockEdit f = new fStockEdit();
            f.ShowDialog();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
