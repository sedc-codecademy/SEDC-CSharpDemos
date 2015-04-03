using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace Tiered.DataAccess
{
    public interface IRepository<T>
    {
        T GetItemById(int id);
        IEnumerable<T> GetItemsByPredicate(Func<T, bool> predicate);
        T SaveItem(T item);
    }
}
