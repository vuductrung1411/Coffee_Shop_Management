using CoffeeShopManagement.DAO;
using CoffeeShopManagement.DTO;
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
    public partial class fStockAdd : Form
    {
        public fStockAdd()
        {
            InitializeComponent();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            Stock newStock = new Stock();

            newStock.tenhang = this.tbName.Text;
            newStock.gianhap = Convert.ToInt32(this.nudPrice.Value);
            newStock.sl = Convert.ToInt32(this.nudSL.Value);
            newStock.nuocsx = this.tbCountry.Text;
            newStock.nhacungcap = this.tbProvider.Text;
            newStock.timenhaphang = this.dtpDate.Value;
            newStock.hsd = this.dtpHSD.Value;

            StockDAO.Instance.NewImport(newStock);

            MessageBox.Show("Nhập hàng thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
