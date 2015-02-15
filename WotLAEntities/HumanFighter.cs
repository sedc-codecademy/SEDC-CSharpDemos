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
            if (Master == null)
                return string.Format("Human Fighter {0} ({1})", Name, Health);
            else
                return string.Format("Human Fighter {0} ({1}) - Enthralled to {2}", Name, Health, Master.Name);
        }

        public void Attack(Creature target)
        {
            target.Health -= this.Power;
        }
    }
}
