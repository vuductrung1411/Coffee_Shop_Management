using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using QuanLyQuanCafe.DAO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CoffeeShopManagement.DTO;

namespace CoffeeShopManagement
{
    public partial class fStart : Form
    {

        private int percent = 0;

        public fStart()
        { 
            InitializeComponent();

            this.timer.Interval = 50; // 0.05ms cho 1%
            this.pbProcessStart.Value = 0;
            PrintQuotes();
            this.timer.Start();
        }

        // Đổi và in câu quotes khác
        private void PrintQuotes()
        {
            var rand = new Random();
            lText.Text = ShopInfo.Instance.QuotesList[rand.Next(0, ShopInfo.Instance.nQuotes)];
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.percent++;

            switch (this.percent)
            {
                case 5:
                    this.pbProcessStart.Value = 5;
                    break;
                case 15:
                    PrintQuotes();
                    break;
                case 25:
                    this.BackgroundImage = Properties.Resources.Start2;
                    this.pbProcessStart.Value = 25;
                    this.lText.ForeColor = Color.Black;
                    break;
                case 30:
                    PrintQuotes();
                    break;
                case 45:
                    PrintQuotes();
                    break;
                case 50:
                    this.BackgroundImage = Properties.Resources.Start3;

                    this.lShopName2.Text = ShopInfo.Instance.tenquan.ToUpper();
                    this.lSlogan2.Text = ShopInfo.Instance.slogan;

                    this.lText.ForeColor = Color.White;
                    this.pbProcessStart.Value = 50;
                    break;
                case 60:
                    this.pbProcessStart.Value = 60;
                    PrintQuotes();
                    break;
                case 75:
                    this.BackgroundImage = Properties.Resources.Start4;

                    this.lShopOwner.Text = ShopInfo.Instance.tenchuquan.ToUpper();
                    this.lShopName1.Text = ShopInfo.Instance.tenquan.ToUpper();
                    this.lSlogan1.Text = ShopInfo.Instance.slogan.ToUpper();

                    this.lShopName2.Text = "";
                    this.lSlogan2.Text = "";

                    PrintQuotes();
                    break;
                case 80:
                    this.pbProcessStart.Value = 95;
                    break;
                case 90:
                    PrintQuotes();
                    break;
                case 100:
                    this.pbProcessStart.Value = 99;
                    PrintQuotes();
                    break;
                case 110:
                    this.pbProcessStart.Value = 100;
                    this.timer.Stop();
                    fLogin f = new fLogin();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                    break;
            }
        }

        private void lSlogan1_Click(object sender, EventArgs e)
        {

        }
    }
}
