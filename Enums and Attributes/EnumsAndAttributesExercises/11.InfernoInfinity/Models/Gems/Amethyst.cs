using _11.InfernoInfinity.Enums;

namespace _11.InfernoInfinity.Models.Gems
{
    public class Amethyst : Gem
    {
        private const int Strength = 2;
        private const int Agility = 8;
        private const int Vitality = 4;

        public Amethyst(GemClarity clarity) 
            : base(clarity, Strength, Agility, Vitality)
        {
        }
    }
}
