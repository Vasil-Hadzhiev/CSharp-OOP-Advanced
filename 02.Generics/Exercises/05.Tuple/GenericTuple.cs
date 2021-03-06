﻿namespace _05.Tuple
{
    public class GenericTuple<T1, T2>
    {
        private T1 item1;
        private T2 item2;

        public GenericTuple(T1 item1, T2 item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public T1 Item1
        {
            get { return this.item1; }
            private set { this.item1 = value; }
        }

        public T2 Item2
        {
            get { return this.item2; }
            private set { this.item2 = value; }
        }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2}";
        }
    }
}