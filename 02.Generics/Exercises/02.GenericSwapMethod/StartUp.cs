namespace _02.GenericSwapMethod
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var integerBox = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                integerBox.Data.Add(input);
            }

            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            integerBox.Swap(indexes[0], indexes[1]);
            Console.WriteLine(integerBox.ToString());

            var stringBox = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                stringBox.Data.Add(input);
            }

            indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            stringBox.Swap(indexes[0], indexes[1]);
            Console.WriteLine(stringBox.ToString());
        }
    }
}