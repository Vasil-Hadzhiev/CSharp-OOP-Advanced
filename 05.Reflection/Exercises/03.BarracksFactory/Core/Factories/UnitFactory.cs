using System;
using _03.BarracksFactory.Contracts;
using _03.BarracksFactory.Models.Units;
using System.Reflection;
using System.Linq;

namespace _03.BarracksFactory.Core.Factories
{ 
    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            var typeUnit = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == unitType);
            return (IUnit)Activator.CreateInstance(typeUnit);
        }
    }
}
