using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopManagement.DTO;
using Guna.UI2.WinForms;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;


namespace CoffeeShopManagement.DTO
{
    public class Customer
    {
        // -----------------------

        public bool isVangLai = true;           // Có phải khách vãng lai hay không
        public int inTable;                     // Hiện đang ngồi tại bàn nào?
        public int slbb = 0;                    // Số lượng bạn bè đi cùng, mặc định = 0 nếu đi một mình
        public Bill bill = new Bill();          // Hóa đơn của khách này
        public Guna2GradientTileButton btn = new Guna2GradientTileButton();

        // ------------------------

        public int id;
        public string sdt;
        public string hoten;
        public string gioitinh;
        public DateTime ngaysinh;

        // Được dùng khi khách đang trong quán
        public int billID;      // Lưu thông tin mã hóa đơn (lúc khách đang trong quán)
        public int tableID;     // Lưu thông tin số bàn mà khách đang ngồi (Lúc khách đang trong quán)

        public Customer(int tableID, string sdt = "")
        {
            this.tableID = tableID;
            this.sdt = sdt;
            this.billID = GetBillID();
            initButton();
        }

        public Customer(int id, string sdt, DateTime ngaysinh, string hoten = "", string gioitinh = "Không xác định")
        {
            this.id = id;
            this.sdt = sdt;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
            initButton();
        }

        public Customer() 
        {
            initButton();
        }

        private int GetBillID()
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM BILL");
        }

        public void initButton()
        {
            btn.Font = new Font("Segoe UI", 10F);
            btn.ForeColor = Color.Black;
            btn.Size = new Size(125, 40);
        }
    }
}
