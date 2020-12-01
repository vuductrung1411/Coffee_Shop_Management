using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DTO
{
    public class Account
    {
        public int id;

        public Account(string userName)
        {
            this.id = AccountDAO.Instance.GetIDByUsername(userName);
        }
    }
}
