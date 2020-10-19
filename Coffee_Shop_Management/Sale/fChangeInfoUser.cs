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
    public partial class fChangeInfoUser : SubMainForm
    {
        public fChangeInfoUser()
        {
            InitializeComponent();
        }
        // Lỗi
        private bool Error_Create()
        {
            // Nhập thiếu thông tin
            if (this.tbName.Text == "" || this.tbCMND.Text == "" || this.cbSex.Text == "" || this.tbSDT.Text == ""
                || this.cbPosition.Text == "" || this.tbAddress.Text == "" || this.tbSalary.Text == "" || this.tbStaffIndex.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return true;
            }


            //xac dinh duong dan den database 
            String connString = @"Server=DESKTOP-77359PP;Database=COFFEE_SHOP_MANAGEMENT;User Id=sa;Password=123456;";

            //ket noi csdl bang Sqlconnection 
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            //Chuan bi cau lenh query viet bang SQL 
            try
            {
                String sqlQuery = "select nv.MANV, nv.CMND, nv.SDT, ac.USERNAME from NHANVIEN nv JOIN ACCOUNT ac ON ac.MANV = nv.MANV";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai 
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                SqlDataReader reader = command.ExecuteReader();

                //Su dung reader de doc tung dong du lieu va thuc hien thao tac xu ly mong muon voi du lieu doc len 
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    string manv = reader.GetString(0);
                    string cmnd = reader.GetString(1);
                    string sdt = reader.GetString(2);
                    string username = reader.GetString(3);

                    if (manv == this.tbStaffIndex.Text) continue;

                    // Trùng CMND
                    if (cmnd == this.tbCMND.Text)
                    {
                        MessageBox.Show("CMND này đã tồn tại trong dữ liệu.");
                        return true;
                    }
                    // Trùng SDT
                    if (sdt == this.tbSDT.Text)
                    {
                        MessageBox.Show("SDT này đã tồn tại trong dữ liệu.");
                        return true;
                    }
                    // Trùng Tên đăng nhập
                    if (username == this.tbUsername.Text)
                    {
                        MessageBox.Show("Tên đăng nhập này đã tồn tại trong dữ liệu.");
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
                    if (this.tbUsername.Text == user && Encode(this.tbPassword.Text) == pass)
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

        private void bAccept_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tài khoản và mật khẩu đúng chưa
            if (CheckAccount() == false)
            {
                MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác!");
                return;
            }

            // Nếu có lỗi thì thoát
            if (Error_Create() == true)
            {
                return;
            }

            //xac dinh duong dan den database 
            String connString = @"Server=DESKTOP-77359PP;Database=COFFEE_SHOP_MANAGEMENT;User Id=sa;Password=123456;";

            //ket noi csdl bang Sqlconnection 
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            try
            {
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "UPDATE NHANVIEN SET HOTEN = @hoten, GIOITINH = @gioitinh, DIACHI = @diachi, CMND = @cmnd, SDT = @sdt, LUONG = @luong, CHUCVU = @chucvu WHERE MANV = @manv";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                string hoten_text = this.tbName.Text;
                string gioitinh_text = this.cbSex.Text;
                string diachi_text = this.tbAddress.Text;
                string cmnd_text = this.tbCMND.Text;
                string sdt_text = this.tbSDT.Text;
                string luong_text = this.tbSalary.Text;
                string chucvu_text = this.cbPosition.Text;

                command.Parameters.AddWithValue("@manv", this.tbStaffIndex.Text);
                command.Parameters.AddWithValue("@hoten", hoten_text);
                command.Parameters.AddWithValue("@gioitinh", gioitinh_text);
                command.Parameters.AddWithValue("@diachi", diachi_text);
                command.Parameters.AddWithValue("@cmnd", cmnd_text);
                command.Parameters.AddWithValue("@sdt", sdt_text);
                command.Parameters.AddWithValue("@luong", luong_text);
                command.Parameters.AddWithValue("@chucvu", chucvu_text);

                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                int rs = command.ExecuteNonQuery();
                //Su dung reader de doc tung dong du lieu
                //va thuc hien thao tac xu ly mong muon voi du lieu doc len
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }

                #region Đổi tài khoản mật khẩu
                //// -----------------------------------------------------
                ////Chuan bi cau lenh query viet bang SQL
                //sqlQuery = "UPDATE ACCOUNT SET USERNAME = @tk, PASS = @mk WHERE MANV = @manv";
                ////Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                //command = new SqlCommand(sqlQuery, connection);

                //string tk = this.tbUsername.Text;
                //string mk = this.tbPassword.Text;

                //command.Parameters.AddWithValue("@manv", this.tbStaffIndex.Text);
                //command.Parameters.AddWithValue("@tk", tk);
                //command.Parameters.AddWithValue("@mk", mk);

                ////Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                //rs = command.ExecuteNonQuery();
                ////Su dung reader de doc tung dong du lieu
                ////va thuc hien thao tac xu ly mong muon voi du lieu doc len
                //if (rs != 1)
                //{
                //    throw new Exception("Failed Query");
                //}
                //// -----------------------------------------------------
                #endregion

                MessageBox.Show("Thay đổi thông tin tài khoản thành công!!!"); 
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

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
