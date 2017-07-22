using System;

public class StartUp
{
    public static void Main()
    {
        var driverName = Console.ReadLine();

        var ferrari = new Ferrari(driverName);

        Console.WriteLine(ferrari.ToString());

        var ferrariName = typeof(Ferrari).Name;
        var iCarInterfaceName = typeof(ICar).Name;

        var isCreated = typeof(ICar).IsInterface;
        if (!isCreated)
        {
            throw new Exception("No interface ICar was created");
        }
    }
}

