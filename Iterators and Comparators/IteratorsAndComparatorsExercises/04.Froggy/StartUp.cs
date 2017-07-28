﻿using System;
using System.Linq;

namespace _04.Froggy
{
    public class Program
    {
        public static void Main()
        {
            var elements = Console.ReadLine().
                Split(new char[] { ' ', ',' },
                StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();

            var lake = new Lake(elements);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
