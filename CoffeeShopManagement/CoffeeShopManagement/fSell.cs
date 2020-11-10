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
            fCustomerInfo f = new fCustomerInfo();
            f.ShowDialog();
        }

        private void thôngTinQuánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fShopInfomation f = new fShopInfomation();
            f.ShowDialog();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStaffList f = new fStaffList();
            f.ShowDialog();
        }

        private void danhSáchMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFoodList f = new fFoodList();
            f.ShowDialog();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCustomerList f = new fCustomerList();
            f.ShowDialog();
        }

        private void chươngTrìnhKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDiscountList f = new fDiscountList();
            f.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fReport f = new fReport();
            f.ShowDialog();
        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStockList f = new fStockList();
            f.ShowDialog();
        }

        private void lịchSửHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBillHistory f = new fBillHistory();
            f.ShowDialog();
        }

        private void lịchSửNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fImportHistory f = new fImportHistory();
            f.ShowDialog();
        }

        private void lịchSửHoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fActionHistory f = new fActionHistory();
            f.ShowDialog();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStaffInfo f = new fStaffInfo();
            f.ShowDialog();
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
            Process.Start(linkConnectToDeveloper);
        }

        private void lBillHistory_Click(object sender, EventArgs e)
        {
            fBillHistory f = new fBillHistory();
            f.ShowDialog();
        }
    }
}
