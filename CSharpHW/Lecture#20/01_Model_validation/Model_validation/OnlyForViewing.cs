using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace ValidationLibrary
{
    public class OnlyForViewing :  ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                ErrorMessage = BookType.NonFiction + " literature are  only for  vievwng";    
                List<Book> books =  value as List<Book>;
                foreach (Book book in books)
                {
                    if (book.Type == BookType.NonFiction)
                        return false;
                }

                return true;
            }

            return false;
        }
    }
}
