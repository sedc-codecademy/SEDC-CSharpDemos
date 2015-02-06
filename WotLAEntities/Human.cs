using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WotLAEntities
{
    public class Human : Creature
    {
        public override string ToString()
        {
            return string.Format("Human {0} ({1})", Name, Health);
        }

        public Human(string name)
        {
            this.Name = name;
            Health = 100;
            Power = 10;
            IsAlive = true;
        }
    }
}
