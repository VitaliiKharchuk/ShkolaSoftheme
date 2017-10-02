using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ValidationLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> Books = new List<Book>()
            {
                new GeneralBook { Id = 1, Title = "War  and  peace", Type = BookType.Drama , Description = "recommended"},
                new GeneralBook { Id = 2, Title = "Eragon", Type = BookType.Fiction ,  Description = "recommended"},
                new GeneralBook { Id = 3, Title = "Harry Potter", Type = BookType.Fantasy,  Description = "recommended" },
                new GeneralBook { Id = 4, Title = "15- year  old  captain", Type = BookType.Advanture , Description = "recommended"},
                new GeneralBook { Id = 5, Title = "Robinzon Cruzo", Type = BookType.Advanture ,  Description = "recommended"},
                new GeneralBook { Id = 6, Title = "Hamlet", Type = BookType.Drama , Description = "recommended"},
                new ForbiddenBook { Id = 7, Title = "C#  tutorial"},
                new ForbiddenBook { Id = 8, Title = "Angular  tutorial" },
                new ForbiddenBook { Id = 9, Title = "Theory of string" },
                new ForbiddenBook { Id = 10, Title= "Volcanous"}
            };

            foreach (Book book in Books)
            {
                ValidateBook(book);
            }
            Console.WriteLine("----------------------------------------------");
            
            List<User> Users = new List<User>()
            {
                new User{ Id = 1, Age = 25, Name = "Dani",  BooksFromLibrary =  new List<Book>()} ,
                new User{ Id = 2, Age = 23, Name = "Le", BooksFromLibrary =  new List<Book>() },
                new User{ Id = 3, Age = 23, Name = "Mark", BooksFromLibrary =  new List<Book>() }  ,
                new User{ Id = 4, Age = 23, Name = "Victoria", BooksFromLibrary =  new List<Book>()} ,
                new User{ Id = 5, Age = 23, Name = "Tamila", BooksFromLibrary =  new List<Book>() },
                new User{ Id = 6, Age = 23, Name = "Junior", BooksFromLibrary =  new List<Book>() },
                new User{ Id = 7, Age = 23, Name = "Vlad", BooksFromLibrary =  new List<Book>() },

            };
            
            foreach (var user in Users)
            {
                ValidateUser(user);
            }

            Console.WriteLine("----------------------------------------------");

            List<User> Subscribers = Library.GetAllUser();

            Subscribers[0].GetBookFromLibrary("Robinzon Cruzo");
            Subscribers[0].GetBookFromLibrary("Volcanous");

            Subscribers[1].GetBookFromLibrary("Theory of string");
            Subscribers[2].GetBookFromLibrary("C#  tutorial");
            Subscribers[3].GetBookFromLibrary("War  and  peace");
            Subscribers[4].GetBookFromLibrary("Harry Potter");
            Subscribers[5].GetBookFromLibrary("Volcan");

            Console.ReadLine();
        }

        private static void ValidateBook(Book book)
        {
            if (book != null)
            {
                var results = new List<ValidationResult>();
                var context = new ValidationContext(book);

                if (!Validator.TryValidateObject(book, context, results, true))
                {
                    foreach (var error in results)
                    {
                        Console.WriteLine("Book {0} " + error.ErrorMessage, book.Title);
                    }
                }

                else
                {
                    Console.WriteLine("Book {0} passed  validation", book.Title);
                    Library.AddBook(book);
                }
            }
        }
 
        private static void ValidateUser(User user)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(user);

            if (!Validator.TryValidateObject(user, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine("User {0} :" + error.ErrorMessage, user.Name);
                }
            }

            else
            {
                Console.WriteLine("User {0} passed  validation", user.Name);
                Library.AddUser(user);
            }
        }
        
    }
}
