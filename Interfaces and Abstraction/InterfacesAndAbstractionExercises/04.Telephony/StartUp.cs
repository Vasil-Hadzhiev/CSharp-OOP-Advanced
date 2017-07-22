using System;

public class StartUp
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split();

        var urls = Console.ReadLine().Split();

        var smartphone = new Smartphone(numbers, urls);

        Console.WriteLine(smartphone);
    }
}

