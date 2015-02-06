using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WotLAEntities
{
    public static class CreatureFactory
    {

        public static string Name { get; set; }

        public static Creature MakeCreature()
        {
            Random r = new Random();
            var type = (CreatureType)r.Next(3);

            switch (type)
            {
                case CreatureType.Elf:
                    return new Elf();
                case CreatureType.Human:
                    return new Human();
                case CreatureType.Orc: 
                    return new Orc();
                default:
                    throw new InvalidOperationException("Invalid type");
            }
        }

        public static Creature MakeCreature(CreatureType type)
        {
            switch (type)
            {
                case CreatureType.Elf:
                    return new Elf();
                case CreatureType.Human:
                    return new Human();
                case CreatureType.Orc:
                    return new Orc();
                default:
                    throw new ArgumentOutOfRangeException("type");
            }
        }
    }
}
