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
    public partial class FormThemUser : SubMainForm
    {
        public FormThemUser()
        {
            InitializeComponent();
        }

        // Tắt màn hình thêm User
        private void ThemUser_Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Thêm 1 User
        private void ThemUser_DongY_button_Click(object sender, EventArgs e)
        {
            // "Mật khẩu" và "Nhập lại mật khẩu" khác nhau
            if (this.ThemUser_Password_textbox.Text != this.ThemUser_Confirm_textbox.Text)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu trùng nhau!");
                return;
            }
            // Bắt đầu tạo tài khoản
            string constr = @"Server=DESKTOP-77359PP;Database=COFFEE_SHOP_MANAGEMENT;User Id=sa;Password=123456;";
            SqlConnection connection = new SqlConnection(constr);
            try
            {
                //Mo ket noi
                connection.Open();
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "insert into NHANVIEN(ID, HOTEN, CMND, PASS) values(@id, @hoten, @cmnd, @pass)";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                string hoten_text = this.ThemUser_Name_textbox.Text;
                string cmnd_text = this.ThemUser_CMND_textbox.Text;
                string id_text = this.ThemUser_Username_textbox.Text;
                string pass_text = Encode(this.ThemUser_Password_textbox.Text);
                command.Parameters.AddWithValue("@id", id_text);
                command.Parameters.AddWithValue("@hoten", hoten_text);
                command.Parameters.AddWithValue("@cmnd", cmnd_text);
                command.Parameters.AddWithValue("@pass", pass_text);
                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                int rs = command.ExecuteNonQuery();
                //Su dung reader de doc tung dong du lieu
                //va thuc hien thao tac xu ly mong muon voi du lieu doc len
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
            }
            catch (Exception ex)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                MessageBox.Show("Tạo tài khoản thành công!!!");
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
