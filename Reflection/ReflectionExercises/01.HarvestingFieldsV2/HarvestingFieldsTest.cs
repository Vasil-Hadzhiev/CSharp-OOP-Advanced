using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _01.HarvestingFieldsV2
{
    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            var classType = typeof(HarvestingFields);

            var harvestingFields = classType.GetFields(
                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            var accessModifierFilter = new Dictionary<string, Func<FieldInfo[]>>()
            {
                {"private", () => harvestingFields.Where(f => f.IsPrivate).ToArray() },
                {"protected", () => harvestingFields.Where(f => f.IsFamily).ToArray() },
                {"public", () => harvestingFields.Where(f => f.IsPublic).ToArray() },
                {"all", () => harvestingFields }
            };

            while (true)
            {
                var accMod = Console.ReadLine();

                if (accMod == "HARVEST")
                {
                    break;
                }

                accessModifierFilter[accMod]().
                    Select(f => $"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}").
                    ToList().
                    ForEach(r => Console.WriteLine(r.Replace("family", "protected")));
            }
        }
    }
}
