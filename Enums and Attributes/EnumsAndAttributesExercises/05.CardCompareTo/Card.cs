using _05.CardCompareTo.Enums;
using System;

namespace _05.CardCompareTo
{
    public class Card : IComparable<Card>
    {
        private Rank rank;
        private Suit suit;

        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public int CompareTo(Card otherCard)
        {
            return this.GetPower().CompareTo(otherCard.GetPower());
        }

        public int GetPower()
        {
            return (int)this.rank + (int)this.suit;
        }

        public override string ToString()
        {
            return $"Card name: {rank} of {suit}; Card power: {GetPower()}";
        }
    }
}
