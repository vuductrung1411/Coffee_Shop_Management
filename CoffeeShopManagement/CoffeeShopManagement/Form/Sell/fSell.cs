using CoffeeShopManagement.DAO;
using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class fSell : Form
    {
        public fSell()
        {
            InitializeComponent();

            this.dgvMenu.DataSource = FoodDAO.Instance.LoadFoodList();
        }

        private void bAddCustomer_Click(object sender, EventArgs e)
        {
            fCustomerAdd f = new fCustomerAdd();
            f.ShowDialog();
        }

        private void bCustomerInfo_Click(object sender, EventArgs e)
        {
            fCustomerInfo f = new fCustomerInfo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void lGetOutOfFood_Click(object sender, EventArgs e)
        {
            fGetOutOfFoodList f = new fGetOutOfFoodList();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void lBillHistory_Click(object sender, EventArgs e)
        {
            fBillHistory f = new fBillHistory();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán");
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCustomerInfo f = new fCustomerInfo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thôngTinQuánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fShopInfomation f = new fShopInfomation();
            f.ShowDialog();
        }

        private void danhSáchMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFoodList f = new fFoodList();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStaffList f = new fStaffList();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCustomerList f = new fCustomerList();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void chươngTrìnhKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDiscountList f = new fDiscountList();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fReport f = new fReport();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStockList f = new fStockList();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void lịchSửHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBillHistory f = new fBillHistory();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void lịchSửNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fImportHistory f = new fImportHistory();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void lịchSửHoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fActionHistory f = new fActionHistory();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void liênHệVớiNhàPhátTriểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(DataProvider.Instance.linkToConnectDeveloper);
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStaffInfo f = new fStaffInfo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
