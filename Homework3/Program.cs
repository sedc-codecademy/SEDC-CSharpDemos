using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            IForable test = new MyForable();

            var sum = Calculator.SumForable(test);
            Test(15, sum, "Wrong sum");

            IForable test2 = new MyOtherForable();
            sum = Calculator.SumForable(test2);
            Test(110, sum, "Wrong Sum");

            ISummable testSummable = new MySummable();
            Test(0, testSummable.Sum, "Wrong Initial Sum");
            Calculator.SumSummable(testSummable);
            Test(15, testSummable.Sum, "Wrong Output Sum");
        }

        static void Test(string expected, string actual, string message)
        {
            if (expected != actual)
            {
                Console.WriteLine("FAIL {0} (expected = {1}, actual = {2})", message, expected, actual);
            }
            else
            {
                Console.WriteLine("Pass");
            }
        }

        static void Test(int expected, int actual, string message)
        {
            if (expected != actual)
            {
                Console.WriteLine("FAIL {0} (expected = {1}, actual = {2})", message, expected, actual);
            }
            else
            {
                Console.WriteLine("Pass");
            }
        }
    }

    public interface IForable
    {
        int GetCount();
        int GetElementByIndex(int index);
    }

    public interface ISummable : IForable
    {
        int Sum { get; set; }
    }

    public static class Calculator
    {
        public static int SumList(List<int> input)
        {
            var sum = 0;
            for (int i = 0; i < input.Count; i++)
            {
                sum += input[i];
            }
            return sum;
        }

        public static int SumForable(IForable input)
        {
            var sum = 0;
            for (int i = 0; i < input.GetCount(); i++)
            {
                sum += input.GetElementByIndex(i);
            }
            return sum;
        }

        public static void SumSummable(ISummable input)
        {
            var sum = SumForable(input);
            input.Sum = sum;
        }

    }

    public class MyForable : IForable
    {
        private List<int> innerList = new List<int>{1,2,3,4,5};

        public int GetCount()
        {
            return innerList.Count;
        }

        public int GetElementByIndex(int index)
        {
            return innerList[index];
        }

    }

    public class MyOtherForable : IForable
    {
        public int GetCount()
        {
            return 10;
        }

        public int GetElementByIndex(int index)
        {
            return (index + 1)*2;
            /* 0 = 2
             * 1 = 4
             * 2 = 6
             * 3 = 8 ...
             */
        }
    }

    public class MySummable : MyForable, ISummable
    {
        public int Sum { get; set; }
    }
}
