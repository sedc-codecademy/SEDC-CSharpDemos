using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiered.Entities
{
    public static class EnumerableExtensions
    {
        public static int MaxOrDefault<T>(this IEnumerable<T> source, Func<T, int> selector)
        {
            if (source.Any())
            {
                return source.Max(selector);
            }
            return 0;
        }

    }
}
