using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var people = new List<Person>();

        var numberOfPeople = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPeople; i++)
        {
            var tokens = Console.ReadLine().Split();

            var name = tokens[0];
            var age = int.Parse(tokens[1]);

            if (tokens.Length == 4)
            {
                var id = tokens[2];
                var birthday = tokens[3];

                var citizen = new Citizen(name, age, id, birthday);
                people.Add(citizen);
            }
            else
            {
                var group = tokens[2];

                var rebel = new Rebel(name, age, group);
                people.Add(rebel);
            }
        }

        while (true)
        {
            var input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }

            var buyer = people.FirstOrDefault(p => p.Name == input);

            if (buyer != null)
            {
                buyer.BuyFood();
            }
        }

        var totalFood = people.Sum(p => p.Food);

        Console.WriteLine(totalFood);
    }
}

