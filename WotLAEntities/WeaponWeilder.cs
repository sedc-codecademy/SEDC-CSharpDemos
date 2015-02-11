using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WotLAEntities
{
    public interface IWeaponWeilder
    {
        void Attack(Creature target);
    }
}
