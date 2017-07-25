using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var elements = new List<Box<int>>();

        for (int i = 0; i < n; i++)
        {
            var box = new Box<int>(int.Parse(Console.ReadLine()));

            elements.Add(box);
        }

        var indexes = Console.ReadLine().
            Split().
            Select(int.Parse).
            ToArray();

        var firstIndex = indexes[0];
        var secondIndex = indexes[1];

        Box<string>.Swap(elements, firstIndex, secondIndex);

        foreach (var item in elements)
        {
            Console.WriteLine(item);
        }
    }
}

