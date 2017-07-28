using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ListyIterator
{
    public class ListyIterator<T>
    {
        private IList<T> elements;
        private int currentIndex;

        public ListyIterator(IList<T> elements)
        {
            this.currentIndex = 0;
            this.elements = elements;
        }

        public bool Move()
        {
            if (this.currentIndex < this.elements.Count - 1)
            {
                this.currentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.currentIndex == this.elements.Count - 1)
            {
                return false;
            }

            return true;
        }

        public void Print()
        {
            if (this.elements.Any())
            {
                Console.WriteLine(this.elements[this.currentIndex]);
            }
            else
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
        }
    }
}

