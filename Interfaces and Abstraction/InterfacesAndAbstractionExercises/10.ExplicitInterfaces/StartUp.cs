using System;

public class StartUp
{
    public static void Main()
    {
        while (true)
        {
            var input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }

            var tokens = input.Split();

            var name = tokens[0];
            var country = tokens[1];
            var age = int.Parse(tokens[2]);

            var citizen = new Citizen(name, country, age);
            IPerson person = citizen;
            IResident resident = citizen;

            Console.WriteLine(person.GetName());
            Console.WriteLine(resident.GetName());
        }
    }
}

