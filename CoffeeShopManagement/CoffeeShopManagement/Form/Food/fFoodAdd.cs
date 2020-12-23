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

        #region Methods

        #endregion


        #region Events
        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            string foodName = this.tbName.Text;

            if (FoodDAO.Instance.CheckExistsFoodName(foodName))
            {
                this.lNotificationFoodName.Text = "Món này đã có trong danh sách";
            }
            else
            {
                this.lNotificationFoodName.Text = "";
            }    
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (FoodDAO.Instance.CheckExistsFoodName(this.tbName.Text))
            {
                this.lNotificationFoodName.Text = "Món này đã có trong danh sách";
                return;
            }
            if (this.tbName.Text == "")
            {
                this.tbName.BorderColor = Color.Red;
                return;
            }

            this.tbName.BorderColor = Color.Black;

            Food newFood = new Food(this.tbName.Text, (int)this.nudPrice.Value, this.tbCountry.Text, this.tbUnit.Text);

            FoodDAO.Instance.CreateNewFood(newFood);

            MessageBox.Show("Thêm món thành công", "THÀNH CÔNG", MessageBoxButtons.OK);
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        #endregion

        
    }
}
