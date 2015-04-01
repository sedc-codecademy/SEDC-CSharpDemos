using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var numCars = 15;
            var numCollisions = 10;

            List<Vehicle> vehicles = new List<Vehicle>();
            for (int i = 0; i < numCars; i++)
            {
                var index = i + 1;
                vehicles.Add(new Vehicle {Name = "Vehicle "+index});
            }

            var anyDamage = vehicles.Any(v => v.HasDamage);
            Console.WriteLine(anyDamage);

            var random = new Random();
            for (int i = 0; i < numCollisions; i++)
            {
                var firstIndex = random.Next(numCars);
                var secondIndex = random.Next(numCars);

                var firstVehicle = vehicles[firstIndex];
                var secondVehicle = vehicles[secondIndex];

                firstVehicle.Hit(secondVehicle);
            }

            anyDamage = vehicles.Any(v => v.HasDamage);
            Console.WriteLine(anyDamage);
        }
    }
}
