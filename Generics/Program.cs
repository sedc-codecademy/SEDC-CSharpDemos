using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student {FirstName = "Petar", LastName = "Petrovski"});
            students.Add(null);
            students.Add(new Student { FirstName = "Igor", LastName = "Igorov" });
            students.Add(null);
            students.Add(new Student { FirstName = "Risto", LastName = "Ristov" });

            Console.WriteLine(students.Count);

            var studentSelector = new Selector<Student>();

            var filteredStudents = studentSelector.SelectNotNulls(students);

            Console.WriteLine(filteredStudents.Count);

            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Vehicle { Model = "Toyota", Mileage = 50000});
            vehicles.Add(null);
            vehicles.Add(new Vehicle { Model = "Volkswagen", Mileage = 80000 });
            vehicles.Add(null);
            vehicles.Add(new Vehicle { Model = "Yugo", Mileage = 1000000 });

            Console.WriteLine(vehicles.Count);

            var vehicleSelector = new Selector<Vehicle>();

            var filteredVehicles = vehicleSelector.SelectNotNulls(vehicles);

            Console.WriteLine(filteredVehicles.Count);


            List<int?> ints = new List<int?>{3, 5, null, 6, 7, null };
            var intSelector = new Selector<int?>();

            ints = intSelector.SelectNotNulls(ints);
            Console.WriteLine(ints.Count);
        }
    }

}
