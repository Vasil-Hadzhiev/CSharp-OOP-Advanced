using _07.DeckOfCards.Enums;
using System;

namespace _07.DeckOfCards
{
    public class StartUp
    {
        public static void Main()
        {
            var ranks = Enum.GetValues(typeof(Rank));
            var suits = Enum.GetValues(typeof(Suit));

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    Console.WriteLine($"{rank} of {suit}");
                }
            }
        }
    }
}
