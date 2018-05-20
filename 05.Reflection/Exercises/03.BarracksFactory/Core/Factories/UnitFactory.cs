namespace _03.BarracksFactory.Core.Factories
{
    using System;
    using Contracts;
    using System.Reflection;
    using System.Linq;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            var typeUnit = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == unitType);
            return (IUnit)Activator.CreateInstance(typeUnit);
        }
    }
}