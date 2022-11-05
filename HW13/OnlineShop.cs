using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13
{
    public class OnlineShop
    {
        public int Id { get; set; }
        public string NameShop { get; set; }
        public string PhoneNumber { get; set; }
        public OnlineShop (int id, string nameshop, string phonenumber)
        {
            Id = id;
            NameShop = nameshop;
            PhoneNumber = phonenumber;
        }
    }
}
