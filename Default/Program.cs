using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person
            {
                FirstName = "Wekoslav",
                LastName = "Stefanovski"
            };

            //string fullName = PersonExtensions.GetFullName(p);
            string fullName = p.GetFullName();
            Console.WriteLine(fullName);

            Book b = new Book
            {
                Name = "A game of thrones", 
                NumberOfPages = 1500
            };

            //b = BookExtensions.RemoveChapter(
            //    BookExtensions.AddPage(
            //    BookExtensions.DoubleBook(
            //    BookExtensions.AddChapter( 
            //    BookExtensions.TornLastPage(b), 25))),40);

            b = b.TornLastPage()
                .AddChapter(25)
                .DoubleBook()
                .AddPage()
                .RemoveChapter(40);

            Console.WriteLine(b.NumberOfPages);



        }
    }
}
