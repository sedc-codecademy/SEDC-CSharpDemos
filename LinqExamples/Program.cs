using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = Enumerable.Range(0, 200).Select(_ => Person.GeneratePerson());

            //foreach (var person in persons)
            //{
            //    Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
            //}

            //List<int> numbers = new List<int>();
            //foreach (var person in persons)
            //{
            //    var number = person.LastName.Count();
            //    numbers.Add(number);
            //}

            //List<Person> result = new List<Person>();
            //foreach (var person in persons)
            //{
            //    if (person.LastName.Count() == 11)
            //        result.Add(person);
            //}

            //var result = persons
            //    .Where(p => p.LastName.Count() == 11)
            //    .Where(p => p.FirstName.Count() == 6)
            //    .Select(p => p.FirstName)
            //    .OrderBy(f => f[2])
            //    .ThenByDescending(f => f[1]);


            var result = persons
                .Where(p => p.LastName.Count() == 11)
                .Where(p => p.FirstName.Count() == 6)
                .OrderBy(p => p.FirstName[2])
                .ThenBy(p => p.IdNumber);

            foreach (var item in result)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }


        }
    }
}
