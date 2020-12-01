using CoffeeShopManagement.DTO;
using QuanLyQuanCafe.DAO;
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
    public partial class fStaffAdd : Form
    {
        public fStaffAdd()
        {
            InitializeComponent();

            LoadPositionList();
        }

        #region METHODS

        // Đọc ra danh sách chức vụ
        void LoadPositionList()
        {
            string[] arrPositionList = Infomation.Instance.LoadPositionList();
            foreach (string item in arrPositionList)
            {
                this.cbPosition.Items.Add(item);
            }
        }

        #endregion


        #region EVENTS

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tbSDT_TextChanged(object sender, EventArgs e)
        {
            string SDT = this.tbSDT.Text;

            if (AccountDAO.Instance.CheckExistAccountInDatabaseBySDT(SDT))
            {
                this.lNotificationSDT.Text = "SDT này đã tồn tại trong database";
                this.tbSDT.BorderColor = Color.Red;

                return;
            }

            this.lNotificationSDT.Text = "";
            this.tbSDT.BorderColor = Color.Black;
        }

        private void tbSDT_KeyPress(object sender, KeyPressEventArgs e)
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
