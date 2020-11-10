using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance 
        {
            get { if (instance == null) instance = new CustomerDAO(); return instance; } 
            private set => instance = value; 
        }

        private CustomerDAO() { }

        public DataTable LoadCustomerList()
        {
            string query = "SELECT * FROM CUSTOMER";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
