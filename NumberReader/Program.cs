using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberReader
{
    class Program
    {
        private const int NumberOfNumbers = 10;

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < NumberOfNumbers; i++)
            {
                Console.Write("Enter the number #{0} ", i+1);
                var line = Console.ReadLine();

                int number;
                var check = int.TryParse(line, out number);
                if (!check)
                {
                    Console.WriteLine("{0} is not a valid number", line);
                    continue;
                }
                numbers.Add(number);
            }

            Console.WriteLine("You have entered {0} correct numbers", numbers.Count);

            int max = int.MinValue;
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //}

            foreach (var number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine("The maximum value is {0}", max);
        }
    }
}
