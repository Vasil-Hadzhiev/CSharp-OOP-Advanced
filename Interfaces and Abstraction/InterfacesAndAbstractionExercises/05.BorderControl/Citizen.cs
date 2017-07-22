public class Citizen : IIdentifiable
{
    private string name;
    private int age;

    public Citizen(string name, int age, string id)
    {
        this.name = name;
        this.age = age;
        this.ID = id;
    }

    public string ID { get; }   
}

