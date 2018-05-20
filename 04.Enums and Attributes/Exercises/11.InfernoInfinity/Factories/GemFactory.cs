namespace _11.InfernoInfinity.Factories
{
    using Enums;
    using Interfaces;
    using Models.Gems;
    using System;

    public class GemFactory
    {
        public IGem CreateGem(string gemType, string gemClarity)
        {
            var clarity = (GemClarity)Enum.Parse(typeof(GemClarity), gemClarity);

            switch (gemType)
            {
                case "Ruby":
                    return new Ruby(clarity);
                case "Emerald":
                    return new Emerald(clarity);
                case "Amethyst":
                    return new Amethyst(clarity);
                default:
                    return null;
            }
        }
    }
}