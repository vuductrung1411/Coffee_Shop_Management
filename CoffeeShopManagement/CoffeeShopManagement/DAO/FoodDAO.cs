using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance 
        {
            get { if (instance == null) instance = new FoodDAO(); return instance; }
            private set => instance = value; 
        }

        private FoodDAO() { }

        public DataTable LoadFoodList()
        {
            DataTable data = new DataTable();

            string query = "SELECT * FROM FOOD";

            data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

    }
}
