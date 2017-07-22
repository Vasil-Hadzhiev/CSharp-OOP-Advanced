public class Citizen : IPerson, IIdentifiable, IBirthable
{
    public Citizen(string name, int age, string ID, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.ID = ID;
        this.Birthdate = birthdate;
    }

    public string Name { get; }

    public int Age { get; }

    public string ID { get; }

    public string Birthdate { get; }
}

