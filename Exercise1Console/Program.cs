using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1Model;

namespace Exercise1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var weko = new Human();
            weko.FirstName = "Wekoslav";
            weko.LastName = "Stefanovski";

            var result = weko.GetFullName();
            Console.WriteLine(result);
        }
    }
}
