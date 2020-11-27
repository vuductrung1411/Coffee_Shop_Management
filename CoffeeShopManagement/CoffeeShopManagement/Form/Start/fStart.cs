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

namespace CoffeeShopManagement
{
    public partial class fStart : Form
    {
        #region Link
        private string QuotesLink = @".\Information\Quotes about Coffee.txt";
        private string ShopInfoLink = @".\Information\Shop Infomation.txt";
        #endregion

        private int percent = 0;
        private string[] arrQuotes;
        private string[] arrShopInfo;
        private int nQuotes;

        public fStart()
        {
            InitializeComponent();
            
            ReadQuotes();
            ReadShopInfo();

            this.timer.Interval = 100;
            this.pbProcessStart.Value = 10;
            PrintQuotes();
            this.timer.Start();
        }
        
        private string UpperString(string s)
        {
            s = s.ToUpper();
            return s; 
        }

        private void ReadQuotes()
        {
            arrQuotes = File.ReadAllLines(this.QuotesLink);
            this.nQuotes = arrQuotes.Count();
            lText.Text = this.nQuotes.ToString();
        }

        private void ReadShopInfo()
        {
            arrShopInfo = File.ReadAllLines(this.ShopInfoLink);
        }
        private void PrintQuotes()
        {
            var rand = new Random();
            lText.Text = arrQuotes[rand.Next(0, this.nQuotes)];
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.percent++;
            switch (this.percent)
            {
                case 10:
                    PrintQuotes();
                    this.pbProcessStart.Value = 15;
                    break;
                case 20:
                    this.pbProcessStart.Value = 20;
                    break;
                case 25:
                    this.BackgroundImage = Properties.Resources.Start2;
                    this.lText.ForeColor = Color.Black;
                    break;
                case 30:
                    PrintQuotes();
                    break;
                case 35:
                    this.pbProcessStart.Value = 35;
                    PrintQuotes();
                    break;
                case 40:
                    this.pbProcessStart.Value = 40;
                    break;
                case 45:
                    this.pbProcessStart.Value = 45;
                    break;
                case 50:
                    PrintQuotes();
                    this.BackgroundImage = Properties.Resources.Start3;

                    this.lShopName2.Text = UpperString(this.arrShopInfo[1]);
                    this.lSlogan2.Text = this.arrShopInfo[2];

                    this.lText.ForeColor = Color.White;
                    this.pbProcessStart.Value = 50;
                    break;
                case 55:
                    this.pbProcessStart.Value = 55;
                    break;
                case 60:
                    this.pbProcessStart.Value = 60;
                    break;
                case 65:
                    this.pbProcessStart.Value = 65;
                    break;
                case 70:
                    PrintQuotes();
                    this.pbProcessStart.Value = 70;
                    break;
                case 75:
                    this.BackgroundImage = Properties.Resources.Start4;

                    this.lShopOwner.Text = UpperString(this.arrShopInfo[0]);
                    this.lShopName1.Text = UpperString(this.arrShopInfo[1]);
                    this.lSlogan1.Text = UpperString(this.arrShopInfo[2]);
                    this.lShopName2.Text = "";
                    this.lSlogan2.Text = "";

                    this.pbProcessStart.Value = 95;
                    break;
                case 80:
                    this.pbProcessStart.Value = 95;
                    break;
                case 90:
                    PrintQuotes();
                    break;
                case 100:
                    break;
                case 103:
                    this.pbProcessStart.Value = 100;
                    this.timer.Stop();
                    fLogin f = new fLogin();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                    break;
            }
        }
    }
}
