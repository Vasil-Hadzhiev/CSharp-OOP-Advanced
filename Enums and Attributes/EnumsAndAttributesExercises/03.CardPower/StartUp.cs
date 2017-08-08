﻿using _03.CardPower.Enums;
using System;

namespace _03.CardPower
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