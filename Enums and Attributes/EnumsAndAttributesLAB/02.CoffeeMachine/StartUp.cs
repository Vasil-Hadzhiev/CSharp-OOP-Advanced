using System;

namespace _02.CoffeeMachine
{
    public class StartUp
    {
        public static void Main()
        {
            var machine = new CoffeeMachine();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                var inputArgs = input.Split();

                if (inputArgs.Length == 1)
                {
                    machine.InsertCoin(inputArgs[0]);
                }
                else
                {
                    machine.BuyCoffee(inputArgs[0], inputArgs[1]);
                }
            }

            foreach (var coffeeType in machine.CoffeesSold)
            {
                Console.WriteLine(coffeeType);
            }
        }
    }
}
