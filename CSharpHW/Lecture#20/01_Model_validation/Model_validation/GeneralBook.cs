using System.ComponentModel.DataAnnotations;

namespace ValidationLibrary
{
    class GeneralBook : Book
    {
        [Required]
        public string Description{get;set;}

    }
}
