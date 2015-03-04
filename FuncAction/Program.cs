using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAction
{
    //public delegate int CalculateIntDelegate(int first, int second) ;
    //public delegate double CalculateDoubleDelegate(double first, double second);
    //public delegate int CalculateSomethingDelegate(double number);


    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> myDelegate = Calculator.Add;
            Console.WriteLine(myDelegate(5, 2));

            myDelegate = Calculator.Subtract;
            Console.WriteLine(myDelegate(5, 2));

            myDelegate = Calculator.Multiply;
            Console.WriteLine(myDelegate(5, 2));

            Func<double, double, double> myDoubleDelegate = Calculator.AddDouble;
            Console.WriteLine(myDoubleDelegate(5.2, 2.4));

            Func<double, int> myThirdDelegate = Calculator.Floor;
            Console.WriteLine(myThirdDelegate(5.2));

            Action<double> myPrintDelegate = Calculator.PrintNumber;
            myPrintDelegate(1.1);

            Func<int> myThreeFunc = Calculator.ReturnThree;
            Console.WriteLine(myThreeFunc());

            Action printHelloAction = Calculator.PrintHello;
            printHelloAction();
        }
    }
}
