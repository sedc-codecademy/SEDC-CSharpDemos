using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            Console.WriteLine(p.PrintPerson());

            p.FirstName = "Wekoslav";
            p.LastName = "Stefanovski";
            Console.WriteLine(p.PrintPerson());

            var personType = typeof(Person);

            var properties = personType.GetProperties(
                BindingFlags.Public |
                BindingFlags.NonPublic | 
                BindingFlags.Instance | 
                BindingFlags.Static);

            foreach (var propertyInfo in properties)
            {
                Console.WriteLine(propertyInfo.Name);
                Console.WriteLine(propertyInfo.PropertyType.Name);
            }

            Console.WriteLine("===================================");

            var methods = personType.GetMethods(
                BindingFlags.Public |
                BindingFlags.NonPublic |
                BindingFlags.Instance |
                BindingFlags.Static
                );

            foreach (var methodInfo in methods)
            {
                Console.WriteLine(methodInfo.Name);

                var parameters = methodInfo.GetParameters();
                foreach (var parameterInfo in parameters)
                {
                    Console.WriteLine("   {0} {1}", parameterInfo.Name, parameterInfo.ParameterType.Name);
                }
            }
            Console.WriteLine("===================================");

            //while (true)
            //{
            //    var propName = Console.ReadLine();

            //    var fnameProperty = personType.GetProperty(propName);
            //    var result = fnameProperty.GetValue(p);
            //    Console.WriteLine(result);
            //    var value = Console.ReadLine();
            //    fnameProperty.SetValue(p, value);

            //    Console.WriteLine(p.PrintPerson());

            //}

            var fnamePropertySetter = personType.GetProperty("FirstName").GetSetMethod();
            fnamePropertySetter.Invoke(p, new object[] { "Weko" });

            var printer = personType.GetMethod("PrintPerson");
            var result = printer.Invoke(p, new object[0]);
            Console.WriteLine(result.ToString());

        }
    }
}
