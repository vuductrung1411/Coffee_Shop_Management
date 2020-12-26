using CoffeeShopManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DTO
{
    public class Bill
    {
        public int ID;              // Mã hóa đơn
        public int TotalValue;      // Tổng giá trị hóa đơn
        public int DiscountValue;   // Tổng giá trị được giảm giá
        public int PaymentValue;    // Thành tiền
        public DateTime Time;       // Thời gian giao dịch

        public int[] arrFoodID = new int[1000];     // Danh sách món ăn trong hóa đơn
        public int[] arrFoodSL = new int[1000];     // Số lượng ứng với từng món
        public int nFood = 0;           // Số món trong hóa đơn

        public Bill() 
        { 
           
        }

        public DataTable TakeBill()
        {
            DataTable bill = new DataTable();

            bill.Columns.Add("Món");
            bill.Columns.Add("Đơn giá");
            bill.Columns.Add("Số lượng");

            for (int i = 0; i < nFood; i++)
            {
                string tenmon = FoodDAO.Instance.GetNameByID(arrFoodID[i]);
                int giamon = FoodDAO.Instance.GetPriceByID(arrFoodID[i]);
                int soluong = arrFoodSL[i];
                DataRow row = bill.NewRow();

                row["Món"] = tenmon;
                row["Đơn giá"] = giamon;
                row["Số lượng"] = soluong;

                bill.Rows.Add(row);
            }    

            return bill;
        }

        public void CalTotalValue()
        {
            this.TotalValue = 0;
            for (int i = 0; i < nFood; i++)
            {
                int giamon = FoodDAO.Instance.GetPriceByID(arrFoodID[i]);
                int soluong = arrFoodSL[i];

                this.TotalValue += giamon * soluong;
            }
        }

        public void DeleteFood(string tenmon)
        {
            int id = FoodDAO.Instance.GetIDByNameFood(tenmon);

            int vitri = 0;

            for (int i = 0; i < nFood; i++)
            {
                if (id == arrFoodID[i])
                {
                    vitri = i;
                    break;
                }
            }    

            for (int i = vitri; i < nFood - 1; i++)
            {
                arrFoodID[i] = arrFoodID[i + 1];
                arrFoodSL[i] = arrFoodSL[i + 1];
            }
            nFood--;
        }

        public void Reset()
        {
            this.nFood = 0;
        }
    }
}
