using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySquare = new Square {Side = 10};
            Console.WriteLine(mySquare.Side);
            Console.WriteLine(mySquare.Area);
            Console.WriteLine(mySquare.Perimeter);
        }
    }

    public class Square
    {
        public double Side { get; set; }

        public double Area
        {
            get { return Side*Side; }
        }

        public double Perimeter
        {
            get { return 4 * Side; }
        }

        //public double GetArea()
        //{
        //    var area = Side*Side;
        //    return area;
        //}

        //public double GetPerimeter()
        //{
        //    var perimeter = 4 * Side;
        //    return perimeter;
        //}

    }
}
