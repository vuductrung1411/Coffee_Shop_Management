using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DTO
{
    public class AccountInfo
    {
        //@hoten, @sdt, @chucvu, @lvposition, @luong, @cmnd, @ngaysinh, @diachi, @ngvl, @gioitinh

        public string hoten, sdt, chucvu, cmnd, diachi, gioitinh;
        public int lvPosition, luong, id;
        public DateTime ngaysinh, ngayvaolam;

        public AccountInfo(string hoten, string sdt, string chucvu, int lvposition, int luong, string cmnd, DateTime ngaysinh, string diachi, DateTime ngayvaolam, string gioitinh, int id = 0 )
        {
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
            this.id = id;
        }
    }
}
