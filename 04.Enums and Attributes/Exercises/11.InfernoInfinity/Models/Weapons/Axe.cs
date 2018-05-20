namespace _11.InfernoInfinity.Models.Weapons
{
    using Enums;

    public class Axe : Weapon
    {
        private const int MinDamage = 5;
        private const int MaxDamage = 10;
        private const int SocketsNumber = 4;

        public Axe(string name, WeaponRarity rarity) 
            : base(name, rarity, MinDamage, MaxDamage, SocketsNumber)
        {
        }
    }
}