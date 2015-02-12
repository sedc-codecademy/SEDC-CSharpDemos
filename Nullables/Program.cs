using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            //var x = new Nullables();

            //Console.WriteLine(x.i);
            //Console.WriteLine(x.date);
            //Console.WriteLine(x.guid);
            //Console.WriteLine(x.name == null);

            Person weko = new Person {Name = "Weko"};

            Console.WriteLine(weko.Age.GetValueOrDefault());
            weko.Age = 0x25;
            Console.WriteLine(weko.Age.GetValueOrDefault());
            weko.Age = null;
            Console.WriteLine(weko.Age.GetValueOrDefault());

            weko.Age++;
            Console.WriteLine(weko.Age.Value);
        }
    }
}
