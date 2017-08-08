using _11.InfernoInfinity.Enums;

namespace _11.InfernoInfinity.Interfaces
{
    public interface IGem
    {
        GemClarity Clarity { get; }

        int Strength { get; }

        int Agility { get; }

        int Vitality { get; }
    }
}
