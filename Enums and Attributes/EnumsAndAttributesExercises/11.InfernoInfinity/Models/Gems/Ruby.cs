using _11.InfernoInfinity.Enums;

namespace _11.InfernoInfinity.Models.Gems
{
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
