using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.EqualityLogic
{
    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var sorted = new SortedSet<Person>(new CustomComparer());
            var hash = new HashSet<Person>(new CustomEqualityComparer());

            for (int i = 0; i < n; i++)
            {
                var personInfo = Console.ReadLine().Split();
                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);

                var person = new Person(name, age);
                sorted.Add(person);
                hash.Add(person);
            }

            Console.WriteLine(sorted.Count());
            Console.WriteLine(hash.Count());
        }
    }
}
