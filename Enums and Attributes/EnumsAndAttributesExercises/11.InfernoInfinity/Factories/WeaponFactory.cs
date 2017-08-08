using _11.InfernoInfinity.Enums;
using _11.InfernoInfinity.Interfaces;
using _11.InfernoInfinity.Models.Weapons;
using System;

namespace _11.InfernoInfinity.Factories
{
    public class WeaponFactory
    {
        public IWeapon CreateWeapon(string weaponType, string weaponName, string weaponRarity)
        {
            var rarity = (WeaponRarity)Enum.Parse(typeof(WeaponRarity), weaponRarity);

            switch (weaponType)
            {
                case "Axe":
                    return new Axe(weaponName, rarity);
                case "Sword":
                    return new Sword(weaponName, rarity);
                case "Knife":
                    return new Knife(weaponName, rarity);
                default:
                    return null;
            }
        }
    }
}
