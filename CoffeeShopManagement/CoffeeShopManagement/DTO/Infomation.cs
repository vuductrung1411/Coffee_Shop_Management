using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DTO
{
    public class Infomation
    {
        #region Link
        private string ShopInfoLink = @".\Information\Shop Infomation.txt";
        #endregion

        private string[] arrShopInfo;
        public string shopOwner, shopName, shopSlogan, shopChair, shopTableID, shopSDT;

        private static Infomation instance;

        public static Infomation Instance
        {
            get { if (instance == null) instance = new Infomation(); return instance; }
            private set => instance = value;
        }

        private Infomation() { }

        public void LoadInfo()
        {
            arrShopInfo = File.ReadAllLines(this.ShopInfoLink);
            this.shopOwner = arrShopInfo[0];
            this.shopName = arrShopInfo[1];
            this.shopSlogan = arrShopInfo[2];
            this.shopSDT = arrShopInfo[3];
            this.shopChair = arrShopInfo[4];
            this.shopTableID = arrShopInfo[5];
        }
    }
}
