using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsStart
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = Add(1, 2);
            Console.WriteLine(result1);

            var result2 = Add(1.1, 2.3);
            Console.WriteLine(result2);

            var result3 = Add(1.1, "Petar");
            Console.WriteLine(result3);

        }

        public static double Add(double x, double y)
        {
            Console.WriteLine("Double Add Called");
            return x + y;
        }

        public static int Add(int x, int y)
        {
            Console.WriteLine("Int Add Called");
            return x + y;
        }

        public static string Add(double x, string y)
        {
            Console.WriteLine("DS Add Called");
            return x.ToString() +" "+ y;
        }

        public static void AddPrint(double x, string y)
        {
            Console.WriteLine("DS Add Called");
            return;
        }
    }

}
