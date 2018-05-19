namespace _07.EqualityLogic
{
    using System.Collections.Generic;

    public class CustomEqualityComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person firstPerson, Person secondPerson)
        {
            var result = firstPerson.Name.
                Equals(secondPerson.Name);

            if (result)
            {
                result = firstPerson.Age.
                    Equals(secondPerson.Age);
            }

            return result;
        }

        public int GetHashCode(Person obj)
        {
            var result = obj.Name.GetHashCode() + obj.Age.GetHashCode();
            return result;
        }
    }
}