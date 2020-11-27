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
    public partial class fDiscountAdd : Form
    {
        public fDiscountAdd(int edit = 0)
        {
            InitializeComponent();
            if (edit == 1)
            {
                this.lTitle.Text = "Chỉnh sửa chương trình khuyến mãi";
                this.bOK.Text = "Lưu";
            }
            else
            {
                if (edit == 2)
                {
                    this.lTitle.Text = "Thông tin khuyến mãi";
                    this.bOK.Text = "OK";
                }
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
