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
    public partial class fStockList : Form
    {
        Stock stock = new Stock();

        public fStockList()
        {
            InitializeComponent();

            this.dgvShow.DataSource = StockDAO.Instance.LoadStockList();

            // Đánh dấu chưa có hàng nào được click
            stock.id = 0;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bImport_Click(object sender, EventArgs e)
        {
            fStockAdd f = new fStockAdd();
            f.ShowDialog();

            this.dgvShow.DataSource = StockDAO.Instance.LoadStockList();
        }

        private void dgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvShow.SelectedRows[0];

            int id = Int32.Parse(row.Cells["ID"].Value.ToString());

            stock = StockDAO.Instance.GetStockByID(id);

            // Ghi thông tin ra màn hình
            this.tbName.Text = stock.tenhang;
            this.tbPrice.Text = stock.gianhap.ToString();
            this.tbSL.Text = stock.sl.ToString();
            this.tbCountry.Text = stock.nuocsx;
            this.tbProvider.Text = stock.nhacungcap;
            this.dtpTimeImport.Value = stock.timenhaphang;
            this.dtpHSD.Value = stock.hsd;
        }

        private void bUse_Click(object sender, EventArgs e)
        {
            if (stock.id == 0 || this.tbSL.Text == "Hết hàng")
            {
                return;
            }

            int sl = Int32.Parse(this.tbSL.Text);

            sl--;

            StockDAO.Instance.DecreaseSLStockByID(this.stock.id);

            this.dgvShow.DataSource = StockDAO.Instance.LoadStockList();

            if (sl > 0)
            {
                this.tbSL.Text = sl.ToString();
            }
            else
            {
                this.tbSL.Text = "Hết hàng";
            }
            
        }
    }
}
