using System;
using System.IO;
using System.Collections.Generic;

namespace Serialization
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
                new Book { Id = 10,  Title = "Inferno",  Type =  BookType.Advanture}

            };

            MyBinarySerializer.Serialize(Books);
            MyXmlSerializer.Serialize(Books);
            MyJsonSerializer.Serialize(Books);
            
            
            Console.ReadLine();
        }

       

        

    }
}
