using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DTO
{
    public class CustomerInShop
    {
        public string sdt;
        public int billID;
        public int tableID;

        public CustomerInShop(int tableID, string sdt = "")
        {
            this.tableID = tableID;
            this.sdt = sdt;
            this.billID = GetBillID();
        }

        private int GetBillID()
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM BILL");
        }
    }
}
