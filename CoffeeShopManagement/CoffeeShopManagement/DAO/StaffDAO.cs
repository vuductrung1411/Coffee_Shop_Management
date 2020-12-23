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
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance 
        {
            get { if (instance == null) instance = new StaffDAO(); return instance; } 
            private set => instance = value; 
        }

        private StaffDAO() { }

        // Danh sách nhân viên
        public DataTable LoadStaffList()
        {
            string query = "SELECT * FROM ACCOUNTINFO WHERE LVPOSITION < 2";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        // Kiểm tra đã tồn tại Nhân viên này hay chưa thông qua SDT
        public bool CheckExistsStaffBySDT(string sdt)
        {
            string query = "SELECT * FROM ACCOUNTINFO WHERE SDT = '" + sdt + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        // Lấy ra thông tin nhân viên thông qua SDT
        public Staff getStaffBySDT(string sdt)
        {
            string query = "SELECT * FROM ACCOUNTINFO WHERE SDT = '" + sdt + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            DataRow row = result.Rows[0];

            int ID = (int)row["ID"];
            string HOTEN = row["HOTEN"].ToString();
            string SDT = row["SDT"].ToString();
            string CHUCVU = row["CHUCVU"].ToString();
            int LEVELPOSITION = (int)row["LVPOSITION"];
            int LUONG = (int)row["LUONG"];
            string CMND = row["CMND"].ToString();
            DateTime NGAYSINH = (DateTime)row["NGAYSINH"];
            string DIACHI = row["DIACHI"].ToString();
            DateTime NGAYVAOLAM = (DateTime)row["NGVL"];
            string GIOITINH = row["GIOITINH"].ToString();

            Staff staff = new Staff(ID, HOTEN, SDT, CHUCVU, LEVELPOSITION, LUONG, CMND, NGAYSINH, DIACHI, NGAYVAOLAM, GIOITINH);

            return staff;
        }
    }
}
