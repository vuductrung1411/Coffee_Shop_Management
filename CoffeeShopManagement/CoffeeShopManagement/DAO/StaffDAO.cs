using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance 
        {
            get { if (instance == null) instance = new StaffDAO(); return instance; } 
            private set => instance = value; 
        }

        private StaffDAO() { }

        public DataTable LoadStaffList()
        {
            string query = "SELECT * FROM ACCOUNTINFO WHERE CHUCVU = 0";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
