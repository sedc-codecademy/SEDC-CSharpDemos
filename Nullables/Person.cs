using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullables
{
    public class Person
    {
        //public bool HasBirthdate { get; set; }
        //public DateTime Birthdate { get; set; }

        public Nullable<DateTime> Birthdate { get; set; }
        public Nullable<int> Age { get; set; }
        public string Name { get; set; }

    }
}
