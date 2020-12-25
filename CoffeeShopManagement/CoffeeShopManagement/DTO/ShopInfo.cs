using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DTO
{
    public class ShopInfo
    {
        private static ShopInfo instance;

        public static ShopInfo Instance 
        {
            get { if (instance == null) instance = new ShopInfo(); return instance; }
            private set { instance = value; }
        }

        private ShopInfo() { }

        public string tenquan, sdt, tenchuquan, diachi, slogan;
        public int soghe, soban, sokhachtoida;
        public DateTime sinhnhatquan;

        public string[] QuotesList = new string[1000];                    // Lưu các quotes
        public int nQuotes = 0;                                           // Số lượng quotes

        public string[] PositionList = new string[100];                   // Lưu các vị trí/chức vụ trong quán
        public int nPosition = 0;                                         // Số lượng chức vụ/vị trí

        public void LoadInfo()
        {
            LoadShopInfo();
            LoadQuotesList();
            LoadPositionList();
        }

        void LoadShopInfo()
        {
            string query = "SELECT * FROM SHOPINFO";

            DataTable datatable = DataProvider.Instance.ExecuteQuery(query);

            DataRow data = datatable.Rows[0];

            this.tenquan = data["TENQUAN"].ToString();
            this.sdt = data["SDT"].ToString();
            this.tenchuquan = data["TENCHUQUAN"].ToString();
            this.diachi = data["DIACHI"].ToString();
            this.soghe = Int32.Parse(data["SOGHE"].ToString());
            this.sokhachtoida = Int32.Parse(data["SOKHACHTOIDA"].ToString());
            this.soban = Int32.Parse(data["SOBAN"].ToString());
            this.sinhnhatquan = (DateTime)data["SINHNHATQUAN"];
            this.slogan = data["SLOGAN"].ToString();
        }

        void LoadQuotesList()
        {
            string query = "SELECT * FROM QUOTESLIST";

            DataTable datatable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in datatable.Rows)
            {
                QuotesList[nQuotes] = row["QUOTES"].ToString();
                nQuotes++;
            }
        }

        void LoadPositionList()
        {
            string query = "SELECT * FROM POSITIONLIST";

            DataTable datatable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in datatable.Rows)
            {
                PositionList[nPosition] = row["POSITION"].ToString();
                nPosition++;
            }
        }
    }
}
