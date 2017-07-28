using System;

namespace _05.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town)
        {
            this.name = name;
            this.age = age;
            this.town = town;
        }

        public int CompareTo(Person otherPerson)
        {
            if (this.name != otherPerson.name)
            {
                return this.name.CompareTo(otherPerson.name);
            }

            if (this.age != otherPerson.age)
            {
                return this.age.CompareTo(otherPerson.age);
            }

            return this.town.CompareTo(otherPerson.town);
        }
    }
}
