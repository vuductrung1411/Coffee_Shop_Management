using CoffeeShopManagement.DAO;
using CoffeeShopManagement.DTO;
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

        #region Methods

        bool CheckInfomation()
        {
            bool ok = true;

            if (this.tbName.Text == "")
            {
                ok = false;
                this.tbName.BorderColor = Color.Red;
            }
            else
            {
                this.tbName.BorderColor = Color.Green;
            }

            if (this.nudPercent.Value == 0)
            {
                ok = false;
                this.nudPercent.BorderColor = Color.Red;
            }
            else
            {
                this.nudPercent.BorderColor = Color.Green;
            } 

            if (this.nudMaxValue.Value == 0)
            {
                ok = false;
                this.nudMaxValue.BorderColor = Color.Red;
            }
            else
            {
                this.nudMaxValue.BorderColor = Color.Green;
            }

            if (this.dtpEndDate.Value < this.dtpStartDate.Value)
            {
                ok = false;
                this.lNotificationEndDate.Text = "Ngày kết thúc phải lớn hơn ngày bắt đầu";
                this.dtpStartDate.BorderColor = Color.Red;
                this.dtpEndDate.BorderColor = Color.Red;
            }
            else
            {
                this.lNotificationEndDate.Text = "";
                this.dtpStartDate.BorderColor = Color.Green;
                this.dtpEndDate.BorderColor = Color.Green;
            }


            return ok;
        }

        #endregion


        #region Events

        private void bOK_Click(object sender, EventArgs e)
        {
            if (!CheckInfomation())
            {
                return;
            }

            Discount discount = new Discount(this.tbName.Text, (int)this.nudPercent.Value,
                (int)this.nudMinValue.Value, (int)this.nudMaxValue.Value,
                this.dtpStartDate.Value, this.dtpEndDate.Value, this.tbText.Text);

            DiscountDAO.Instance.CreateNewDiscount(discount);

            MessageBox.Show("Thêm CTKM thành công", "THÀNH CÔNG", MessageBoxButtons.OK);

            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudMaxValue_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
