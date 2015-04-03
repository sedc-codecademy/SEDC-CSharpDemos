using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiered.Entities;

namespace Tiered.DataAccess
{
    public class TransactionRepository : IRepository<Transaction>
    {
        private readonly List<Transaction> transactions = new List<Transaction>();

        public Transaction GetItemById(int id)
        {
            var result = transactions.SingleOrDefault(t => t.ID == id);
            return result;
        }

        public IEnumerable<Transaction> GetItemsByPredicate(Func<Transaction, bool> predicate)
        {
            var filteredTransactions = transactions.Where(predicate);
            return filteredTransactions;
        }

        public Transaction SaveItem(Transaction item)
        {
            if (transactions.Any(t => t.ID == item.ID))
                throw new InvalidOperationException("Transactions with specified ID already exists");

            transactions.Add(item);
            return item;
        }
    }
}
