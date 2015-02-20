using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public Person():this(string.Empty, string.Empty)
        {
            
        }

        public Person(string firstName, string lastName)
            : this(firstName, lastName, string.Empty)
        {
        }

        public Person(string firstName, string lastName, string middleName) 
        {
            this.FirstName = firstName.Trim();
            this.LastName = lastName.Trim();
            this.MiddleName = middleName.Trim();
        }

        public string GetFullName()
        {
            return string.Format("The human is {0} {1} {2}", 
                FirstName, MiddleName, LastName);
        }
    }

    public class Student : Person
    {
        public string IndexNumber { get; set; }

        public Student() : this(string.Empty, string.Empty, string.Empty, string.Empty)
        {
        }

        public Student(string firstName, string lastName, string index)
            : this(firstName, lastName, string.Empty, index)
        {
        }


        public Student(string firstName, string lastName, string middleName, string index)
            : base(firstName, lastName, middleName)
        {
            this.IndexNumber = index;
        }

    }
}
