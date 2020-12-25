using CoffeeShopManagement.DAO;
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
    public partial class fStaffInfo : Form
    {
        Staff staff; // Thông tin của nhân viên đang hiển thị trên màn hình

        AccountInfo account; // Thông tin của người đang đăng nhập vào phần mềm

        bool InfoChanged = false; // false: không thay đổi gì thông tin, true: có thay đổi

        bool isAdmin = true; // true: Chủ quán, false: Nhân viên 

        public fStaffInfo(AccountInfo info = null)
        {
            InitializeComponent();

            LoadPositionList();

            if (info != null)
            {
                this.tbSearch.Text = info.sdt;
                this.bSearch.PerformClick();

                this.account = info;

                if (this.account.lvPosition == 0)
                    isAdmin = false;
            }
        }


        #region METHODS
        void LoadPositionList()
        {
            for (int i = 0; i < ShopInfo.Instance.nPosition; i++)
            {
                this.cbPosition.Items.Add(ShopInfo.Instance.PositionList[i]);
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
            //if (this.InfoChanged == true)
            //{
            //    if (MessageBox.Show("Bạn vừa thay đổi thông tin.\nBạn có muốn lưu thay đổi không?", "LƯU THAY ĐỔI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        this.bSave.PerformClick();
            //    }
            //}

            this.Close();
        }

        private void bChangePassword_Click_1(object sender, EventArgs e)
        {
            fPasswordChange f = new fPasswordChange(account);
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
            this.tbStatus.Text = staff.tinhtrang;

            // Tính toán và in ra những thông tin còn lại
            this.tbAge.Text = (DateTime.Now.Year - this.dtpBirthDate.Value.Year).ToString();
            this.tbTimeWorking.Text = (DateTime.Now - this.dtpStartWorking.Value).Days.ToString() + " ngày";
        }

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

        private void lUpload_Click(object sender, EventArgs e)
        {
            this.InfoChanged = true;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            this.InfoChanged = true;
        }

        private void tbSDT_TextChanged(object sender, EventArgs e)
        {
            this.InfoChanged = true;
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.InfoChanged = true;
        }

        private void dtpStartWorking_ValueChanged(object sender, EventArgs e)
        {
            this.tbTimeWorking.Text = (DateTime.Today - this.dtpStartWorking.Value).Days.ToString() + " ngày";
            this.InfoChanged = true;
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.InfoChanged = true;
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            this.InfoChanged = true;
            this.tbAge.Text = (DateTime.Today.Year - this.dtpBirthDate.Value.Year).ToString();
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            this.InfoChanged = true;
        }

        private void nudSalary_ValueChanged(object sender, EventArgs e)
        {
            this.InfoChanged = true;
        }

        private void tbCMND_TextChanged(object sender, EventArgs e)
        {
            this.InfoChanged = true;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            this.InfoChanged = false;

            Staff newInfoStaff = new Staff();

            // Trường hợp là nhân viên tự thay thông tin
            newInfoStaff.hoten = this.tbName.Text;
            newInfoStaff.sdt = this.tbSDT.Text;
            newInfoStaff.gioitinh = this.cbGender.Text;
            newInfoStaff.ngaysinh = this.dtpBirthDate.Value;
            newInfoStaff.diachi = this.tbAddress.Text;
            newInfoStaff.cmnd = this.tbCMND.Text;

            // Trường hợp chủ quán thay đổi thông tin
            newInfoStaff.chucvu = this.cbPosition.Text;
            newInfoStaff.ngayvaolam = this.dtpStartWorking.Value;
            newInfoStaff.luong = Convert.ToInt32(this.nudSalary.Value);

            // Lấy ra ID
            newInfoStaff.id = Int32.Parse(this.tbID.Text);

            // Thực hiện Update
            AccountDAO.Instance.UpdateAccountInfo(newInfoStaff);

            MessageBox.Show("Thay đổi thông tin thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbPosition_MouseClick(object sender, MouseEventArgs e)
        {
            // Nếu là nhân viên thì không được thay đổi thông tin này
            if (isAdmin == false)
            {
                MessageBox.Show("Không được phép thay đổi thông tin này");
            }
            else
            {
                // Nếu là chủ quán thì phải mặc định là ADMIN
                if (staff.id == Int32.Parse(this.tbID.Text))
                {
                    MessageBox.Show("Không được phép thay đổi thông tin này");
                }
            }
        }

        private void bLayOff_Click(object sender, EventArgs e)
        {
            // Nếu là nhân viên tự bấm thì bỏ qua
            if (this.account.lvPosition == 0)
            {
                MessageBox.Show("Bạn không có quyền tự sa thải!\nLiên hệ với chủ quán để được nghỉ việc!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu là chủ quán thì thay đổi TINHTRANG = "Đã nghỉ việc"
            // Tuy nhiên chủ quán cũng không được "tự hủy" :))
            if (this.account.id == Int32.Parse(this.tbID.Text))
            {
                MessageBox.Show("Không thể xóa tài khoản của chủ quán!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Chủ quán sa thải nhân viên
            if (MessageBox.Show("Bạn thực sự muốn sa thải nhân viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AccountDAO.Instance.LayOffStaffByID(Int32.Parse(this.tbID.Text));

                MessageBox.Show("Đã sa thải thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Load lại thông tin
                this.tbSearch.Text = this.tbSDT.Text;
                this.bSearch.PerformClick();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
