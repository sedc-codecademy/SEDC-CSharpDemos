using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Tiered.Entities
{
    public class Account
    {
        public int ID { get; set; }
        public string AccountNumber { get; set; }
        public Person Owner { get; set; }
        public decimal Balance { get; set; }
    }
}
