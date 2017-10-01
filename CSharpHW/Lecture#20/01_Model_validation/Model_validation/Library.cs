using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidationLibrary
{
    static class Library
    {
        private static List<Book> _books = new List<Book>();

        /*
        public Library(List <Book>  books)
        {
            _books = books;
        }
        */

        public static void  Add(Book  book)
        {
            _books.Add(book);
        }
         

        public  static List<Book> GetAllBooks()
        {
            return _books;
        }

        public static int CountAllBooks
        {
            get { return _books.Count; }
        }


    }
}
