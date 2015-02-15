using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WotLAEntities
{
    public static class CreatureFactory
    {
        private static Maia Gandalf = new Maia {Name = "Gandalf"};
        private static Maia Sauron = new Maia { Name = "Sauron" };

        private static int ElfCounter = 0;
        private static int HumanCounter = 0;
        private static int OrcCounter = 0;

        private static Random r = new Random();

        public static Creature MakeCreature()
        {
            var type = (CreatureType)r.Next(3);
            return MakeCreature(type);
        }

        public static Creature MakeCreature(CreatureType type)
        {
            switch (type)
            {
                case CreatureType.Elf:
                    return MakeElf();
                case CreatureType.Human:
                    return MakeHuman();
                case CreatureType.Orc:
                    return MakeOrc();
                default:
                    throw new ArgumentOutOfRangeException("type");
            }
        }

        private static Elf MakeElf()
        {
            ElfCounter++;
            string name = string.Format("#{0}", ElfCounter);

            var type = r.Next(2);
            if (type == 0)
            {
                return new Elf(name);
            }
            else
            {
                return new ElfFighter(name);
            }
        }

        private static Human MakeHuman()
        {
            HumanCounter++;
            string name = string.Format("#{0}", HumanCounter);
            var type = r.Next(2);
            if (type == 0)
            {
                return new Human(name);
            }
            else
            {
                var fighter = new HumanFighter(name);
                var masterIndex = r.Next(3);
                switch (masterIndex)
                {
                    case 0:
                        break;
                    case 1:
                        fighter.Master = Gandalf;
                        break;
                    case 2:
                        fighter.Master = Sauron;
                        break;
                }
                return fighter;
            }
        }

        private static Orc MakeOrc()
        {
            OrcCounter++;
            string name = string.Format("#{0}", OrcCounter);
            return new Orc(name);
        }
    }
}
