using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiered.Entities;

namespace Tiered.DataAccess
{
    public class PersonRepository : IRepository<Person>
    {
        private readonly List<Person> persons = new List<Person>
        {
            //new Person
            //{
            //    ID = 1,
            //    FirstName = "Wekoslav",
            //    LastName = "Stefanovski",
            //    Accounts = new List<Account>()
            //}
        };

        public Person GetItemById(int id)
        {
            var person = persons.SingleOrDefault(p => p.ID == id);
            return person;
        }

        public IEnumerable<Person> GetItemsByPredicate(Func<Person, bool> predicate)
        {
            var filteredPersons = persons.Where(predicate);
            return filteredPersons;
        }

        public Person SaveItem(Person item)
        {
            persons.Add(item);
            return item;
        }
    }
}
