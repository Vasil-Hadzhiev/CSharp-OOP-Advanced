namespace _06.StrategyPattern
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var nameSorter = new SortedSet<Person>(new NameComparator());
            var ageSorter = new SortedSet<Person>(new AgeComparator());

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var personInfo = Console.ReadLine().Split();
                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);

                var person = new Person(name, age);
                nameSorter.Add(person);
                ageSorter.Add(person);
            }

            foreach (var person in nameSorter)
            {
                Console.WriteLine(person);
            }

            foreach (var person in ageSorter)
            {
                Console.WriteLine(person);
            }
        }
    }
}