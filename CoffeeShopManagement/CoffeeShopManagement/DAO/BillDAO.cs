using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance 
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }

        private BillDAO() { }

        public void CreateNewBill(int idStaff, int idCustomer = 0)
        {
            string query;
            if (idCustomer == 0)
            {
                query = "EXEC USP_CreateNewBillWithoutCustomer @idStaff";
                int tmp = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idStaff });
            }
            else
            {
                query = "EXEC USP_CreateNewBill @idStaff , @idCustomer";
                int tmp = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idStaff, idCustomer });
            }
        }
    }
}
