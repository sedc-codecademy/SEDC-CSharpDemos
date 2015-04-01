using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class Person
    {
        public string IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string PinCode { get; set; }

        private int age;

        public string MiddleName;

        public string PrintPerson()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

        private string PrintPerson2(int number)
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

        private static long PrintPerson22()
        {
            return 7;
        }

        public static long Square(int number)
        {
            return number * number;
        }

        public static long Add(int number, int number2, int number3)
        {
            return number + number2 + number3;
        }



        public static string Country { get; set; }

        private static int CityId
        {
            set
            {
                
            }
        }
    }
}
