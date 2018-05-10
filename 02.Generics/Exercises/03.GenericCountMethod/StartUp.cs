namespace _03.GenericCountMethod
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                var input = double.Parse(Console.ReadLine());
                box.Data.Add(input);
            }

            var compareElement = double.Parse(Console.ReadLine());
            Console.WriteLine(box.Count(compareElement));
        }
    }
}