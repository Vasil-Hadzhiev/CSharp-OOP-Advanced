namespace _03.GenericCountMethod
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Box<T>
        where T : IComparable<T>
    {
        public Box()
        {
            this.Data = new List<T>();
        }

        public List<T> Data { get; set; }

        public int Count(T element)
        {
            return this.Data.Count(item => item.CompareTo(element) > 0);
        }
    }
}