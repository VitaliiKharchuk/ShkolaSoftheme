using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidationLibrary
{
    static class Library
    {
        private static List<Book> _books = new List<Book>();
        private static List<User> _users = new List<User>();

        public static void AddBook(Book book)
        {
            _books.Add(book);
        }

        public static void AddUser(User user)
        {
            _users.Add(user);
        }

        public static List<Book> GetAllBooks()
        {
            return _books;
        }

        public static List<User> GetAllUser()
        {
            return _users;
        }

        public static int CountAllBooks
        {
            get { return _books.Count; }
        }

        public static Book GetBook(string title)
        {
            return _books.FirstOrDefault(s => s.Title == title);
        }

        public static bool IsCanBookOnHands(Book book)
        {
            var type = book.GetType().GetCustomAttributes(false).FirstOrDefault();
            return type == null;
        }

        public static void SuccessTranscation(Book book, User user)
        {
            Console.WriteLine("User {0}  took  book {1}  from  the   library", user.Name, book.Title);
        }

        public static void DeniedTranscation(Book book)
        {
            Console.WriteLine("book {0} is  only  for  viewing", book.Title);
        }

        public static void NotFoundBook(string tittle)
        {
            Console.WriteLine("book {0} is  not  found", tittle);
        }
    }
}
