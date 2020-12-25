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
    public partial class fFoodList : Form
    {
        Food food;

        public fFoodList()
        {
            InitializeComponent();

            this.dgvShow.DataSource = FoodDAO.Instance.LoadFoodList();

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            fFoodAdd f = new fFoodAdd();
            f.ShowDialog();

            this.dgvShow.DataSource = FoodDAO.Instance.LoadFoodList();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            fFoodAdd f = new fFoodAdd(this.food);
            f.ShowDialog();

            this.dgvShow.DataSource = FoodDAO.Instance.LoadFoodList();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvShow.SelectedRows[0];
            string tenmon = row.Cells["Tên món"].Value.ToString();

            this.food = FoodDAO.Instance.GetFoodByName(tenmon);
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            string tenmon = this.food.tenmon;

            if (MessageBox.Show("Bạn thực sự muốn xóa món '" + tenmon + "' ra khỏi danh sách?", "XÓA MÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FoodDAO.Instance.DeleteFoodByID(this.food);

                MessageBox.Show("Đã xóa món '" + tenmon + "' ra khỏi danh sách", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.dgvShow.DataSource = FoodDAO.Instance.LoadFoodList();
            }                
        }
    }
}
