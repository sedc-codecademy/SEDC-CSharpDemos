using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Homework3._5
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }

        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }
    }

    public interface ISeller
    {
        void Sell(Person customer, Product product);
    }

    public class Baker : Person, ISeller
    {
        public void Sell(Person customer, Product product)
        {
            Console.WriteLine("Baked good sale by {0} to {1} of {2}", 
                this.FullName, customer.FullName, product.Name);
        }
    }

    public class Salesman : Person, ISeller
    {

        public void Sell(Person customer, Product product)
        {
            Console.WriteLine("Misc good sale of {2} to {1} from {0}",
    this.FullName, customer.FullName, product.Name);
        }
    }

    public abstract class Product
    {
        public string Name { get; set; }
    }

    public enum BurekType
    {
        Meso,
        Sirenje,
        Spanak,
        Pizza,
        Custom
    }

    public class Burek : Product
    {
        public Burek(BurekType type)
        {
            Name = type.ToString();
        }
    }

    public class Fridge : Product
    {
        public Fridge()
        {
            Name = "Fridge";
        }
    }

    public static class ISellerExtensions
    {
        public static void PrintSomething(this ISeller seller)
        {
            Console.WriteLine(seller.GetType());
        }
    }


}
