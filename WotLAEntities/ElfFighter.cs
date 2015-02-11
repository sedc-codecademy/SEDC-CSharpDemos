using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WotLAEntities
{
    public class ElfFighter : Elf, IWeaponWeilder
    {
        public ElfFighter(string name) : base(name)
        {
            IsArcher = true;
        }

        public bool IsArcher { get; set; }


        public void SwingWeapon()
        {
            
        }

        public void DropWeapon()
        {
            
        }

        public override string ToString()
        {
            return string.Format("Elf Fighter {0} ({1})", Name, Health);
        }

        public void Attack(Creature target)
        {
            target.Health -= this.Power;
        }
    }
}
