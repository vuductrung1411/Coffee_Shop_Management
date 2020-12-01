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

        public DataTable LoadMenu()
        {
            DataTable data = new DataTable();

            string query = "SELECT TENMON AS [Món], GIABAN AS [Giá] FROM FOOD";

            data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        // Lấy ra duy nhất tên món -> Để load ra combobox
        public DataTable LoadOnlyFoodName()
        {
            DataTable data = new DataTable();

            string query = "SELECT TENMON FROM FOOD";

            data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        // Lấy ra giá món từ tên món
        public int GetPriceByNameFood(string name)
        {
            string query = "SELECT GIABAN FROM FOOD WHERE TENMON = N'" + name + "'";
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        // lấy ra ID của món từ tên món
        public int GetIDByNameFood(string name)
        {
            string query = "SELECT ID FROM FOOD WHERE TENMON = N'" + name + "'";
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        // Thêm món vào hóa đơn
        public void InsertFoodIntoBill(int idBill, int idFood, int sl, string note)
        {
            string query = "EXEC USP_InsertFoodIntoBill @idBill , @idFood , @sl , @note";
            int tmp = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBill, idFood, sl, note });
        }

    }
}
