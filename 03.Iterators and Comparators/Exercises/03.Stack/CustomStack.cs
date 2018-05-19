namespace _03.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> elements;

        public CustomStack()
        {
            this.elements = new List<T>();
        }

        public void Push(T item)
        {
            this.elements.Add(item);
        }

        public T Pop()
        {
            if (this.elements.Any())
            {
                var element = this.elements.Last();
                this.elements.Remove(element);
                return element;
            }

            throw new InvalidOperationException("No elements");
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.elements.Count - 1; i >= 0; i--)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}