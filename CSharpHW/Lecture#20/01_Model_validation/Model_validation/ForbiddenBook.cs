
namespace ValidationLibrary
{
    [OnlyForViewing]
    public class ForbiddenBook : Book
    {
        public ForbiddenBook()
        {
            Type = BookType.NonFiction;
        }

    }
}
