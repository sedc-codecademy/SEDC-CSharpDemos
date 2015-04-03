using System;
using System.Linq;
using Tiered.BusinessLayer;
using Tiered.DataAccess;

namespace Tiered.Presentation
{
    class Program
    {
        private static PersonManager manager;

        static void Main(string[] args)
        {
            var repository = new FilePersonRepository();
            manager = new PersonManager(repository);
            RunMenu();
        }

        #region Menu Management
        private static void RunMenu()
        {
            WriteMenu();
            var command = GetCommand(Console.ReadLine());
            RunCommand(command);

        }

        private static void WriteMenu()
        {
            Console.Clear();
            Console.WriteLine("=============================================");
            Console.WriteLine("1. Find Person by ID");
            Console.WriteLine("2. List All Persons");
            Console.WriteLine("3. List Persons by Last Name");
            Console.WriteLine("4. Add Person");
            Console.WriteLine("5. Exit system");
            Console.WriteLine("=============================================");
            Console.Write("Enter choice: ");
        }

        private static void RunCommand(Command command)
        {
            switch (command)
            {
                case Command.FindPerson:
                    FindPerson();
                    break;
                case Command.ListPersons:
                    ListPersons();
                    break;
                case Command.ListPersonsLastName:
                    ListPersonsLastName();
                    break;
                case Command.AddPerson:
                    AddPerson();
                    break;
                case Command.ExitCommand:
                    break;
                default:
                    RunMenu();
                    break;
            }
        }

        private static Command GetCommand(string commandLine)
        {
            int result;
            if (int.TryParse(commandLine, out result))
            {
                Command command = (Command)result;
                return command;
            }
            return Command.InvalidCommand;
        }
        #endregion 

        #region Person Command Management
        private static void AddPerson()
        {
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            var person = manager.AddPerson(firstName, lastName);
            Console.WriteLine("Entered person {0} with ID {1}", person.FullName, person.ID);
            Console.ReadLine();
            RunMenu();
        }

        private static void ListPersonsLastName()
        {
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            var persons = manager.GetPersonsByLastName(lastName);
            Console.WriteLine("=== Persons ====");
            foreach (var person in persons)
            {
                Console.WriteLine(person.FullName);
            }
            Console.WriteLine("=== Total: {0}", persons.Count());
            Console.ReadLine(); 
            RunMenu();
        }

        private static void ListPersons()
        {
            var persons = manager.GetAllPersons();
            Console.WriteLine("=== Persons ====");
            foreach (var person in persons)
            {
                Console.WriteLine(person.FullName);
            }
            Console.WriteLine("=== Total: {0}", persons.Count());
            Console.ReadLine();
            RunMenu();
        }

        private static void FindPerson()
        {
            Console.Write("Enter ID: ");
            var line = Console.ReadLine();
            int personId;
            if (int.TryParse(line, out personId))
            {
                var person = manager.GetPerson(personId);
                if (person == null)
                {
                    Console.WriteLine("ID {0} not found", personId);
                }
                else
                {
                    Console.WriteLine(person.FullName);
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadLine();
            RunMenu();

        }
        #endregion 

    }
}
