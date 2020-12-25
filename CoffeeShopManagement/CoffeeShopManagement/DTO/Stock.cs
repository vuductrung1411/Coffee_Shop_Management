using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DTO
{
    public class Stock
    {
        public int id, sl, gianhap;
        public string tenhang, nuocsx, nhacungcap;
        public DateTime timenhaphang, hsd;

        public Stock() { }

        public Stock(string tenhang, int gianhap, int sl, string nuocsx, string nhacungcap, DateTime timenhaphang, DateTime hsd)
        {
            this.tenhang = tenhang;
            this.gianhap = gianhap;
            this.sl = sl;
            this.nuocsx = nuocsx;
            this.nhacungcap = nhacungcap;
            this.timenhaphang = timenhaphang;
            this.hsd = hsd;
        }

        public Stock(int id, string tenhang, int gianhap, int sl, string nuocsx, string nhacungcap, DateTime timenhaphang, DateTime hsd)
        {
            this.id = id;
            this.tenhang = tenhang;
            this.gianhap = gianhap;
            this.sl = sl;
            this.nuocsx = nuocsx;
            this.nhacungcap = nhacungcap;
            this.timenhaphang = timenhaphang;
            this.hsd = hsd;
        }
    }
}
