using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqExamples
{
    partial class Person
    {
        public string IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public override string ToString()
        //{
        //    return string.Format("{1}, {0} - {2}", FirstName, LastName, IdNumber);
        //}
    }


}
