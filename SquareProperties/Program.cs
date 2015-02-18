using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square {Side = 5};
            Console.WriteLine(s.Area);

            s.Area = 2000;
            Console.WriteLine(s.Area);

            Console.WriteLine(s.Side);
        }
    }
}
