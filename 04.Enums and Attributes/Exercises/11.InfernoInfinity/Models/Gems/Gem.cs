namespace _11.InfernoInfinity.Models.Gems
{
    using Enums;
    using Interfaces;

    public abstract class Gem : IGem
    {
        protected Gem(GemClarity clarity, int strength, int agility, int vitality)
        {
            this.Clarity = clarity;
            this.Strength = strength + (int)clarity;
            this.Agility = agility + (int)clarity;
            this.Vitality = vitality + (int)clarity;
        }

        public GemClarity Clarity { get; private set; }

        public int Strength { get; private set; }

        public int Agility { get; private set; }

        public int Vitality { get; private set; }
    }
}