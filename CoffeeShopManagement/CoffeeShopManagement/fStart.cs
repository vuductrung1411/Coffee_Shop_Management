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

namespace CoffeeShopManagement
{
    public partial class fStart : fMainForm
    {

        private int percent = 0;

        public fStart()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            this.lText.Text = "Townes van Zandt is the best songwriter in the whole world and I’ll stand on Bob Dylan’s coffee table in my cowboy boots and say that. - Steve Earle";
            this.timer.Interval = 100;
            this.pbProcessStart.Value = 5;
            this.timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.percent += 1;
            switch (this.percent)
            {
                case 10:
                    this.pbProcessStart.Value = 10;
                    //this.lText.Text = "It is the folly of too many to mistake the echo of a London coffee-house for the voice of the kingdom. - Jonathan Swift";
                    break;
                case 20:
                    this.lText.Text = "Kids are meeting in coffee shops and basements figuring out what's unsustainable in their communities. That's the future. - Ian Somerhalder";
                    this.pbProcessStart.Value = 20;
                    break;
                case 25:
                    this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.StartImage_21;
                    this.lText.BackColor = System.Drawing.Color.White;
                    this.lText.ForeColor = System.Drawing.Color.Black;
                    this.pbProcessStart.Value = 25;
                    break;
                case 30:
                    this.pbProcessStart.Value = 30;
                    //this.lText.Text = "When my blood runs black as the moonless night, and my heartbeat sounds as the warriors’ march, only then may you say, I’ve had enough coffee - Anonymous";
                    break;
                case 40:
                    this.lText.Text = "I wake up some mornings and sit and have my coffee and look out at my beautiful garden, and I go, ’Remember how good this is. Because you can lose it. - Jim Carrey";
                    break;
                case 50:
                    //this.lText.Text = "I don’t need to drink coffee to be awesome. I’m already awesome. But it’s more fun when I’m awesome and awake. - Anonymous";
                    this.pbProcessStart.Value = 50;
                    this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.StartImage_3;
                    this.lText.BackColor = System.Drawing.Color.DarkSlateGray;
                    this.lText.ForeColor = System.Drawing.Color.White;
                    break;
                case 60:
                    this.lText.Text = "A girl in a bikini is like having a loaded pistol on your coffee table - There's nothing wrong with them, but it's hard to stop thinking about it. - Garrison Keillor";
                    break;
                case 70:
                    //this.lText.Text = "Do you know how helpless you feel if you have a full cup of coffee in your hand and you start to sneeze? - Jean Kerr";
                    this.pbProcessStart.Value = 70;
                    break;
                case 75:
                    this.pbProcessStart.Value = 75;
                    this.BackgroundImage = global::CoffeeShopManagement.Properties.Resources.StartImage_4;
                    this.lText.BackColor = System.Drawing.Color.SaddleBrown;
                    break;
                case 80:
                    this.lText.Text = "Too much coffee. Too much coffee and Gatorade. It's a hell of a mix. If you're ever tired in the morning, just try that mix, and tell me what you think. - Kevin Garnett";
                    this.pbProcessStart.Value = 80;
                    break;
                case 85:
                    this.pbProcessStart.Value = 95;
                    break;
                case 90:
                    //this.lText.Text = "Tobacco, coffee, alcohol, hashish, prussic acid, strychnine, are weak dilutions. The surest poison is time. - Ralph Waldo Emerson";
                    break;
                case 100:
                    this.lText.Text = "When I wake up in the morning, I just can't get started until I've had that first, piping hot pot of coffee. Oh, I've tried other enemas.- Emo Phillips";
                    this.pbProcessStart.Value = 100;
                    break;
                case 103:
                    fLogin f = new fLogin();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void lConnectToDeveloper_Click(object sender, EventArgs e)
        {
            Process.Start(DataProvider.Instance.linkToConnectDeveloper);
        }

        private void lChangeDatabase_Click(object sender, EventArgs e)
        {
            fDatabaseChange f = new fDatabaseChange();
            f.ShowDialog();
        }

        
    }
}
