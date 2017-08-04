﻿using _04.CardToString.Enums;
using System;

namespace _04.CardToString
{
    public class StartUp
    {
        public static void Main()
        {
            var rank = Console.ReadLine();
            var suit = Console.ReadLine();

            var parsedRank = (Rank)Enum.Parse(typeof(Rank), rank);
            var parsedSuit = (Suit)Enum.Parse(typeof(Suit), suit);

            var card = new Card(parsedRank, parsedSuit);
            Console.WriteLine(card);
        }
    }
}
