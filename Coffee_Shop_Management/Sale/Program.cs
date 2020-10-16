using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coffee_Shop_Management;

namespace Sale
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
            #region PHÚ làm trong thứ 7
            // Code phần Thêm khách hàng mới 
            // Sửa tên 
            // Tạo Table KHACHHANG
            //Application.Run(new Sell());
            //Application.Run(new KhachHang_ThongTin());
            //Application.Run(new KhachHang_ThongTin_ChinhSua());
            #endregion

            //Application.Run(new XemThongBao());
            //Application.Run(new ThongTinTaiChinh());
            //Application.Run(new FormThucDon());

            #region THÁI làm trong thứ 7
            // Tạo Table MON
            // Sửa lại tên của phần này
            //Application.Run(new FormThemMon());
            //Application.Run(new FormSuaMon());
            //Application.Run(new FormXoaMon());
            #endregion

            //Application.Run(new FormChangeInfoUser());
            //Application.Run(new FormXoaUser());
            //Application.Run(new FormThongKe());
            //Application.Run(new FormKetQuaThongKe());
            #region Phần này Trung làm dở, không đụng vào, đổi tên phần này cũng là Trung làm
            //Application.Run(new FormThemUser());
            //Application.Run(new fLogin());
            #endregion
        }
    }
}
