public class Rebel : Person
{
    private string group;

    public Rebel(string name, int age, string group) 
        : base(name, age)
    {
        this.group = group;
    }

    public override void BuyFood()
    {
        this.Food += 5;
    }
}

