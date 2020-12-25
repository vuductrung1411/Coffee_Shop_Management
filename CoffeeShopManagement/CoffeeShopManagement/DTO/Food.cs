using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DTO
{
    public class Food
    {
        public string tenmon, dvt;
        public int gia, id;

        public Food(string tenmon, int gia, string dvt, int id)
        {
            this.tenmon = tenmon;
            this.gia = gia;
            this.dvt = dvt;
            this.id = id;
        }

        public Food(string tenmon, int gia, string dvt)
        {
            this.tenmon = tenmon;
            this.gia = gia;
            this.dvt = dvt;
        }


        public Food() { }
    }
}
