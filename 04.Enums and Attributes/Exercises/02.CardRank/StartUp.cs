﻿namespace _02.CardRank
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var cards = Enum.GetValues(typeof(Cards));

            var input = Console.ReadLine();

            Console.WriteLine(input + ":");

            foreach (var card in cards)
            {
                Console.WriteLine($"Ordinal value: {(int)card}; Name value: {card}");
            }
        }
    }
}