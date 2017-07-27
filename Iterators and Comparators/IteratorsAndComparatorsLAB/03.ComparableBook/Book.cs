using System;
using System.Collections.Generic;

namespace _03.ComparableBook
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors;
        }

        public string Title { get; set; }

        public int Year { get; set; }

        public IReadOnlyList<string> Authors { get; set; }

        public int CompareTo(Book otherBook)
        {
            if (this.Year == otherBook.Year)
            {
                return this.Title.CompareTo(otherBook.Title);
            }

            return this.Year.CompareTo(otherBook.Year);
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
