using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAction
{
    public class Calculator
    {
        public static int Add(int first, int second)
        {
            return first + second;
        }

        public static double AddDouble(double first, double second)
        {
            return first + second;
        }

        public static int Subtract(int first, int second)
        {
            return first - second;
        }

        public static int Multiply(int first, int second)
        {
            return first * second;
        }

        public static int Floor(double number)
        {
            return (int) number;
        }

        public static void PrintNumber(double number)
        {
            Console.WriteLine("{0:##.000}",number);
        }

        public static int ReturnThree()
        {
            return 3;
        }

        public static void PrintHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
