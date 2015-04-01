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

        internal void Hit(Vehicle secondVehicle)
        {
            this.HasDamage = true;
            secondVehicle.HasDamage = true;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Name, HasDamage ? "Damaged" : "New");
        }

        private EventHandler junkHandler;

        private void InvokeJunk()
        {
            //todo: write here
        }

        public event EventHandler OnJunked
        {
            add { junkHandler += value; }
            remove { junkHandler -= value; }
        }
    }
}
