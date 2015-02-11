using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WotLAEntities
{
    public class Elf : Creature
    {
        public Elf(string name)
        {
            this.Name = name;
            Health = 60;
            Power = 20;
            IsAlive = true;
        }

        public override string ToString()
        {
            return string.Format("Elf {0} ({1})", Name, Health);
        }

    }
}
