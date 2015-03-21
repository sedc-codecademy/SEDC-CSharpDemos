using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. da se napravi lista od 500 broevi
            //2. da se naprave lista od kvadratite na broevite
            //3. da se selektiraat samo parnite kvadrati
            //4. da se sortiraat po posledna cifra
            //5. da se ispecatat

            //6. da se izracuna sumata na parnite kvadrati

            Random r = new Random();

            //regular
            List<int> numbers = new List<int>();
            for (int i = 0; i < 500; i++)
            {
                numbers.Add(r.Next(10000));
            }

            List<int> squares = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                squares.Add(numbers[i] * numbers[i]);
            }

            List<int> evenSquares = new List<int>();
            for (int i = 0; i < squares.Count; i++)
            {
                if (squares[i] % 2 == 0)
                    evenSquares.Add(squares[i]);
            }

            for (int i = 0; i < evenSquares.Count; i++)
            {
                evenSquares.Sort(CompareByLast);
            }

            for (int i = 0; i < evenSquares.Count; i++)
            {
                Console.WriteLine(evenSquares[i]);
            }

            long sum = 0;
            for (int i = 0; i < evenSquares.Count; i++)
            {
                sum += evenSquares[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
            /// LINQ

            var numbersLinq = Enumerable.Range(0, 500)
                .Select(_ => r.Next(1000))
                .Select(x => x * x)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x % 10);

            foreach (var number in numbersLinq)
            {
                Console.WriteLine(number);
            }

            var sumLinq = numbersLinq.Sum(x => x % 10);
            Console.WriteLine(sumLinq);

            var two = numbersLinq.All(x => x % 2 == 0);
            Console.WriteLine(two);
            var three = numbersLinq.All(x => x % 3 == 0);
            Console.WriteLine(three);

            two = numbersLinq.Any(x => x % 2 == 0);
            Console.WriteLine(two);
            three = numbersLinq.Any(x => x % 3 == 0);
            Console.WriteLine(three);
            Console.WriteLine("------------");

            var threeCount = numbersLinq.Count(x => x % 3 == 0);
            Console.WriteLine(threeCount);

            var tenThrees = numbersLinq.Where(x => x%3 == 0).Take(10);
            foreach (var tenThree in tenThrees)
            {
                Console.WriteLine(tenThree);
            }
            Console.WriteLine("------------");
            tenThrees = numbersLinq.Where(x => x % 3 == 0)
                .Skip(10)
                .Take(10);

            foreach (var tenThree in tenThrees)
            {
                Console.WriteLine(tenThree);
            }
            Console.WriteLine("------------");

            var grouped = numbersLinq.GroupBy(x => x%100);

            foreach (var group in grouped)
            {
                Console.Write("{0:00}: ", group.Key);
                foreach (var number in group.OrderBy(x=>x).Take(3))
                {
                    Console.Write("{0} - ", number);
                }
                Console.WriteLine();
            }




        }

        private static int CompareByLast(int x, int y)
        {
            var lastx = x % 10;
            var lasty = y % 10;
            return lastx.CompareTo(lasty);
        }
    }
}
