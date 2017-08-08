using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CardGame.Models
{
    public class Player
    {
        private string name;

        public Player(string name)
        {
            this.name = name;
            this.Hand = new List<Card>();
        }

        public IList<Card> Hand { get; set; }

        public void DrawCard(Card card)
        {
            this.Hand.Add(card);
        }

        public Card GetHighestPowerCard()
        {
            return this.Hand.
                OrderByDescending(x => x.Power).
                First();
        }
    }
}
