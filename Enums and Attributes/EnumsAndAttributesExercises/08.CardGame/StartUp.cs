using _08.CardGame.Enums;
using _08.CardGame.Models;
using System;
using System.Linq;

namespace _08.CardGame
{
    public class StartUp
    {
        public static void Main()
        {
            var deck = new CardDeck();
            deck.FillDeck();

            var playerOneName = Console.ReadLine();
            var playerTwoName = Console.ReadLine();

            var playerOne = new Player(playerOneName);
            var playerTwo = new Player(playerTwoName);

            while (playerOne.Hand.Count != 5)
            {
                var cardInfo = Console.ReadLine().Split();
                AddCardsToHand(cardInfo, playerOne, deck);
            }

            while (playerTwo.Hand.Count != 5)
            {
                var cardInfo = Console.ReadLine().Split();
                AddCardsToHand(cardInfo, playerTwo, deck);
            }

            if (playerOne.GetHighestPowerCard()
                .CompareTo(playerTwo.GetHighestPowerCard()) > 0)
            {
                Console.WriteLine($"{playerOneName} wins with {playerOne.GetHighestPowerCard()}");
            }
            else
            {
                Console.WriteLine($"{playerTwoName} wins with {playerTwo.GetHighestPowerCard()}");
            }
        }

        private static void AddCardsToHand(string[] cardInfo, Player playerOne, CardDeck deck)
        {
            try
            {
                var rank = (Rank)Enum.Parse(typeof(Rank), cardInfo[0]);
                var suit = (Suit)Enum.Parse(typeof(Suit), cardInfo[2]);

                var card = new Card(rank, suit);

                if (deck.Contains(card))
                {
                    deck.RemoveCard(card);
                    playerOne.DrawCard(card);
                }
                else
                {
                    Console.WriteLine("Card is not in the deck.");
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("No such card exists.");
            }
        }
    }
}
