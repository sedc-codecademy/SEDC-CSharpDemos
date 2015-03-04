using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMarriedName
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("Petrov", Person.FemaleToMale("Petrova"),"petrova error");
            Test("Stefanovski", Person.FemaleToMale("Stefanovska"), "stefanovska error");
            Test("Balaban", Person.FemaleToMale("Balaban"), "balaban error");

            Test("Petrova", Person.MaleToFemale("Petrov"), "petrov error");
            Test("Stefanovska", Person.MaleToFemale("Stefanovski"), "stefanovski error");
            Test("Balaban", Person.MaleToFemale("Balaban"), "balaban error");
            //petrova - petrov
            //stefanovska - stefanovski
            //balaban - balanan

            Person pero = new Person
            {
                FirstName = "Pero",
                LastName = "Petrovski",
                IsMarried = false,
                Sex = Sex.Male
            };

            Person wife = new Person
            {
                FirstName = "Persa",
                LastName = "Jankovska",
                IsMarried = false,
                Sex = Sex.Female
            };

            wife.Marry(pero, LastNameChangeType.Append);

            Test("Jankovska-Petrovska",wife.LastName, "Last name change error");
            Test(true, wife.IsMarried,"wife is not married");
            Test(true, pero.IsMarried, "pero is not married");

            pero.IsMarried = false;

            Person husband = new Person
            {
                FirstName = "Nikola",
                LastName = "Jankov",
                IsMarried = false,
                Sex = Sex.Male
            };

            Person.IsSameSexAllowed = true;
            pero.Marry(husband, LastNameChangeType.Append);
            Test("Petrovski-Jankov", pero.LastName, "Last name change error");
            Test(true, husband.IsMarried, "husband is not married");
            Test(true, pero.IsMarried, "pero is not married");

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

        static void Test(bool expected, bool actual, string message)
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
}
