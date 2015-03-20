using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListPrinter
{
    partial class Person
    {
        #region static data

        private static Random random = new Random();
        private static List<string> firstNames = new List<string>
        {
            "Aleksandar",
            "Atanas",
            "Angel",
            "Andon",
            "Blagoja",
            "Bogdan",
            "Branko",
            "Boris",
            "Vladimir",
            "Venko",
            "Viktor",
            "Vojdan",
            "Gorast",
            "Gavril",
            "Goce",
            "Gligor",
            "Dobromir",
            "Dejan",
            "Dragan",
            "Emanuel",
            "Emil",
            "Evgenij",
            "Zoran",
            "Zlatko",
            "Zdravko",
            "Ilija",
            "Ivan",
            "Igor",
            "Isak",
            "Jakov",
            "Jovan",
            "Jordan",
            "Josip",
            "Kiril",
            "Kliment",
            "Krste",
            "Kuzman",
            "Lazar",
            "Luka",
            "Leonid",
            "Marjan",
            "Marko",
            "Matej",
            "Mitre",
            "Naum",
            "Nestor",
            "Nikola",
            "Oliver",
            "Ognen",
            "Petar",
            "Predrag",
            "Pavle",
            "Petko",
            "Riste",
            "Robert",
            "Rade",
            "Stefan",
            "Simon",
            "Slave",
            "Stojan",
            "Trajan",
            "Todor",
            "Trifun",
            "Filip",
            "Haralampie",
            "Cvetan",
            "Wekoslav"
        };


        private static List<string> lastNames = new List<string>
        {
            "Atanasovski", 
            "Angelov",
            "Andonoski",
            "Blagojevski",
            "Bogdanov",
            "Borisovski",
            "Vladimirov",
            "Venkovski",
            "Viktorov",
            "Vojdanovski",
            "Gavrilovski",
            "Gocevski",
            "Gligorov",
            "Dobromirski",
            "Draganov",
            "Emanuelovski",
            "Emilov",
            "Zlatanov",
            "Zdravkovslo",
            "Iliev",
            "Ivanov",
            "Isakovski",
            "Jakovlev",
            "Jovanov",
            "Jordanovski",
            "Josipov",
            "Kirilovski",
            "Kliment",
            "Krstevski",
            "Kuzman",
            "Lazarov",
            "Leonidov",
            "Marjanovski",
            "Markov",
            "Matejev",
            "Mitrevski",
            "Naumoski",
            "Nestorov",
            "Nikolov",
            "Ognenov",
            "Petrov",
            "Pavlevski",
            "Petkov",
            "Ristevski",
            "Radeski",
            "Stefanovski",
            "Slavevski",
            "Stojanov",
            "Trajanovski",
            "Todorov",
            "Trifunovski",
            "Filipov",
            "Haralampievski",
            "Cvetanov",

        };
        #endregion static data

        public static Person GeneratePerson()
        {
            string firstName = firstNames[random.Next(firstNames.Count)];
            string lastName = lastNames[random.Next(lastNames.Count)];
            string idNumber = GenerateIdNumber(3, 7);

            return new Person
            {
                FirstName = firstName,
                LastName = lastName,
                IdNumber = idNumber
            };
        }

        private static string GenerateIdNumber(int alpha, int numeric)
        {
            StringBuilder sb= new StringBuilder();
            for (int i = 0; i < alpha; i++)
            {
                sb.Append((char) ('A' + random.Next(26)));
            }
            for (int i = 0; i < numeric; i++)
            {
                sb.Append((char)('0' + random.Next(10)));
            }
            return sb.ToString();
        }
    }


}

