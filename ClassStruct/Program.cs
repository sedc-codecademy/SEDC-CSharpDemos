using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DemoClass> classes = new List<DemoClass>();
            List<DemoStruct> structs = new List<DemoStruct>();

            for (int i = 0; i < 10; i++)
            {
                var newClass = new DemoClass
                {
                    Name = string.Format("Class #{0}", i + 1)
                };
                classes.Add(newClass);

                var newStruct = new DemoStruct
                {
                    Name = string.Format("Struct #{0}", i + 1)
                };
                structs.Add(newStruct);
            }

            foreach (var demoClass in classes)
            {
                ChangeClass(demoClass);
            }

            foreach (var demoClass in classes)
            {
                Console.WriteLine(demoClass.Name);
            }

            foreach (var demoStruct in structs)
            {
                ChangeStruct(demoStruct);
            }

            foreach (var demoStruct in structs)
            {
                Console.WriteLine(demoStruct.Name);
            }

        }

        static void ChangeClass(DemoClass demoItem)
        {
            demoItem.Name += " - Changed";
        }

        static void ChangeStruct(DemoStruct demoItem)
        {
            demoItem.Name += " - Changed";
        }
    }
}
