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
                new Book { Id = 1, Title = "War  and  peace", Type = BookType.Drama },
                new Book { Id = 2, Title = "Eragon", Type = BookType.Fiction },
                new Book { Id = 3, Title = "Harry Potter", Type = BookType.Fantasy },
                new Book { Id = 4, Title = "15- year  old  captain", Type = BookType.Advanture },
                new Book { Id = 5, Title = "Robinzon Cruzo", Type = BookType.Advanture },
                new Book { Id = 6, Title = "Hamlet", Type = BookType.Drama },
                new Book { Id = 7, Title = "C#  tutorial", Type = BookType.NonFiction },
                new Book { Id = 8, Title = "Angular  tutorial", Type = BookType.NonFiction },
                new Book { Id = 9, Title = "Theory of string", Type = BookType.NonFiction },

            };

            foreach (var book in Books)
            {
                ValidateBook(book);
            }



            Console.WriteLine();

            List<Book> booksFromLibrary = Library.GetAllBooks();
            
            List<User> Users = new List<User>()
            {
                new User{ Id = 1, Age = 25, Name = "Dani",  BooksFromLibrary =  new List<Book>(){ booksFromLibrary[0] }  } ,
                new User{ Id = 2, Age = 23, Name = "Leo", BooksFromLibrary =  new List<Book>(){ booksFromLibrary[0], booksFromLibrary[1], booksFromLibrary[7] }  } ,
                new User{ Id = 3, Age = 23, Name = "Mark", BooksFromLibrary =  new List<Book>(){ booksFromLibrary[0], booksFromLibrary[1], booksFromLibrary[3] }  } ,
                new User{ Id = 4, Age = 23, Name = "Victoria", BooksFromLibrary =  new List<Book>(){ booksFromLibrary[0], booksFromLibrary[1] }  } ,
                new User{ Id = 5, Age = 23, Name = "Tamila", BooksFromLibrary =  new List<Book>(){ booksFromLibrary[0], booksFromLibrary[1] }  }
            };



            foreach (var  user in  Users)
            {
                ValidateUser(user);
            }
          
            
            
            Console.ReadLine();
        }

        private static void ValidateBook(Book book)
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
                Library.Add(book);
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
            }
        }


    }
}
