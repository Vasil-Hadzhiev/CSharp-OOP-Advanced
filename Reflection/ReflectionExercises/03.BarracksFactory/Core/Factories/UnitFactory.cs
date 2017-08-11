using System;
using _03.BarracksFactory.Contracts;
using _03.BarracksFactory.Models.Units;

namespace _03.BarracksFactory.Core.Factories
{ 
    public class UnitFactory : IUnitFactory
    {
        private const string UnitNamespace = "_03.BarracksFactory.Models.Units.";

        public IUnit CreateUnit(string unitType)
        {
            var typeUnit = Type.GetType(unitType);
            var unitInstance = (IUnit)Activator.CreateInstance(typeUnit);
            return unitInstance;
        }
    }
}
