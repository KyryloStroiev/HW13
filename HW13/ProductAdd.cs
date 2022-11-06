using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13;

public  class ProductAdd : IProduct
{
    public int Codeproduct { get; set; }
    public string Nameproduct { get; set; }
    public double Priceproduct { get; set; }
    public ProductAdd(int codeproduct, string nameproduct, double priceproduct)
    {
        Codeproduct = codeproduct;
        Nameproduct = nameproduct;
        Priceproduct = priceproduct;
    }
   
       public void AddProduct(string path)
    {
        var productadd = new ProductAdd(Codeproduct, Nameproduct, Priceproduct);

        Console.WriteLine("Ведiть данi про товар:");
        Console.WriteLine("Код товару, назва, і ціна");
        string cproduct = Console.ReadLine();
        Codeproduct = Convert.ToInt32(cproduct);
        Nameproduct = Console.ReadLine();
        string cpriceproduct = Console.ReadLine();
        Priceproduct = Convert.ToInt32(cpriceproduct);

        File.AppendAllLines(path, new[] { $"{Codeproduct}, {Nameproduct}, {Priceproduct}" });
    }
    public void AddProductPrint()
    {
        var AddFile = @"C:\Users\User\Desktop\HM\HW13\HW13\Product.txt";
        AddProduct(AddFile);
    }
}
    
