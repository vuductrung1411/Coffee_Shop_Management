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
    public partial class fStart : fMainForm
    {
        public fStart()
        {
            InitializeComponent();
        }

        private void lConnectToDeveloper_Click(object sender, EventArgs e)
        {
            Process.Start(linkConnectToDeveloper);
        }

        private void lChangeDatabase_Click(object sender, EventArgs e)
        {
            fDatabaseChange f = new fDatabaseChange();
            f.ShowDialog();
        }
    }
}
