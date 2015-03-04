using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WOTLA2
{
    public class DeathEventArgs : EventArgs
    {
        public int Health { get; set; }
    }
}
