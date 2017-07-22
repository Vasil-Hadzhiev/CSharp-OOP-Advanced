public class Ferrari : ICar
{
    public Ferrari(string driver)
    {
        this.Driver = driver;
        this.Model = "488-Spider";
    }

    public string Driver { get; }

    public string Model { get; }

    public string GasPedal()
    {
        return $"Zadu6avam sA!";
    }

    public string PushBreaks()
    {
        return $"Brakes!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.PushBreaks()}/{this.GasPedal()}/{this.Driver}";
    }
}

