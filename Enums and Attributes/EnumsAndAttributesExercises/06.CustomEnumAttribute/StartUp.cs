using _06.CustomEnumAttribute.Attributes;
using _06.CustomEnumAttribute.Enums;
using System;

namespace _06.CustomEnumAttribute
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            Type type = null;

            switch (input)
            {
                case "Rank":
                    type = typeof(Rank);
                    break;
                case "Suit":
                    type = typeof(Suit);
                    break;
            }

            var attributes = type.GetCustomAttributes(false);

            foreach (TypeAttribute attribute in attributes)
            {
                Console.WriteLine($"Type = {attribute.Type}, Description = {attribute.Description}");
            }
        }
    }
}
