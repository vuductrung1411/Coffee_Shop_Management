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
        Food food; // Món đang được hiển thị trên màn hình

        bool isEdit = false; // true: đang edit, false: không edit

        public fFoodAdd()
        {
            InitializeComponent();
        }

        public fFoodAdd(Food f)
        {
            InitializeComponent();

            this.food = f;
            this.lTitle.Text = "Thay đổi thông tin món";
            this.bOK.Text = "Lưu";

            this.tbName.Text = f.tenmon;
            this.nudPrice.Value = f.gia;
            this.tbUnit.Text = f.dvt;

            this.isEdit = true;
        }

        #region METHODS

        #endregion


        #region EVENTS
        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            string foodName = this.tbName.Text;

            if (this.isEdit == false && FoodDAO.Instance.CheckExistsFoodName(foodName))
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
            if (this.isEdit == false && FoodDAO.Instance.CheckExistsFoodName(this.tbName.Text))
            {
                this.lNotificationFoodName.Text = "Món này đã có trong danh sách";
                return;
            }
            else
            {
                this.lNotificationFoodName.Text = "";
            }
            if (this.tbName.Text == "")
            {
                this.tbName.BorderColor = Color.Red;
                return;
            }

            this.tbName.BorderColor = Color.Black;

            if (this.isEdit == false)
            {
                Food newFood = new Food(this.tbName.Text, (int)this.nudPrice.Value, this.tbUnit.Text);

                FoodDAO.Instance.CreateNewFood(newFood);

                MessageBox.Show("Thêm món thành công", "THÀNH CÔNG", MessageBoxButtons.OK);
            }
            else
            {
                Food newFoodInfo = new Food(this.tbName.Text, (int)this.nudPrice.Value, this.tbUnit.Text, this.food.id);

                FoodDAO.Instance.UpdateFoodInfo(newFoodInfo);

                MessageBox.Show("Cập nhật thông tin món thành công", "THÀNH CÔNG", MessageBoxButtons.OK);
            }
            this.Close();
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
