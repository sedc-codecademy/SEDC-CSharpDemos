using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Selector<T>
    {
        public List<T> SelectNotNulls(List<T> input)
        {
            var result = new List<T>();
            foreach (var item in input)
            {
                if (item != null)
                {
                    result.Add(item);
                }
            }
            return result;
        }

    }
}
