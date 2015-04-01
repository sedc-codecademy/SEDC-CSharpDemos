using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExercises
{
    public class Vehicle
    {
        public string Name { get; set; }

        public bool HasDamage { get; set; }

        public bool Junked { get; private set; }

        internal void Hit(Vehicle secondVehicle)
        {
            this.HasDamage = true;
            secondVehicle.HasDamage = true;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Name, HasDamage ? "Damaged" : "New");
        }
    }
}
