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
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance 
        {
            get { if (instance == null) instance = new CustomerDAO(); return instance; } 
            private set => instance = value; 
        }

        private CustomerDAO() { }

        // Load ra toàn bộ table CUSTOMER (Cho list danh sách)
        public DataTable LoadCustomerList()
        {
            string query = "SELECT * FROM CUSTOMER";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        // Lấy ra ID của khách hàng thông qua SDT
        public int GetIDCustomerBySDT(string sdt)
        {
            string query = "EXEC USP_GetIDCustomerBySDT @sdt";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { sdt });
        }

        // Kiểm tra xem có tồn tại khách hàng trong database hay không thông qua SDT
        public bool CheckExistCustomerInDatabaseBySDT(string sdt)
        {
            string query = "SELECT * FROM CUSTOMER WHERE SDT = '" + sdt + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        // Lấy ra họ tên khách hàng thông qua SDT
        public string GetNameCustomerBySDT(string sdt)
        {
            string query = "SELECT HOTEN FROM CUSTOMER WHERE SDT = '" + sdt + "'";
            return DataProvider.Instance.ExecuteScalar(query).ToString();
        }

        // Thêm khách hàng mới vào trong Database
        public void CreateNewCustomer(string hoten, string sdt, string gioitinh, DateTime ngaysinh)
        {
            string query = "EXEC USP_CreateNewCustomer @name , @sdt , @gioitinh , @ngaysinh";

            int tmp = DataProvider.Instance.ExecuteNonQuery(query, new object[] { hoten, sdt, gioitinh, ngaysinh });
        }
    
        // Lấy ra thông tin khách hàng thông qua SDT
        public Customer getCustomerBySDT(string sdt)
        {
            string query = "SELECT * FROM CUSTOMER WHERE SDT = '" + sdt + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            DataRow row = result.Rows[0];

            int ID = (int)row["ID"];
            string SDT = row["SDT"].ToString();
            string HOTEN = row["HOTEN"].ToString();
            string GIOITINH = row["GIOITINH"].ToString();
            DateTime NGAYSINH = (DateTime)row["NGAYSINH"];

            Customer customer = new Customer(ID, SDT, NGAYSINH, HOTEN, GIOITINH);

            return customer;
        }

        // Update thông tin của khách hàng
        public void UpdateCustomerInfo(Customer cus)
        {
            string query = "EXEC USP_UpdateCustomerInfo @id , @hoten , @sdt , @gioitinh , @ngaysinh ";

            int tmp = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                cus.id, cus.hoten, cus.sdt, cus.gioitinh, cus.ngaysinh
            });
        }
    }
}
