using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WotLAEntities
{
    public class HumanFighter : Human, IWeaponWeilder
    {
        public HumanFighter(string name)
            : base(name)
        {
        }

        public override string ToString()
        {
            return string.Format("Human Fighter {0} ({1})", Name, Health);
        }

        public void Attack(Creature target)
        {
            target.Health -= this.Power;
        }
    }
}
