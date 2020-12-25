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
    public class StockDAO
    {
        private static StockDAO instance;

        public static StockDAO Instance 
        {
            get { if (instance == null) instance = new StockDAO(); return instance; }
            private set => instance = value; 
        }

        private StockDAO() { }

        // Load list hàng trong kho
        public DataTable LoadStockList()
        {
            string query = "SELECT ID AS [ID], TENHANG AS [Tên hàng nhập], GIANHAP AS [Giá nhập], SL AS [SL], " +
                "NUOCSX AS [Nước SX], NHACUNGCAP AS [Nhà cung cấp]," +
                "TIMENHAPHANG AS [Thời gian nhập hàng], NGAYHETHAN AS [Hạn sử dụng] FROM STOCK";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        // Thêm hàng mới vào kho
        public void NewImport(Stock stock)
        {
            string query = "EXEC USP_NewImport @tenhang , @gianhap , @sl , @nuocsx , @nhacungcap " +
                        ", @timenhaphang , @hsd ";

            int tmp = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                stock.tenhang, stock.gianhap, stock.sl, stock.nuocsx, stock.nhacungcap,
                stock.timenhaphang, stock.hsd
            });
        }

        // Lấy ra thông tin Stock từ ID
        public Stock GetStockByID(int id)
        {
            string query = "EXEC USP_GetStockByID @id ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            DataRow row = data.Rows[0];

            return new Stock(Int32.Parse(row["ID"].ToString()), row["TENHANG"].ToString(),
                Int32.Parse(row["GIANHAP"].ToString()), Int32.Parse(row["SL"].ToString()),
                row["NUOCSX"].ToString() ,row["NHACUNGCAP"].ToString(), 
                (DateTime)row["TIMENHAPHANG"], (DateTime)row["NGAYHETHAN"]);
        }

        // Giảm số lượng hàng trong kho thông qua ID
        public void DecreaseSLStockByID(int id)
        {
            string query = "EXEC USP_DecreaseSLStockByID @id ";

            int tmp = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
    }
}
