namespace _11.InfernoInfinity.Models.Gems
{
    using Enums;

    public class Ruby : Gem
    {
        private const int Strength = 7;
        private const int Agility = 2;
        private const int Vitality = 5;

        public Ruby(GemClarity clarity) 
            : base(clarity, Strength, Agility, Vitality)
        {
        }
    }
}