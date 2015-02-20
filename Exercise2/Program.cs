using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Person weko = new Person("Wekoslav","Stefanovski");

            Test("Wekoslav", weko.FirstName,"Wrong first name");
            Test("Stefanovski", weko.LastName, "Wrong last name");
            Test(string.Empty, weko.MiddleName, "Wrong middle name");

            weko = new Person(" Wekoslav", "  Stefanovski  ");

            Test("Wekoslav", weko.FirstName, "Wrong first name");
            Test("Stefanovski", weko.LastName, "Wrong last name");
            Test(string.Empty, weko.MiddleName, "Wrong middle name");

            weko = 
               new Person(" Wekoslav", "  Stefanovski  ", "Kole");

            Test("Wekoslav", weko.FirstName, "Wrong first name");
            Test("Stefanovski", weko.LastName, "Wrong last name");
            Test("Kole", weko.MiddleName, "Wrong middle name");

            weko = new Person();
            Test(string.Empty, weko.FirstName, "Wrong first name");
            Test(string.Empty, weko.LastName, "Wrong last name");
            Test(string.Empty, weko.MiddleName, "Wrong middle name");
             * */

            Student weko = new Student();
            Test(string.Empty, weko.FirstName, "Wrong first name");
            Test(string.Empty, weko.LastName, "Wrong last name");
            Test(string.Empty, weko.MiddleName, "Wrong middle name");
            Test(string.Empty, weko.IndexNumber, "Wrong index number");

            weko = new Student("  Wekoslav", "Stefanovski", "239/95");
            Test("Wekoslav", weko.FirstName, "Wrong first name");
            Test("Stefanovski", weko.LastName, "Wrong last name");
            Test(string.Empty, weko.MiddleName, "Wrong middle name");
            Test("239/95", weko.IndexNumber, "Wrong index number");

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
    }
}
