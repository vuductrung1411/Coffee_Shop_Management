using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DTO
{
    // Do nó giống (hình như là hoàn toàn) ACCOUNTINFO
    // Để tên Staff cho dễ hiểu, mất công để AccountInfo không hiểu
    public class Staff
    {
        public string hoten, sdt, chucvu, cmnd, diachi, gioitinh;
        public int lvPosition, luong, id;
        public DateTime ngaysinh, ngayvaolam;

        public Staff(int id, string hoten, string sdt, string chucvu, int lvposition, int luong, string cmnd, DateTime ngaysinh, string diachi, DateTime ngayvaolam, string gioitinh)
        {
            this.id = id;
            this.hoten = hoten;
            this.sdt = sdt;
            this.chucvu = chucvu;
            this.lvPosition = lvposition;
            this.luong = luong;
            this.cmnd = cmnd;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.ngayvaolam = ngayvaolam;
            this.gioitinh = gioitinh;
        }
    }
}
