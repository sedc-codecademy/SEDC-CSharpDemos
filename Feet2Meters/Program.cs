using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feet2Meters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value in feet ");
            var feetString = Console.ReadLine();

            double feet;
            var check = double.TryParse(feetString, out feet);
            if (!check)
            {
                Console.WriteLine("{0} is not a valid number", feetString);
                return;
            }
            //double feet;
            //try
            //{
            //    feet = double.Parse(feetString);
            //}
            //catch (FormatException fe)
            //{
            //    Console.WriteLine("Exception occurred: {0}", fe.Message);
            //    return;
            //}
            double result = feet * 0.3048;

            string output = string.Format("We got {1} meters from {0} feet ({0}ft={1}m)", feet, result);

            Console.WriteLine(output);
            //Console.ReadLine();
        }
    }
}
