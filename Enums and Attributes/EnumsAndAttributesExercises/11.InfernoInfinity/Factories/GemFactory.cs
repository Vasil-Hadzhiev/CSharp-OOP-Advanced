using _11.InfernoInfinity.Enums;
using _11.InfernoInfinity.Interfaces;
using _11.InfernoInfinity.Models.Gems;
using System;

namespace _11.InfernoInfinity.Factories
{
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
