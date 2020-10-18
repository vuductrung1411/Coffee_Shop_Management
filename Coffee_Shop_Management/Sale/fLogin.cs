using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Coffee_Shop_Management
{
    public partial class fLogin : SubMainForm
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            string mk = Encode(this.tbPassword.Text);
            string tk = this.tbUsername.Text;

            //xac dinh duong dan den database 
            String connString = @"Server=DESKTOP-77359PP;Database=COFFEE_SHOP_MANAGEMENT;User Id=sa;Password=123456;";

            //ket noi csdl bang Sqlconnection 
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            //Chuan bi cau lenh query viet bang SQL 
            String sqlQuery = "select * from ACCOUNT";
            //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai 
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
            SqlDataReader reader = command.ExecuteReader();

            //Su dung reader de doc tung dong du lieu //va thuc hien thao tac xu ly mong muon voi du lieu doc len 
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                string username = reader.GetString(1);
                string password = reader.GetString(2);
                if (username == tk && password == mk)
                {
                    // Đăng nhập thành công, làm công việc tiếp theo 
                    MessageBox.Show("Đăng nhập thành công!");
                    return;
                }
            }
            MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
            connection.Close();
        }

        // mã hóa md5
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
