using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ValidationLibrary
{
    public class Book
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Required]     
        public int Id { get; set; }
        
        [Required]
        public BookType Type { get; set; }
    }
}
