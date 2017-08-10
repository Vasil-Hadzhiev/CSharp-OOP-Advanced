using System;

public class StartUp
{
    public static void Main()
    {
        var spy = new Spy();
        var result = spy.AnalyzeAccessModifiers("Hacker");
        Console.WriteLine(result);
    }
}

