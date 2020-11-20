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
    public partial class fSell : fMainForm
    {
        public fSell()
        {
            InitializeComponent();
            LoadMenu();
        }

        void LoadMenu()
        {
            this.dgvMenu.DataSource = FoodDAO.Instance.LoadFoodList();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            fGetOutOfFoodList f = new fGetOutOfFoodList();
            f.ShowDialog();
        }

        private void bCheckOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công!");
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCustomerInfo f = new fCustomerInfo();
            f.ShowDialog();
            this.Show();
        }

        private void thôngTinQuánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fShopInfomation f = new fShopInfomation();
            f.ShowDialog();
            this.Show();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fStaffList f = new fStaffList();
            f.ShowDialog();
            this.Show();
        }

        private void danhSáchMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fFoodList f = new fFoodList();
            f.ShowDialog();
            this.Show();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCustomerList f = new fCustomerList();
            f.ShowDialog();
            this.Show();
        }

        private void chươngTrìnhKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDiscountList f = new fDiscountList();
            f.ShowDialog();
            this.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fReport f = new fReport();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fStockList f = new fStockList();
            f.ShowDialog();
            this.Show();
        }

        private void lịchSửHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fBillHistory f = new fBillHistory();
            f.ShowDialog();
            this.Show();
        }

        private void lịchSửNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fImportHistory f = new fImportHistory();
            f.ShowDialog();
            this.Show();
        }

        private void lịchSửHoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fActionHistory f = new fActionHistory();
            f.ShowDialog();
            this.Show();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fStaffInfo f = new fStaffInfo();
            f.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(DataProvider.Instance.linkToConnectDeveloper);
        }

        private void lBillHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            fBillHistory f = new fBillHistory();
            f.ShowDialog();
            this.Show();
        }
    }
}
