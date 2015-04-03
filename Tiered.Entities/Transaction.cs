using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiered.Entities
{
    public class Transaction
    {
        public int ID { get; set; }
        public decimal Ammount { get; set; }
        public Account WithdrawingAccount { get; set; }
        public Account DepositingAccount { get; set; }
    }
}
