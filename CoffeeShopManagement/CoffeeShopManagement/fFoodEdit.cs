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
    public partial class fFoodEdit : fMainForm
    {
        public fFoodEdit()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
