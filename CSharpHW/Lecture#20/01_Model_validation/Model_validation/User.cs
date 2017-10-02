using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ValidationLibrary
{

    public class User
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [Range(1, 100)]
        public int Age { get; set; }
        
        public List<Book> BooksFromLibrary { get; set; }
        
        public  void GetBookFromLibrary(string  title)
        {
            Book book = Library.GetBook(title);

            if (book == null)
            {
                Library.NotFoundBook(title);
            }

            else if ( Library.IsCanBookOnHands(book))
            {
                BooksFromLibrary.Add(book);
                Library.SuccessTranscation(book, this);
            }

            else
            {
                Library.DeniedTranscation(book);
            }

        }


    }
}
