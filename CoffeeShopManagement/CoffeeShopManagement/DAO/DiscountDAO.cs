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

        public DataTable LoadDiscountList()
        {
            string query = "SELECT * FROM DISCOUNT";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            
            return data;
        }
    }
}
