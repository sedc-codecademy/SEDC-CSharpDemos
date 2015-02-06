using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WotLAEntities
{
    public static class CreatureFactory
    {
        private static int ElfCounter = 0;
        private static int HumanCounter = 0;
        private static int OrcCounter = 0;

        public static Creature MakeCreature()
        {
            Random r = new Random();
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
            return new Elf(name);
        }

        private static Human MakeHuman()
        {
            HumanCounter++;
            string name = string.Format("#{0}", HumanCounter);
            return new Human(name);
        }

        private static Orc MakeOrc()
        {
            OrcCounter++;
            string name = string.Format("#{0}", OrcCounter);
            return new Orc(name);
        }
    }
}
