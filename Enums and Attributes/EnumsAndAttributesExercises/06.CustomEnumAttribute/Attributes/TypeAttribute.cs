using System;

namespace _06.CustomEnumAttribute.Attributes
{
    [AttributeUsage(AttributeTargets.Enum)]
    public class TypeAttribute : Attribute
    {
        private string category;

        public TypeAttribute(string type, string category, string description)
        {
            this.Type = type;
            this.category = category;
            this.Description = description;
        }

        public string Type { get; set; }

        public string Description { get; set; }
    }
}
