using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOTLA2
{
    class Program
    {
        private static bool hitAgain = true;

        static void Main(string[] args)
        {
            Fighter fighter = new Fighter
            {
                Name = "Pero",
                Health = 50,
                Power = 10
            };

            fighter.Death += fighterDeathHandler;

            var wife = new FighterWife(fighter);

            while (hitAgain)
            {
                PrintFighter(fighter);
                fighter.TakeAHit(12);
            }

            hitAgain = true;
            fighter.Health = 50;
            while (hitAgain)
            {
                PrintFighter(fighter);
                fighter.TakeAHit(12);
            }

        }

        private static void fighterDeathHandler(object sender, DeathEventArgs dea)
        {
            var fighter = (Fighter) sender;
            Console.WriteLine("{0} died", fighter.Name);
            hitAgain = false;
        }

        private static void PrintFighter(Fighter fighter)
        {
            Console.WriteLine("{0} has {1} health", fighter.Name, fighter.Health);
            //Console.WriteLine("{0} is {1}", fighter.Name,
            //    fighter.IsAlive ? "alive" : "dead");

            Console.ReadLine();
        }
    }
}
