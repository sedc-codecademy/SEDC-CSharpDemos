using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Baker spase = new Baker
            {
                FirstName = "Spase",
                LastName = "Spasevski",
                IdNumber = "12345"
            };

            Salesman trajanka = new Salesman
            {
                FirstName = "Trajanka",
                LastName = "Kostadinova",
                IdNumber = "02468"
            };

            Person weko = new Person
            {
                FirstName = "Wekoslav",
                LastName = "Stefanovski",
                IdNumber = "66666"
            };

            //spase.Sell(weko, new Burek(BurekType.Meso));
            //trajanka.Sell(weko, new Fridge());

            List<ISeller> sellers = new List<ISeller>();

            sellers.Add(spase);
            sellers.Add(trajanka);

            foreach (var seller in sellers)
            {
                seller.Sell(weko, new Fridge());
                seller.PrintSomething();
            }

        }
    }
}
