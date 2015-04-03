using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiered.Entities;

namespace Tiered.DataAccess
{
    public class AccountRepository : IRepository<Account>
    {
        private readonly List<Account> accounts = new List<Account>();

        public Account GetItemById(int id)
        {
            var result = accounts.SingleOrDefault(a => a.ID == id);
            return result;
        }

        public IEnumerable<Account> GetItemsByPredicate(Func<Account, bool> predicate)
        {
            var filteredAccounts = accounts.Where(predicate);
            return filteredAccounts;
        }

        public Account SaveItem(Account item)
        {
            if (accounts.Any(a => a.ID == item.ID))
                throw new InvalidOperationException("Account with specified ID already exists");

            accounts.Add(item);
            return item;
        }
    }
}
