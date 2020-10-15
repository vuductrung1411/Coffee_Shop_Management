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
            //Application.Run(new Sell());
            //Application.Run(new KhachHang_ThongTin());
            //Application.Run(new KhachHang_ThongTin_ChinhSua());
            //Application.Run(new XemThongBao());
            //Application.Run(new ThongTinTaiChinh());
            //Application.Run(new FormThucDon());
            //Application.Run(new FormThemMon());
            //Application.Run(new FormSuaMon());
            //Application.Run(new FormXoaMon());
            //Application.Run(new FormThemUser());
            //Application.Run(new FormChangeInfoUser());
            //Application.Run(new FormXoaUser());
            //Application.Run(new FormThongKe());
            //Application.Run(new FormKetQuaThongKe());
            Application.Run(new FormLogin());
        }
    }
}
