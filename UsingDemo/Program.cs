using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"C:\test.log"))
            {
                for (int i = 0; i < 20; i++)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
    }
}
