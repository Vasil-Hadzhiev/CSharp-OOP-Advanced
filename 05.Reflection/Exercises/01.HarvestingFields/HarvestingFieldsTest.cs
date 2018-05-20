namespace _01.HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            var classType = typeof(HarvestingFields);
            var harvestingFields = classType.GetFields(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            FieldInfo[] harvestedFields = null;

            while (true)
            {
                var accessModifier = Console.ReadLine();

                if (accessModifier == "HARVEST")
                {
                    break;
                }

                switch (accessModifier)
                {
                    case "private":
                        harvestedFields = harvestingFields.
                            Where(f => f.IsPrivate).
                            ToArray();
                        break;
                    case "protected":
                        harvestedFields = harvestingFields.
                            Where(f => f.IsFamily).
                            ToArray();
                        break;
                    case "public":
                        harvestedFields = harvestingFields.
                            Where(f => f.IsPublic).
                            ToArray();
                        break;
                    case "all":
                        harvestedFields = harvestingFields;
                        break;
                }

                var result = harvestedFields.
                    Select(f => $"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}");

                Console.WriteLine(string.Join(Environment.NewLine, result).Replace("family", "protected"));
            }
        }
    }
}