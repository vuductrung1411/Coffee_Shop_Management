﻿using CoffeeShopManagement.DAO;
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
    public partial class fCustomerInfo : Form
    {
        Customer customer;

        public fCustomerInfo()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (!CustomerDAO.Instance.CheckExistCustomerInDatabaseBySDT(SDT))
            {
                this.tbSearch.BorderColor = Color.Red;
                this.lNotificationSDTSearch.Text = "Không tồn tại số điện thoại này trong cơ sở dữ liệu";

                return;
            }

            // 
            this.tbSearch.BorderColor = Color.Black;
            this.lNotificationSDTSearch.Text = "";

            // Lấy ra thông tin
            customer = CustomerDAO.Instance.getCustomerBySDT(SDT);

            // In ra thông tin đã lấy được
            this.tbName.Text = customer.hoten;
            this.tbSDT.Text = customer.sdt;
            this.tbID.Text = customer.id.ToString();
            this.cbGender.Text = customer.gioitinh;
            this.dtpBirthdate.Value = customer.ngaysinh;

            // Tính toán và in ra các thông tin còn lại
            this.tbAge.Text = (DateTime.Now.Year - customer.ngaysinh.Year).ToString();

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
                this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }

            this.lNotificationSDTSearch.Text = "";
        }
    }
}
