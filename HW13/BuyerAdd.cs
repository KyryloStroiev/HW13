using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW13;

public class BuyerAdd : IBuyer
{
    public int IdBuyer { get; set; }
    public string FirsName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public BuyerAdd(int idBuyer, string firsName, string lastName, string phoneNumber)
    {
        IdBuyer = idBuyer;
        FirsName = firsName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
    }
  public void AddBuyer(string path)
    {
        var buyeradd = new BuyerAdd(IdBuyer, FirsName, LastName, PhoneNumber);
        var AddFile = @"C:\Users\User\Desktop\HM\HW13\HW13\Product.txt";
        Console.WriteLine("Ведiть данi покупця:");
        Console.WriteLine("Код покупця, ім'я, прізвище, номер телефона");
        string idbuyer = Console.ReadLine();
        IdBuyer = Convert.ToInt32(idbuyer);
        FirsName = Console.ReadLine();
        LastName = Console.ReadLine();
        PhoneNumber = Console.ReadLine();

        File.AppendAllLines(path, new[] { $"{IdBuyer}, {FirsName}, {LastName}, {PhoneNumber}" });

    }
    public override string ToString()
        => $"{IdBuyer}, {FirsName}, {LastName}, {PhoneNumber}";



}
