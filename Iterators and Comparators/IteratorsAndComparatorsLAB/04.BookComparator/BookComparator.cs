using System.Collections.Generic;

namespace _04.BookComparator
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            if (x.Title != y.Title)
            {
                return x.Title.CompareTo(y.Title);
            }

            if (x.Year != y.Year)
            {
                return y.Year.CompareTo(x.Year);
            }

            return 0;
        }
    }
}
