using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Vehicle
    {
        public string Model { get; set; }
        public int Mileage { get; set; }

        public void DoSomething(string p1, int p2, List<double> p3, Vehicle p4)
        {
            if (string.IsNullOrWhiteSpace(p1))
                throw new ArgumentException("p1");
            if (p2 < 0)
                throw new ArgumentOutOfRangeException("p2");

            foreach (var d in p3)
            {
                if (d < 0)
                    throw new ArgumentException("p3");
            }

            if (p4 == null)
                throw new ArgumentNullException("p4");

            DoSomethingImpl(p1, p2, p3, p4);
        }

        internal void DoSomethingImpl(string p1, int p2, List<double> p3, Vehicle p4)
        {
            throw new NotImplementedException();
        }
    }
}
