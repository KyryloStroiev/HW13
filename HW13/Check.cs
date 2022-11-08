using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

{
    public class Check: OnlineShop, IBuyer, IProduct
    {
        public Check(int idshop, string nameshop, string phonenumbershop, int numbcheck,
            int idbuyer, string firstname, 
            string lastname, string phonenumber, int codeproduct, 
            string nameproduct, double priceproduct ) : base(idshop, nameshop, phonenumbershop)
        {
            IdShop = idshop;
            NameShop = nameshop;
            PhoneNumberShop = phonenumbershop;
            Numbcheck = numbcheck;
            IdBuyer = idbuyer;
            FirsName = firstname;
            LastName = lastname;
            PhoneNumber = phonenumber;
            Codeproduct = codeproduct;
            Nameproduct = nameproduct;
            Priceproduct = priceproduct;

        }

        public int IdShop { get; set; }
        public string NameShop { get; set; }
        public string PhoneNumberShop { get; set; }

        public int Numbcheck { get; set; }
        public int IdBuyer { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int Codeproduct { get; set; }
        public string Nameproduct { get; set; }
        public double Priceproduct { get; set; }
        

    }
}

