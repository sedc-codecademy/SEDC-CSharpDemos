using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default
{
    public static class PersonExtensions
    {
        public static string GetFullName(this Person person)
        {
            return string.Format("{0} {1}", person.FirstName, person.LastName);
        }

    }

    public static class BookExtensions
    {
        public static Book TornLastPage(this Book book)
        {
            Book result = new Book
            {
                Name = book.Name,
                NumberOfPages = book.NumberOfPages - 1
            };
            return result;
        }

        public static Book AddChapter(this Book book, int pages)
        {
            Book result = new Book
            {
                Name = book.Name,
                NumberOfPages = book.NumberOfPages + pages
            };
            return result;
        }

        public static Book RemoveChapter(this Book book, int pages)
        {
            Book result = new Book
            {
                Name = book.Name,
                NumberOfPages = book.NumberOfPages - pages
            };
            return result;
        }

        public static Book AddPage(this Book book)
        {
            Book result = new Book
            {
                Name = book.Name,
                NumberOfPages = book.NumberOfPages + 1
            };
            return result;
        }

        public static Book DoubleBook(this Book book)
        {
            Book result = new Book
            {
                Name = book.Name,
                NumberOfPages = book.NumberOfPages *2
            };
            return result;
        }

    }
}
