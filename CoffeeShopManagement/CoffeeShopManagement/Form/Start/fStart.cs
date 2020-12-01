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
        #region Link
        private string QuotesLink = @".\Information\Quotes about Coffee.txt";
        #endregion

        private int percent = 0;
        private string[] arrQuotes;
        private int nQuotes;

        public fStart()
        {
            // đọc thông tin cần thiết vào
            Infomation.Instance.LoadInfo();

            InitializeComponent();
            
            ReadQuotes();

            this.timer.Interval = 100; // 0.1miligiay cho 1%
            this.pbProcessStart.Value = 0;
            PrintQuotes();
            this.timer.Start();
        }
        
        // In hoa chuỗi
        private string UpperString(string s)
        {
            return s.ToUpper(); 
        }

        // Đọc dữ liệu từ file Quotes
        private void ReadQuotes()
        {
            arrQuotes = File.ReadAllLines(this.QuotesLink);
            this.nQuotes = arrQuotes.Count();
            lText.Text = this.nQuotes.ToString();
        }

        // Đổi và in câu quotes khác
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
                case 5:
                    this.pbProcessStart.Value = 5;
                    break;
                case 10:
                    this.pbProcessStart.Value = 10;
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
                    this.pbProcessStart.Value = 30;
                    PrintQuotes();
                    break;
                case 35:
                    this.pbProcessStart.Value = 35;
                    break;
                case 40:
                    this.pbProcessStart.Value = 40;
                    break;
                case 45:
                    this.pbProcessStart.Value = 45;
                    PrintQuotes();
                    break;
                case 50:
                    this.BackgroundImage = Properties.Resources.Start3;

                    this.lShopName2.Text = UpperString(Infomation.Instance.shopName);
                    this.lSlogan2.Text = Infomation.Instance.shopSlogan;

                    this.lText.ForeColor = Color.White;
                    this.pbProcessStart.Value = 50;
                    break;
                case 60:
                    this.pbProcessStart.Value = 60;
                    PrintQuotes();
                    break;
                case 70:
                    this.pbProcessStart.Value = 80;
                    break;
                case 75:
                    this.BackgroundImage = Properties.Resources.Start4;

                    this.lShopOwner.Text = UpperString(Infomation.Instance.shopOwner);
                    this.lShopName1.Text = UpperString(Infomation.Instance.shopName);
                    this.lSlogan1.Text = UpperString(Infomation.Instance.shopSlogan);
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
    }
}
