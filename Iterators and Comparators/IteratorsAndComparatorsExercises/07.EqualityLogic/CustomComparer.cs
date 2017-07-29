using System.Collections.Generic;

namespace _07.EqualityLogic
{
    public class CustomComparer : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            var result = firstPerson.Name.
                CompareTo(secondPerson.Name);

            if (result == 0)
            {
                result = firstPerson.Age.
                    CompareTo(secondPerson.Age);
            }

            return result;
        }
    }
}
