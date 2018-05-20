namespace _08.CardGame.Models
{
    using Enums;
    using System;

    public class Card : IComparable<Card>
    {
        private Rank rank;
        private Suit suit;

        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public int Power => this.GetPower();

        private int GetPower()
        {
            return (int)this.rank + (int)this.suit;
        }

        public int CompareTo(Card otherCard)
        {
            return this.Power.CompareTo(otherCard.Power);
        }

        public override int GetHashCode()
        {
            return (int)this.rank + (int)this.suit;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Card;

            if (this.suit != other.suit)
            {
                return false;
            }

            return this.rank == other.rank;
        }

        public override string ToString()
        {
            return $"{this.rank} of {this.suit}.";
        }
    }
}