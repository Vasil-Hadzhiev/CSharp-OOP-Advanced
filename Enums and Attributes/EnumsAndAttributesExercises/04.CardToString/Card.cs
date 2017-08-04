using _04.CardToString.Enums;

namespace _04.CardToString
{
    public class Card
    {
        private Rank rank;
        private Suit suit;

        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
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
