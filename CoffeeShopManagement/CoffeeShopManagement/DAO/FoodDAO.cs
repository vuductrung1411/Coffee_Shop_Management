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

            string query =  "SELECT TENMON AS [Tên món], GIABAN AS [Giá bán], DVT AS [Đơn vị tính] " +
                            "FROM FOOD";

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
        // Lấy ra tên món từ ID
        public string GetNameByID(int id)
        {
            string query = "SELECT TENMON FROM FOOD WHERE ID = " + id;
            return DataProvider.Instance.ExecuteScalar(query).ToString();
        }

        // Lấy ra giá món từ ID
        public int GetPriceByID(int id)
        {
            string query = "SELECT GIABAN FROM FOOD WHERE ID = " + id;
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

        // Kiểm tra xem đã có món nào cùng tên chưa
        public bool CheckExistsFoodName(string name)
        {
            string query = "EXEC USP_CheckExistsFoodName @tenmon ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { name});
            return result.Rows.Count > 0;
        }

        // Thêm món mới vào danh sách món
        public void CreateNewFood(Food food)
        {
            string query = "EXEC USP_CreateNewFood @tenmon , @giaban , @dvt ";

            int tmp = (int)DataProvider.Instance.ExecuteNonQuery(query, new object[]
                { food.tenmon, food.gia, food.dvt });
        }

        // Xóa món ra khỏi danh sách thông qua tên món
        public void DeleteFoodByName(string tenmon)
        {
            string query = "EXEC USP_DeleteFoodByName @tenmon ";

            int tmp = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenmon });
        }

        // Lấy ra thông tin món từ tên món
        public Food GetFoodByName(string tenmon)
        {
            string query = "EXEC USP_GetFoodByName @tenmon ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenmon });

            DataRow row = data.Rows[0];

            Food food = new Food(row["TENMON"].ToString(), (int)row["GIABAN"], row["DVT"].ToString(), (int)row["ID"]);

            return food;
        }

        // Update thông tin món
        public void UpdateFoodInfo(Food food)
        {
            string query = "EXEC USP_UpdateFoodInfoByID @id , @tenmon , @giaban , @dvt ";

            int tmp = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                food.id, food.tenmon, food.gia, food.dvt
            });
        }

        // Xóa món ra khỏi danh sách thông qua ID
        public void DeleteFoodByID(Food food)
        {
            string query = "EXEC USP_DeleteFoodByID @id ";

            int tmp = DataProvider.Instance.ExecuteNonQuery(query, new object[] { food.id });
        }
    }
}
