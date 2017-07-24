public abstract class Person : IBuyer
{
    private int age;

    public Person(string name, int age)
    {
        this.Name = name;
        this.age = age;
    }

    public string Name { get; }

    public int Food { get; protected set; }

    public abstract void BuyFood();
}

