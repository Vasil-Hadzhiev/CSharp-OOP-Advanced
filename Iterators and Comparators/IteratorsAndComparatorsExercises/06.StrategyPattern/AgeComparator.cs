using System.Collections.Generic;

namespace _06.StrategyPattern
{
    public class AgeComparator : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            var result = firstPerson.Age.
                CompareTo(secondPerson.Age);

            if (firstPerson.Age != secondPerson.Age)
            {
                return result;
            }

            return 0;
        }
    }
}
