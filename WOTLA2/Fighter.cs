using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOTLA2
{
    public class Fighter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Power { get; set; }

        private DeathDelegate death;
        public event DeathDelegate Death
        {
            add { death += value; }
            remove { death -= value; }
        }

        public bool IsAlive
        {
            get { return Health > 0; }
        }

        public void TakeAHit(int power)
        {
            Health -= power;

            if (Health <= 0)
            {
                TriggerDeathEvent();
            }

        }

        private void TriggerDeathEvent()
        {
            if (death != null)
                death(this, new DeathEventArgs {Health = this.Health});
        }
    }
}
