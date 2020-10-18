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
    public partial class fAddUser : SubMainForm
    {
        public fAddUser()
        {
            InitializeComponent();
            this.tbStaffIndex.Text = Automatic_Create_MANV();
        }

        // Tắt màn hình thêm User
        private void ThemUser_Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        // Tạo MANV tự động
        private string Automatic_Create_MANV()
        {
            // xac dinh duong dan den database
            String connString = @"Server=DESKTOP-77359PP;Database=COFFEE_SHOP_MANAGEMENT;User Id=sa;Password=123456;";

            //ket noi csdl bang Sqlconnection 
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            string manv_text = "";
            try
            {
                String sqlQuery = "SELECT COUNT(*) AS D FROM NHANVIEN";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = command.ExecuteReader();
                int tmp = 0;
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    tmp = reader.GetInt32(0);
                }
                manv_text = (++tmp).ToString();
                while (manv_text.Length < 4) manv_text = "0" + manv_text;
                return "NV" + manv_text;
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
            return manv_text;
        }

        // Kiểm tra các trường hợp lỗi, không cho phép tạo tài khoản
        private bool Error_Create()
        {
            // Mật khẩu không khớp nhau
            if (this.tbPassword.Text != this.tbConfirm.Text)
            {
                MessageBox.Show("Tạo tài khoản thất bại!\nMật khẩu không khớp!");
                return true;
            }

            // Nhập thiếu thông tin
            if (this.tbName.Text == "" || this.tbCMND.Text == "" || this.cbSex.Text == "" || this.tbSDT.Text == ""
                || this.cbPosition.Text == "" || this.tbAddress.Text == "" || this.tbSalary.Text == "" || this.tbStaffIndex.Text == ""
                || this.tbUsername.Text == "" || this.tbPassword.Text == "" || this.tbConfirm.Text == "")
            {
                MessageBox.Show("Tạo tài khoản thất bại!\nVui lòng điền đầy đủ thông tin!");
                return true;
            }

            // Mật khẩu quá ngắn: <6 ký tự
            if (this.tbPassword.Text.Length < 6)
            {
                MessageBox.Show("Tạo tài khoản thất bại!\nVui lòng nhập mật khẩu nhiều hơn 6 ký tự!");
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

                    // Trùng MANV
                    if (manv == this.tbStaffIndex.Text)
                    {
                        MessageBox.Show("Tạo tài khoản thất bại!\nMã NV này đã tồn tại trong dữ liệu.");
                        return true;
                    }
                    // Trùng CMND
                    if (cmnd == this.tbCMND.Text)
                    {
                        MessageBox.Show("Tạo tài khoản thất bại!\nCMND này đã tồn tại trong dữ liệu.");
                        return true;
                    }
                    // Trùng SDT
                    if (sdt == this.tbSDT.Text)
                    {
                        MessageBox.Show("Tạo tài khoản thất bại!\nSDT này đã tồn tại trong dữ liệu.");
                        return true;
                    }
                    // Trùng Tên đăng nhập
                    if (username == this.tbUsername.Text)
                    {
                        MessageBox.Show("Tạo tài khoản thất bại!\nTên đăng nhập này đã tồn tại trong dữ liệu.");
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

        // Thêm 1 User
        private void bAccept_Click(object sender, EventArgs e)
        {
            // Mã hóa Password
            this.tbPassword.Text = Encode(this.tbPassword.Text);
            this.tbConfirm.Text = Encode(this.tbConfirm.Text);

            // Nếu có lỗi thì thoát
            if (Error_Create() == true)
            {
                return;
            }
       
            #region Tạo tài khoản
            //xac dinh duong dan den database 
            String connString = @"Server=DESKTOP-77359PP;Database=COFFEE_SHOP_MANAGEMENT;User Id=sa;Password=123456;";

            //ket noi csdl bang Sqlconnection 
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            try
            {
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "INSERT INTO NHANVIEN(MANV, HOTEN, GIOITINH, DIACHI, CMND, SDT, NGAYVL, LUONG, CHUCVU) values(@manv, @hoten, @gioitinh, @diachi, @cmnd, @sdt, @ngayvl, @luong, @chucvu)";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                string manv_text = this.tbStaffIndex.Text;
                string hoten_text = this.tbName.Text;
                string gioitinh_text = this.cbSex.Text;
                string diachi_text = this.tbAddress.Text;
                string cmnd_text = this.tbCMND.Text;
                string sdt_text = this.tbSDT.Text;
                string ngayvl_text = DateTime.Now.ToString("dd/MM/yyyy");
                string luong_text = this.tbSalary.Text;
                string chucvu_text = this.cbPosition.Text;

                command.Parameters.AddWithValue("@manv", manv_text);
                command.Parameters.AddWithValue("@hoten", hoten_text);
                command.Parameters.AddWithValue("@gioitinh", gioitinh_text);
                command.Parameters.AddWithValue("@diachi", diachi_text);
                command.Parameters.AddWithValue("@cmnd", cmnd_text);
                command.Parameters.AddWithValue("@sdt", sdt_text);
                command.Parameters.AddWithValue("@ngayvl", ngayvl_text);
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

                // ---------------------------------


                //Chuan bi cau lenh query viet bang SQL
                sqlQuery = "INSERT INTO ACCOUNT(MANV, USERNAME, PASS, TINHTRANG) values(@manv, @username, @pass, @tt)";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                command = new SqlCommand(sqlQuery, connection);

                string username_text = this.tbUsername.Text;
                string pass_text = this.tbPassword.Text;

                command.Parameters.AddWithValue("@manv", manv_text);
                command.Parameters.AddWithValue("@username", username_text);
                command.Parameters.AddWithValue("@pass", pass_text);
                command.Parameters.AddWithValue("@tt", "Đang làm việc");

                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                rs = command.ExecuteNonQuery();
                //Su dung reader de doc tung dong du lieu
                //va thuc hien thao tac xu ly mong muon voi du lieu doc len
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
                // ----------------------------------

                MessageBox.Show("Tạo tài khoản thành công!!!");
                bReset_Click(sender, e);
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
            #endregion 
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

        private void bReset_Click(object sender, EventArgs e)
        {
            this.tbName.Text = "";
            this.tbCMND.Text = "";
            this.cbSex.Text = "";
            this.tbSDT.Text = "";
            this.cbPosition.Text = " ";
            this.tbAddress.Text = "";
            this.tbSalary.Text = "";
            this.tbStaffIndex.Text = Automatic_Create_MANV();
            this.tbUsername.Text = "";
            this.tbPassword.Text = "";
            this.tbConfirm.Text = "";
        }
    }
}
