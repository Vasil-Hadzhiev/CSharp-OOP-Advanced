namespace _01.BoxOfT
{
    using System.Collections.Generic;
    using System.Linq;

    public class Box<T>
    {
        private IList<T> boxList;

        public Box()
        {
            this.boxList = new List<T>();
        }

        public int Count => this.boxList.Count;

        public void Add(T element)
        {
            this.boxList.Add(element);
        }

        public T Remove()
        {
            var lastItem = this.boxList.LastOrDefault();
            this.boxList.RemoveAt(this.boxList.Count - 1);

            return lastItem;
        }
    }
}