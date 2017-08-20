using _01.LoggerProblem.Interfaces;
using System;
using System.Linq;
using System.Reflection;

namespace _01.LoggerProblem.Entities.Layout.Factory
{
    public class LayoutFactory
    {
        public ILayout CreateLayout(string layoutName)
        {
            var layoutType = Assembly.
                GetExecutingAssembly().
                GetTypes().
                FirstOrDefault(t => t.Name == layoutName);

            var layoutInstance = (ILayout)Activator.CreateInstance(layoutType);

            return layoutInstance;
        }
    }
}
