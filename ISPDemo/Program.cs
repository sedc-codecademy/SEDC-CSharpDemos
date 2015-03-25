using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IMarker> managers = new List<IMarker>
            {
                new RegularCalc(),
                new FileReader(),
            };

            Stopwatch s = new Stopwatch();
            s.Start();
            for (int i = 0; i < 1000000; i++)
            {
                foreach (var manager in managers.OfType<ICalculator>())
                {
                    manager.Add(1, 2);
                }
            }
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds);

            s.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                foreach (var manager in managers)
                {
                    if (manager is ICalculator)
                    {
                        ((ICalculator) manager).Add(1, 2);
                    }
                }
            }
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds);


        }
    }
}
