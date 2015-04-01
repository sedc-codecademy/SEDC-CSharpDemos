using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventExerciseWin
{
    public class Vehicle
    {
        public string Name { get; set; }

        public bool HasDamage
        {
            get { return _hasDamage; }
            set
            {
                if (value)
                    InvokeHit();
                _hasDamage = value;
            }
        }

        private void InvokeHit()
        {
            if (hit != null)
                hit(this, new EventArgs());
        }

        internal void Hit(Vehicle secondVehicle)
        {
            this.HasDamage = true;
            secondVehicle.HasDamage = true;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Name, HasDamage ? "Damaged" : "New");
        }

        private EventHandler hit;
        private bool _hasDamage;

        public event EventHandler OnHit
        {
            add { hit += value; }
            remove { hit -= value; }
        }

    }
}
