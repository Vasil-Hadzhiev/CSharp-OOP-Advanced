using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var elements = new List<Box<double>>();

        for (int i = 0; i < n; i++)
        {
            var box = new Box<double>(double.Parse(Console.ReadLine()));

            elements.Add(box);
        }

        var element = double.Parse(Console.ReadLine());

        var result = GetBiggerElementsCount<double>(elements, element);

        Console.WriteLine(result);
    }

    public static int GetBiggerElementsCount<T>(List<Box<double>> elements, T element)
        where T : IComparable<T>
    {
        return elements.Count(b => b.Value.CompareTo(element) > 0);
    }
}

