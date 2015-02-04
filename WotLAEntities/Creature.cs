using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WotLAEntities
{
    public abstract class Creature
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Power { get; set; }
    }
}
