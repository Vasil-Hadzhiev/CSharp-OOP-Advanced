using _08.CardGame.Enums;
using System;
using System.Collections.Generic;
using System.Collections;

namespace _08.CardGame.Models
{
    public class CardDeck : IEnumerable<Card>
    {
        public CardDeck()
        {
            this.Deck = new List<Card>();
        }

        public IList<Card> Deck { get; set; }

        public void FillDeck()
        {
            var ranks = Enum.GetValues(typeof(Rank));
            var suits = Enum.GetValues(typeof(Suit));

            foreach (Suit suit in suits)
            {
                foreach (Rank rank in ranks)
                {
                    var card = new Card(rank, suit);
                    this.Deck.Add(card);
                }
            }
        }

        public void RemoveCard(Card card)
        {
            this.Deck.Remove(card);
        }

        public IEnumerator<Card> GetEnumerator()
        {
            return this.Deck.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
