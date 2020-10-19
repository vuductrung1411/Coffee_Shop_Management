using Coffee_Shop_Management;
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

namespace Sale
{
    public partial class fChangePasswordUser : SubMainForm
    {
        public fChangePasswordUser()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Kiểm tra xem tài khoản và mật khẩu đúng chưa
        private bool CheckAccount()
        {
            //xac dinh duong dan den database 
            String connString = @"Server=DESKTOP-77359PP;Database=COFFEE_SHOP_MANAGEMENT;User Id=sa;Password=123456;";

            //ket noi csdl bang Sqlconnection 
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            //Chuan bi cau lenh query viet bang SQL 
            try
            {
                String sqlQuery = "select USERNAME, PASS from ACCOUNT";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai 
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                SqlDataReader reader = command.ExecuteReader();

                //Su dung reader de doc tung dong du lieu va thuc hien thao tac xu ly mong muon voi du lieu doc len 
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    string user = reader.GetString(0);
                    string pass = reader.GetString(1);
                    if (this.tbUsername.Text == user && Encode(this.tbOldPassword.Text) == pass)
                    {
                        connection.Close();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show(ex.ToString());
                //MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
                return true;
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                connection.Close();
            }
            return false;
        }

        // các thao tác thay đổi mật khẩu
        private void bAccept_Click(object sender, EventArgs e)
        {
            // Tài khoản hoặc mật khẩu không chính xác
            if (CheckAccount() == false)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!!!");
                return;
            }

            //xac dinh duong dan den database 
            String connString = @"Server=DESKTOP-77359PP;Database=COFFEE_SHOP_MANAGEMENT;User Id=sa;Password=123456;";

            //ket noi csdl bang Sqlconnection 
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            try
            {

                #region Đổi mật khẩu
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "UPDATE ACCOUNT SET PASS = @mk WHERE USERNAME = @user";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                string mk = Encode(this.tbNewPassword.Text);

                command.Parameters.AddWithValue("@user", this.tbUsername.Text);
                command.Parameters.AddWithValue("@mk", mk);

                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                int rs = command.ExecuteNonQuery();
                //Su dung reader de doc tung dong du lieu
                //va thuc hien thao tac xu ly mong muon voi du lieu doc len
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
                #endregion

                MessageBox.Show("Thay đổi mật khẩu thành công!!!");
            }
            catch (Exception ex)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show(ex.ToString());
                //MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                connection.Close();
            }
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
