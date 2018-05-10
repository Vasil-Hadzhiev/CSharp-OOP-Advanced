namespace _01.GenericBox
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());

                var box = new Box<int>(input);
                Console.WriteLine(box);
            }

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var box = new Box<string>(input);
                Console.WriteLine(box);
            }
        }
    }
}