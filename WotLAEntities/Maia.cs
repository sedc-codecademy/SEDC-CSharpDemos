using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WotLAEntities
{
    internal class Maia : IWeaponWeilder
    {
        public string Name { get; set; }
        public int Energy { get; set; }
        public int Mana { get; set; }

        public void Attack(Creature target)
        {
            if (target is IWeaponWeilder)
            {
                target.Health -= this.Energy;
            }
        }
    }
}
