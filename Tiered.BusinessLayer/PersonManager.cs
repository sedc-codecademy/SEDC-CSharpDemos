using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiered.DataAccess;
using Tiered.Entities;

namespace Tiered.BusinessLayer
{
    public class PersonManager
    {
        private IRepository<Person> repository;

        public PersonManager(IRepository<Person> repository)
        {
            this.repository = repository;
        }

        public Person GetPerson(int personId)
        {
            return repository.GetItemById(personId);
        }

        public IEnumerable<Person> GetPersonsByLastName(string lastname)
        {
            return repository
                .GetItemsByPredicate(p => p.LastName == lastname)
                .OrderBy(p => p.FirstName);
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return repository.GetItemsByPredicate(p => true);
        }

        public Person AddPerson(string firstName, string lastName)
        {
            var maxId = GetAllPersons().Max(p => p.ID);
            Person person = new Person
            {
                ID = maxId + 1,
                FirstName = firstName,
                LastName = lastName,
                Accounts = new List<Account>()
            };
            return repository.SaveItem(person);
        }

    }
}
