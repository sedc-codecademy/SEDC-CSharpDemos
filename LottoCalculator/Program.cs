using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new LottoCalc("National lottery", 20, 5);
            calculator.Name = "State lottery";
            calculator.NumberDrawn++;

            Console.WriteLine("Calculating combinations for {2} ({0} of {1})",
                calculator.NumberDrawn, calculator.NumberOfBalls, calculator.Name);

            var result = calculator.Calculate();
            Console.WriteLine(result);
        }
    }
}
