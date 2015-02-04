using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WotLAEntities
{
    public class Elf : Creature
    {
        public bool IsArcher { get; set; }

        public Elf()
        {
            IsArcher = true;
        }
    }
}
