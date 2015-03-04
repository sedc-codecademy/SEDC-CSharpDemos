using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOTLA2
{
    public class FighterWife
    {
        public Fighter Fighter { get; private set; }

        public FighterWife(Fighter fighter)
        {
            Fighter = fighter;
            Fighter.Death += fighterDeathHandler;
        }

        private void fighterDeathHandler(object sender, DeathEventArgs dea)
        {
            Console.WriteLine("Wife of {0} is lamenting his death", Fighter.Name);
            Fighter.Death -= fighterDeathHandler;
        }
    }
}
