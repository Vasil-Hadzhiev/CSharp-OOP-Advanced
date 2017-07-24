using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        var inhabitants = new List<IBirthable>();

        while (true)
        {
            var input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }

            var tokens = input.Split();

            var command = tokens[0];

            switch (command)
            {
                case "Citizen":
                    var citizenName = tokens[1];
                    var citizenAge = int.Parse(tokens[2]);
                    var citizenID = tokens[3];
                    var citizenBirthday = tokens[4];

                    var citizen = new Citizen(citizenName, citizenAge, citizenID, citizenBirthday);
                    inhabitants.Add(citizen);
                    break;
                case "Pet":
                    var petName = tokens[1];
                    var petBirthday = tokens[2];

                    var pet = new Pet(petName, petBirthday);
                    inhabitants.Add(pet);
                    break;
                case "Robot":
                    var robotModel = tokens[1];
                    var robotID = tokens[2];

                    var robot = new Robot(robotModel, robotID);
                    break;
            }
        }

        var birthdayYear = Console.ReadLine();

        var sortedInhabitants = inhabitants.
            Where(i => i.Birthdate.EndsWith(birthdayYear)).
            ToList();

        foreach (var inhabitant in sortedInhabitants)
        {
            Console.WriteLine(inhabitant.Birthdate);
        }
    }
}

