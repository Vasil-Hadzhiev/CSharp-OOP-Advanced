using System;
using System.Reflection;

public class StartUp
{
    public static void Main()
    {
        Type personInterface = typeof(Citizen).GetInterface("IPerson");
        PropertyInfo[] properties = personInterface.GetProperties();
        Console.WriteLine(properties.Length);
        var name = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        IPerson person = new Citizen(name, age);
        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);
    }
}

