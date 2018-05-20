namespace _05.CardCompareTo
{
    using Enums;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var firstCardRank = Console.ReadLine();
            var firstCardSuit = Console.ReadLine();

            var parsedfirstCardRank = (Rank)Enum.Parse(typeof(Rank), firstCardRank);
            var parsedfirstCardSuit = (Suit)Enum.Parse(typeof(Suit), firstCardSuit);

            var secondCardRank = Console.ReadLine();
            var secondCardSuit = Console.ReadLine();

            var parsedsecondCardRank = (Rank)Enum.Parse(typeof(Rank), secondCardRank);
            var parsedsecondCardSuit = (Suit)Enum.Parse(typeof(Suit), secondCardSuit);

            var firstCard = new Card(parsedfirstCardRank, parsedfirstCardSuit);
            var secondCard = new Card(parsedsecondCardRank, parsedsecondCardSuit);

            if (firstCard.CompareTo(secondCard) < 0)
            {
                Console.WriteLine(secondCard);
            }
            else
            {
                Console.WriteLine(firstCard);
            }
        }
    }
}