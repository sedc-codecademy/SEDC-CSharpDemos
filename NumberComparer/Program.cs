using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            IntResult firstResult = ReadInteger();
            if (!firstResult.Success)
            {
                Console.WriteLine("{0} is not a valid number", firstResult.Original);
                return;
            }

            IntResult secondResult = ReadInteger();
            if (!secondResult.Success)
            {
                Console.WriteLine("{0} is not a valid number", secondResult.Original);
                return;
            }

            string message;
            if (firstResult.Result > secondResult.Result)
            {
                message = "{0} is bigger that {1}";
            }
            else
            {
                message = "{0} is NOT bigger that {1}";
            }

            Console.WriteLine(message, firstResult.Result, secondResult.Result);
        }

        private static IntResult ReadInteger()
        {
            IntResult result = new IntResult();

            Console.Write("Enter the value ");
            var readValue = Console.ReadLine();
            result.Original = readValue;

            int intValue;
            var check = int.TryParse(readValue, out intValue);
            if (check)
            {
                result.Result = intValue;
                result.Success = true;
            }
            else
            {
                result.Success = false;
            }
            return result;
        }
    }
}
