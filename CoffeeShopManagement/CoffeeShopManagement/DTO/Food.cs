using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DTO
{
    public class Food
    {
        public string tenmon, nuocsx, dvt;
        public int gia;

        public Food(string tenmon, int gia, string nuocsx, string dvt)
        {
            this.tenmon = tenmon;
            this.gia = gia;
            this.nuocsx = nuocsx;
            this.dvt = dvt;
        }
    }
}
