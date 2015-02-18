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
            var mySquare = new Square(10);
            Console.WriteLine(mySquare.Side);
            Console.WriteLine(mySquare.Area);
            Console.WriteLine(mySquare.Perimeter);

            var myRectangle = new Rectangle(3, 4);
            Console.WriteLine("The rectangle with sides {0} and {1} has an area of {2}, a perimeter of {3} and a diagonal of {4}",
                myRectangle.FirstSide, myRectangle.SecondSide, myRectangle.Area, myRectangle.Perimeter, myRectangle.Diagonal);

            PrintArea(myRectangle, 5);

            Test(2, new Rectangle(1, 2).LongerSide(), "Wrong Second Longer Side");
            Test(2, new Rectangle(2, 1).LongerSide(), "Wrong First Longer Side");
            Test(2, new Rectangle(2, 2).LongerSide(), "Wrong Same Longer Side");
            Test(4, new Rectangle(3, 4).LongerSide(), "Wrong Second Longer Side");

            var square = new Square(100);
            var rectangle = new Rectangle(4, 5);

            Console.WriteLine(GetBiggerPerimeter(square, rectangle));
        }

        static void Test(string expected, string actual, string message)
        {
            if (expected != actual)
            {
                Console.WriteLine("FAIL {0} (expected = {1}, actual = {2})", message, expected, actual);
            }
            else
            {
                Console.WriteLine("Pass");
            }
        }

        static void Test(double expected, double actual, string message)
        {
            if (expected != actual)
            {
                Console.WriteLine("FAIL {0} (expected = {1}, actual = {2})", message, expected, actual);
            }
            else
            {
                Console.WriteLine("Pass");
            }
        }

        private static void PrintArea(Rectangle rectangle, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(rectangle.Area);
            }
        }

        private static double GetBiggerPerimeter(Square square, Rectangle rectangle)
        {
            var squarePerimeter = square.Perimeter;
            var rectanglePerimeter = rectangle.Perimeter;
            return (squarePerimeter > rectanglePerimeter) ? squarePerimeter : rectanglePerimeter;
        }
    }

    public class Square
    {
        public static int NumberOfSides
        {
            get { return 4; }
        }

        public Square(double side)
        {
            Side = side;
        }

        public double Side { get; set; }

        public double Area
        {
            get { return Side * Side; }
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

    public class Rectangle
    {
        public Rectangle(double first, double second)
        {
            FirstSide = first;
            SecondSide = second;
        }

        public double FirstSide { get; set; }
        public double SecondSide { get; set; }

        public double Area
        {
            get { return FirstSide * SecondSide; }
        }

        public double Perimeter
        {
            get { return FirstSide * 2 + SecondSide * 2; }
        }

        public double Diagonal
        {
            get { return Math.Sqrt(FirstSide * FirstSide + SecondSide * SecondSide); }
        }

        public double LongerSide()
        {
            return (FirstSide > SecondSide) ? FirstSide : SecondSide;
        }
    }
}
