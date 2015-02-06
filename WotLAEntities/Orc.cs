using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WotLAEntities
{
    public class Orc : Creature
    {
        public override string ToString()
        {
            //return "Orc " + Name + " (" + Health + ")";
            return string.Format("Orc {0} ({1})", Name, Health);
        }

        public Orc(string name)
        {
            this.Name = name;
            Health = 200;
            Power = 20;
            IsAlive = true;
        }
    }
}
