using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WotLAEntities
{
    public class Human : Creature
    {
        internal Maia Master;

        public override string ToString()
        {
            if (Master == null)
                return string.Format("Human {0} ({1})", Name, Health);
            else
                return string.Format("Human {0} ({1}) - Enthralled to {2}", Name, Health, Master);
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
