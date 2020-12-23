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
    public partial class fStaffInfo : Form
    {
        Staff staff;

        public fStaffInfo(AccountInfo info = null)
        {
            InitializeComponent();

            LoadPositionList();

            if (info != null)
            {
                this.tbSearch.Text = info.sdt;
                this.bSearch.PerformClick();
            }
        }


        #region METHODS
        void LoadPositionList()
        {
            string[] arrPositionList = Infomation.Instance.LoadPositionList();
            foreach (string item in arrPositionList)
            {
                this.cbPosition.Items.Add(item);
            }

            this.cbPosition.Items.Add("ADMIN");
        }
        #endregion

        #region EVENTS
        private void bChangePassword_Click(object sender, EventArgs e)
        {
            fPasswordChange f = new fPasswordChange();
            f.ShowDialog();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bChangePassword_Click_1(object sender, EventArgs e)
        {
            fPasswordChange f = new fPasswordChange();
            f.ShowDialog();
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.tbSearch.Text == "")
            {
                this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else
            {
                this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 16.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }

            this.lNotificationSDTSearch.Text = "";
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã nhập sdt chưa
            if (this.tbSearch.Text == "")
            {
                this.tbSearch.BorderColor = Color.Red;
                this.lNotificationSDTSearch.Text = "Vui lòng nhập số điện thoại";

                return;
            }

            string SDT = this.tbSearch.Text;

            // Check coi sdt có tồn tại trong csdl hay không
            if (!StaffDAO.Instance.CheckExistsStaffBySDT(SDT))
            {
                this.tbSearch.BorderColor = Color.Red;
                this.lNotificationSDTSearch.Text = "Không tồn tại số điện thoại này trong cơ sở dữ liệu";

                return;
            }

            // 
            this.tbSearch.BorderColor = Color.Black;
            this.lNotificationSDTSearch.Text = "";

            // Lấy ra thông tin
            staff = StaffDAO.Instance.getStaffBySDT(SDT);

            // In ra thông tin đã lấy được
            this.tbName.Text = staff.hoten;
            this.tbSDT.Text = staff.sdt;
            this.tbID.Text = staff.id.ToString();
            this.cbPosition.Text = staff.chucvu;
            this.dtpStartWorking.Value = staff.ngayvaolam;
            this.cbGender.Text = staff.gioitinh;
            this.dtpBirthDate.Value = staff.ngaysinh;
            this.tbAddress.Text = staff.diachi;
            this.nudSalary.Value = (int)staff.luong;
            this.tbCMND.Text = staff.cmnd;

            // Tính toán và in ra những thông tin còn lại
            this.tbAge.Text = (DateTime.Now.Year - this.dtpBirthDate.Value.Year).ToString();
            this.tbTimeWorking.Text = (DateTime.Now - this.dtpStartWorking.Value).Days.ToString() + " ngày";
        }


        #endregion

        private void tbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
