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
    public partial class fFoodAdd : Form
    {
        public fFoodAdd(int edit = 0)
        {
            InitializeComponent();
            if (edit == 1)
            {
                this.lTitle.Text = "Chỉnh sửa thông tin món";
                this.bOK.Text = "Lưu";
            }
            else
            {
                if (edit == 2)
                {
                    this.lTitle.Text = "Thông tin món";
                    this.bOK.Text = "OK";
                }
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
