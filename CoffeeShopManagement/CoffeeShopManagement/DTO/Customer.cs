using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DTO
{
    public class Customer
    {
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
        }

        public Customer(int id, string sdt, DateTime ngaysinh, string hoten = "", string gioitinh = "Không xác định")
        {
            this.id = id;
            this.sdt = sdt;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
        }

        private int GetBillID()
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM BILL");
        }
    }
}
