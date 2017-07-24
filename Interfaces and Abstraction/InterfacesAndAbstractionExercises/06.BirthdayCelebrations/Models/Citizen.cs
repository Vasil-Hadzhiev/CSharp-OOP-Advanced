public class Citizen : IIdentifiable, IBirthable
{
    private int age;

    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.age = age;
        this.ID = id;
        this.Birthdate = birthdate;
    }

    public string ID { get; }

    public string Name { get; }

    public string Birthdate { get; }
}

