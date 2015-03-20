using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>();

            //for (int i = 0; i < 50; i++)
            //{
            //    numbers.Add((i + 1) * 3);
            //}

            //ListPrinter<int> printer = new ListPrinter<int>(numbers);
            //printer.PrintListFragment(0, 5);
            //printer.PrintPage(3, 10);

            List<Person> persons = new List<Person>();
            for (int i = 0; i < 50; i++)
            {
                persons.Add(Person.GeneratePerson());
            }

            Random r = new Random();
            int methodSelector = r.Next(3);
            Func<Person, string> formatter = Printer;
            switch (methodSelector)
            {
                case 0:
                    formatter = p => string.Format("{0} {1}", p.FirstName, p.LastName);
                    break;
                case 1:
                    formatter = p => string.Format("{0}, {1}", p.LastName, p.FirstName);
                    break;
                case 2:
                default:
                    formatter = x => string.Format("{0} {1}", x.IdNumber, x.LastName);
                    break;
            }

            Console.WriteLine(methodSelector);

            ListPrinter<Person> printer = new ListPrinter<Person>(persons);
            //printer.PrintListFragment(0, 5);
            printer.PrintPage(3, 10, formatter);

        }

        private static string Printer(Person person)
        {
            return person.FirstName;
        }

    }
}
