using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitsFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number ");
            var line = Console.ReadLine();

            int number;
            var check = int.TryParse(line, out number);
            if (!check)
            {
                Console.WriteLine("{0} is not a valid number", line);
                return;
            }

            var digits = new List<int>();

            while (number != 0)
            {
                int cifra = number%2;
                number /= 2;
                digits.Add(cifra);
            }

            //for (int i = digits.Count -1 ; i >=0; i--)
            //{
            //    Console.WriteLine(digits[i]);
            //}

            //for (int i = 0; i < digits.Count; i++)
            //{
            //    var index = digits.Count - i - 1;
            //    Console.WriteLine(digits[index]);
            //}

            digits.Reverse();
            foreach (var digit in digits)
            {
                Console.Write("{0}",digit);
            }
            Console.WriteLine();
        }
    }
}
