namespace _11.InfernoInfinity.Factories
{
    using Enums;
    using Interfaces;
    using Models.Weapons;
    using System;

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