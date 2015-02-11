using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WotLAEntities
{
    public abstract class Creature
    {
        private int health;

        public int Health
        {
            get { return health; }
            set
            {
                if (value <= 0)
                {
                    health = 0;
                    IsAlive = false;
                    return;
                }
                health = value;
            }
        }

        public string Name { get; set; }
        public int Power { get; set; }
        public bool IsAlive { get; protected set; }
    }
}
