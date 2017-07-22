using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BorderControl
{
    public class StartUp
    {
        public static void Main()
        {
            var inhabitants = new List<IIdentifiable>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                var tokens = input.Split();

                if (tokens.Length == 3)
                {
                    var citizenName = tokens[0];
                    var citizenAge = int.Parse(tokens[1]);
                    var citizenID = tokens[2];

                    var citizen = new Citizen(citizenName, citizenAge, citizenID);
                    inhabitants.Add(citizen);
                }
                else
                {
                    var robotModel = tokens[0];
                    var robotID = tokens[1];

                    var robot = new Robot(robotModel, robotID);
                    inhabitants.Add(robot);
                }
            }

            var fakeID = Console.ReadLine();

            var fakeInhabitants = inhabitants.
                Where(i => i.ID.EndsWith(fakeID)).
                ToList();

            foreach (var inhabitant in fakeInhabitants)
            {
                Console.WriteLine(inhabitant.ID);
            }
        }
    }
}
