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
    public partial class fCustomerAdd : Form
    {
        public fCustomerAdd(bool edit = false)
        {
            InitializeComponent();
            if (edit == true)
            {
                this.lTitle.Text = "Chỉnh sửa thông tin khách hàng";
                this.bOK.Text = "Lưu";
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
