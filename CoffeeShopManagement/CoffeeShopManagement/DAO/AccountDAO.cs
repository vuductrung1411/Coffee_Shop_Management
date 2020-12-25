using CoffeeShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            passWord = Encode(passWord);
            string query = "EXEC USP_Login @userName , @passWord"; 

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{userName, passWord });

            return result.Rows.Count > 0;
        }

        // Lấy ra ID thông qua Username
        public int GetIDByUsername(string userName)
        {
            string query = "EXEC USP_GetIDByUsername @userName";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { userName });
        }

        // Kiểm tra coi đã tồn tại sdt này hay chưa
        public bool CheckExistAccountInDatabaseBySDT(string sdt)
        {
            string query = "SELECT * FROM ACCOUNTINFO WHERE SDT = '" + sdt + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        // Kiểm tra coi đã tồn tại CMND này hay chưa
        public bool CheckExistAccountInDatabaseByCMND(string cmnd)
        {
            string query = "SELECT * FROM ACCOUNTINFO WHERE CMND = '" + cmnd + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        // Kiểm tra xem Username này đã tồn tại hay chưa
        public bool CheckExistUsernameInDatabase(string username)
        {
            string query = "SELECT * FROM ACCOUNT WHERE USERNAME = '" + username + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        // Tạo tài khoản ACCOUNT mới
        public void CreateNewAccount(string username, string password)
        {
            password = Encode(password);

            string query = "EXEC USP_CreateNewAccouunt @id , @username , @password ";

            int id = (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM ACCOUNTINFO") - 1;

            int tmp = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, username, password });
        }

        // Tạo tài khoản ACCOUNTINFO mới
        public void CreateNewAccountInfo(AccountInfo account)
        {
            string query = "EXEC USP_CreateNewInfoAccount @hoten , @sdt , " +
                "@chucvu , @lvposition , @luong , @cmnd , @ngaysinh , @diachi , @ngvl , @gioitinh ";

            int tmp = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                account.hoten, account.sdt, account.chucvu, account.lvPosition,
                account.luong, account.cmnd, account.ngaysinh, 
                account.diachi, account.ngayvaolam, account.gioitinh
            });
        }

        // Lấy ra ACCOUNTINFO thông qua username
        public AccountInfo GetAccountInfoByUsername(string username)
        {
            string query = "EXEC USP_GetAccountInfoByUsername @username";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username });

            DataRow row = result.Rows[0];

            AccountInfo info = new AccountInfo(row["HOTEN"].ToString(), row["SDT"].ToString(),
                row["CHUCVU"].ToString(), (int)row["LVPOSITION"], (int)row["LUONG"],
                row["CMND"].ToString(), (DateTime)row["NGAYSINH"], row["DIACHI"].ToString(),
                (DateTime)row["NGVL"], row["GIOITINH"].ToString(), (int)row["ID"]);

            return info;
        }

        // Update lại thông tin của nhân viên
        public void UpdateAccountInfo(Staff staff)
        {
            string query = "EXEC USP_UpdateAccountInfo @id , @hoten , @sdt , @gioitinh , " +
                "@ngaysinh , @diachi , @cmnd , @chucvu , @ngayvaolam , @luong ";

            int tmp = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                staff.id, staff.hoten, staff.sdt, staff.gioitinh, staff.ngaysinh,
                staff.diachi, staff.cmnd, staff.chucvu, staff.ngayvaolam, staff.luong
            });
        }

        // Lấy ra Password thông qua ID
        public string GetPasswordByID(int id)
        {
            string query = "EXEC USP_GetPasswordByID @id ";

            return DataProvider.Instance.ExecuteScalar(query, new object[] { id }).ToString();
        }

        // Update mật khẩu thông qua ID
        public void UpdatePasswordByID(int id, string password)
        {
            password = Encode(password);

            string query = "EXEC USP_UpdatePasswordByID @id , @password ";

            int tmp = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, password });
        }

        // Sa thải nhân viên thông qua ID
        public void LayOffStaffByID(int id)
        {
            string query = "USP_LayOffStaffByID @id , @tinhtrang ";

            int tmp = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, "Đã nghỉ việc" });
        }

        // Mã hóa
        public string Encode(string str)
        {
            //Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(str);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
