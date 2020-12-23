using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region Full các form + Giải thích
            //Application.Run(new fActionHistory());                      // Lịch sử hoạt động của quán   
            //Application.Run(new fBillHistory());                        // Lịch sử hóa đơn
            //Application.Run(new fCustomerAdd());                        // Thêm khách hàng mới
            //Application.Run(new fCustomerInfo());                       // Thông tin chi tiết khách hàng
            //Application.Run(new fCustomerList());                       // Danh sách khách hàng
            //Application.Run(new fDatabaseChange());                     // Thay đổi database/máy
            //Application.Run(new fDiscountAdd());                        // Thêm chương trình khuyến mãi
            //Application.Run(new fDiscountEdit());                       // Sửa chương trình khuyến mãi
            //Application.Run(new fDiscountList());                       // Danh sách chương trình khuyến mãi
            //Application.Run(new fFoodAdd());                            // Thêm món
            //Application.Run(new fFoodEdit());                           // Sửa món
            //Application.Run(new fFoodList());                           // Danh sách món 
            //Application.Run(new fGetOutOfFoodList());                   // Danh sách món đã hết
            //Application.Run(new fImportHistory());                      // Lịch sử nhập hàng
            //Application.Run(new fLogin());                              // Đăng nhập
            //Application.Run(new fPasswordChange());                     // Thay đổi mật khẩu
            //Application.Run(new fPasswordConfirm());                    // Xác nhận mật khẩu
            //Application.Run(new fReport());                             // Báo cáo thống kê
            //Application.Run(new fSell());                               // Bán hàng
            //Application.Run(new fShopInfomation());                     // Thông tin quán
            //Application.Run(new fStaffAdd());                           // Thêm nhân viên mới
            //Application.Run(new fStaffInfo());                          // Thông tin chi tiết nhân viên
            //Application.Run(new fStaffList());                          // Danh sách nhân viên
            //Application.Run(new fStart());                              // Khởi động phân mềm    
            //Application.Run(new fStockAdd());                           // Thêm hàng mới vào kho
            //Application.Run(new fStockEdit());                          // Chỉnh sửa hàng trong kho
            //Application.Run(new fStockList());                          // Danh sách hàng đang lưu trữ trong kho
            #endregion

            Application.Run(new fCustomerAdd());
        }
    }
}
