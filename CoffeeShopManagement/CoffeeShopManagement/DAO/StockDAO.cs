using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DAO
{
    public class StockDAO
    {
        private static StockDAO instance;

        public static StockDAO Instance 
        {
            get { if (instance == null) instance = new StockDAO(); return instance; }
            private set => instance = value; 
        }

        private StockDAO() { }

        public DataTable LoadStockList()
        {
            string query = "SELECT * FROM STOCK";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
