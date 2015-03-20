using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPrinter
{
    public class ListPrinter<T>
    {
        private List<T> input;

        public ListPrinter(List<T> input)
        {
            this.input = input;
        }

        public void PrintListFragment(int startIntex, int endIndex)
        {
            Console.WriteLine("#\tItem");
            Console.WriteLine("-------------------------------------------");
            endIndex = Math.Min(endIndex, input.Count - 1);
            for (int i = startIntex; i <= endIndex; i++)
            {
                Console.WriteLine("{0}\t{1}", i, input[i]);
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Total: {0:####}".PadLeft(50), input.Count);
        }

        public void PrintPage(int pageNumber, int pageSize)
        {
            int startIndex = pageNumber * pageSize;
            int endIndex = (pageNumber + 1) * pageSize - 1;
            PrintListFragment(startIndex, endIndex);
        }

        public void PrintListFragment(int startIntex, int endIndex, Func<T, string> formatter)
        {
            Console.WriteLine("#\tItem");
            Console.WriteLine("-------------------------------------------");
            endIndex = Math.Min(endIndex, input.Count - 1);
            for (int i = startIntex; i <= endIndex; i++)
            {
                Console.WriteLine("{0}\t{1}", i, formatter(input[i]));
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Total: {0:####}".PadLeft(50), input.Count);
        }

        public void PrintPage(int pageNumber, int pageSize, Func<T, string> formatter)
        {
            int startIndex = pageNumber * pageSize;
            int endIndex = (pageNumber + 1) * pageSize - 1;
            PrintListFragment(startIndex, endIndex, formatter);
        }
    }
}
