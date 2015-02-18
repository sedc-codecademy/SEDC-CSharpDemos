using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            var weko = new Human("Wekoslav Stefanovski");
            Test("Wekoslav",weko.FirstName,"First name incorrectly set");
            Test("Stefanovski", weko.LastName, "Last name incorrectly set");

            var sukharto = new Human("Sukharto");
            Test("Sukharto", sukharto.FirstName, "First name incorrectly set");
            Test(string.Empty, sukharto.LastName, "Last name incorrectly set");

            var jfk = new Human("John Fitzgerald Kennedy");
            Test("John", jfk.FirstName, "First name incorrectly set");
            Test("Fitzgerald Kennedy", jfk.LastName, "Last name incorrectly set");


            /*
             var students = new List<Human>{
		new Human{ FirstName = "Ervo", LastName = "Jonuzoski"},
		new Human{ FirstName = "Monika", LastName = "Jovanova"},
		new Human{ FirstName = "Vladimir", LastName = "Totochevski"},
		new Human{ FirstName = "Ilche", LastName = "Ivanovski"},
		new Human{ FirstName = "Darko", LastName = "Kotoski"},
	};
             */

        }

        static void Test(string expected, string actual, string message)
        {
            if (expected != actual)
            {
                Console.WriteLine("FAIL {0} (expected = {1}, actual = {2})" ,message, expected, actual);
            }
            else
            {
                Console.WriteLine("Pass");
            }
        }
    }



    internal class Human
    {
        public Human()
        {
        }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Human(string fullName)
        {
            //todo
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}
