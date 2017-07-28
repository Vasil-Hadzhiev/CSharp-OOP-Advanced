using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ComparingObjects
{
    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                var tokens = input.
                    Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries).
                    ToArray();

                var name = tokens[0];
                var age = int.Parse(tokens[1]);
                var town = tokens[2];

                var person = new Person(name, age, town);
                people.Add(person);
            }

            var id = int.Parse(Console.ReadLine());

            var ourPerson = people[id - 1];

            var totalPeople = people.Count();

            var equalPeople = 0;
            var nonEqualPeople = 0;
            
            foreach (var person in people)
            {
                if (person.CompareTo(ourPerson) == 0)
                {
                    equalPeople++;
                }
                else
                {
                    nonEqualPeople++;
                }
            }

            if (equalPeople != 1)
            {
                Console.WriteLine($"{equalPeople} {nonEqualPeople} {totalPeople}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
