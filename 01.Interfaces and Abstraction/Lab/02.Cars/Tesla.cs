using System.Text;

public class Tesla : ICar, IElectricCar
{
    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Baterry = battery;
    }

    public string Model { get; }

    public string Color { get; }

    public int Baterry { get; }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{this.Color} {GetType().Name} {this.Model} with {this.Baterry} Batteries");
        sb.AppendLine(this.Start());
        sb.Append(this.Stop());

        return sb.ToString();
    }
}

