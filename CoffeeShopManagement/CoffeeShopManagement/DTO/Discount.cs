using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DTO
{
    public class Discount
    {
        public string tenCTKM, text;
        public int phantramKM, minGTKM, maxGTKM;
        public DateTime ngayBD, ngayKT;

        public Discount(string tenCTKM, int phantramKM, int minGTKM, int maxGTKM, DateTime ngayBD, DateTime ngayKT, string text)
        {
            this.tenCTKM = tenCTKM;
            this.phantramKM = phantramKM;
            this.minGTKM = minGTKM;
            this.maxGTKM = maxGTKM;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
            this.text = text;
        }
    }
}
