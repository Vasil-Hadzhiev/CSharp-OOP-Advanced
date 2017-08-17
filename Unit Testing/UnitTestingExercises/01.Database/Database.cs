using System;
using System.Linq;

namespace _01.Database
{
    public class Database
    {
        private const int Capacity = 16;

        private int[] elements;
        private int count;

        public Database()
        {
            this.elements = new int[Capacity];
        }

        public Database(params int[] numbers)
            :this()
        {
            if (numbers != null)
            {
                foreach (var item in numbers)
                {
                    this.Add(item);
                }
            }
        }

        public void Add(int element)
        {
            if (this.count == this.elements.Length)
            {
                throw new InvalidOperationException("Can't add more elements to array");
            }

            this.elements[this.count] = element;
            this.count++;
        }

        public void Remove()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("Array is empty");
            }

            this.count--;
        }

        public int[] Fetch()
        {
            return this.elements.Take(this.count).ToArray();
        }
    }
}
