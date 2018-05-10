namespace _05.Tuple
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var name = string.Empty;

            var firstInput = Console.ReadLine().Split();
            name = firstInput[0] + " " + firstInput[1];
            var address = firstInput[2];
            var firstGenericTuple = new GenericTuple<string, string>(name, address);
            Console.WriteLine(firstGenericTuple);

            var secondInput = Console.ReadLine().Split();
            name = secondInput[0];
            var litersOfBeer = int.Parse(secondInput[1]);
            var secondGenericTuple = new GenericTuple<string, int>(name, litersOfBeer);
            Console.WriteLine(secondGenericTuple);

            var thirdInput = Console.ReadLine().Split();
            var item1 = int.Parse(thirdInput[0]);
            var item2 = double.Parse(thirdInput[1]);
            var thirdGenericTuple = new GenericTuple<int, double>(item1, item2);
            Console.WriteLine(thirdGenericTuple);
        }
    }
}