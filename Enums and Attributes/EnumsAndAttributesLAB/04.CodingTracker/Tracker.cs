using System;
using System.Linq;
using System.Reflection;

namespace _04.CodingTracker
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            var startUp = typeof(StartUp);
            var methods = startUp.GetMethods
                (BindingFlags.Instance
                | BindingFlags.Public
                | BindingFlags.Static);

            foreach (var methodInfo in methods)
            {
                if (methodInfo.CustomAttributes.
                    Any(a => a.AttributeType == typeof(SoftUniAttribute)))
                {
                    var attributes = methodInfo.GetCustomAttributes(false);

                    foreach (SoftUniAttribute attribute in attributes)
                    {
                        Console.WriteLine($"{methodInfo.Name} is written by {attribute.Name}");
                    }
                }
            }
        }
    }
}
