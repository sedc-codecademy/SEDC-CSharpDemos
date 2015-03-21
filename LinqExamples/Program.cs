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
            var persons = Enumerable.Range(0, 20000).Select(_ => Person.GeneratePerson());

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
                //Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }

            var byLastName = persons.GroupBy(p => p.LastName).OrderBy(g => g.Key);

            DateTime start = DateTime.Now;

            StringBuilder resultLineBuilder = new StringBuilder();
            foreach (var group in byLastName)
            {
                resultLineBuilder.AppendFormat("{0}: ", group.Key);
                foreach (var person in group.OrderBy(x => x.FirstName))
                {
                    resultLineBuilder.AppendFormat("{0}, ", person.FirstName);
                }
                resultLineBuilder.AppendLine();
            }

            DateTime end = DateTime.Now;

            string resultLine = resultLineBuilder.ToString();
            Console.WriteLine(resultLine);
            Console.WriteLine(end - start);


        }

    }
}
