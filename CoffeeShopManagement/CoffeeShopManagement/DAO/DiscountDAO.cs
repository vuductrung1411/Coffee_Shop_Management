using CoffeeShopManagement.DTO;
using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DAO
{
    public class DiscountDAO
    {
        private static DiscountDAO instance;

        public static DiscountDAO Instance
        {
            get { if (instance == null) instance = new DiscountDAO(); return instance; } 
            private set => instance = value; 
        }

        private DiscountDAO() { }

        // Load ra list danh sách
        public DataTable LoadDiscountList()
        {
            string query = "SELECT * FROM DISCOUNT";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            
            return data;
        }

        // Tạo thêm CTKM mới
        public void CreateNewDiscount(Discount discount)
        {
            string query = "EXEC USP_CreateNewDiscount @name , @percent , @minBill , @maxValue , @ngayBD , @ngayKT , @text ";

            int tmp = (int)DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                discount.tenCTKM, discount.phantramKM, discount.minGTKM, discount.maxGTKM,
                discount.ngayBD, discount.ngayKT, discount.text
            });
        }
    }
}
