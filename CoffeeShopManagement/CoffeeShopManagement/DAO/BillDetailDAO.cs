using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DAO
{
    public class BillDetailDAO
    {
        private static BillDetailDAO instance;

        public static BillDetailDAO Instance 
        {
            get { if (instance == null) instance = new BillDetailDAO(); return instance; }
            private set { instance = value; }
        }
        private BillDetailDAO() { }

        // Load ra chi tiết hóa đơn với mã hóa đơn
        public DataTable LoadBillDetailsByBillID(int idBill)
        {
            string query = "EXEC USP_LoadBillDetailsByBillID @idBill";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idBill });
        }
    }
}
