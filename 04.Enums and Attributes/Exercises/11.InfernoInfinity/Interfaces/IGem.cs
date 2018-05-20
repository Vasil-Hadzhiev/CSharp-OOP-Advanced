namespace _11.InfernoInfinity.Interfaces
{
    using Enums;

    public interface IGem
    {
        GemClarity Clarity { get; }

        int Strength { get; }

        int Agility { get; }

        int Vitality { get; }
    }
}