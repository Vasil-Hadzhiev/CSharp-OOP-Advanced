namespace _11.InfernoInfinity.Models.Weapons
{
    using Enums;

    public class Knife : Weapon
    {
        private const int MinDamage = 3;
        private const int MaxDamage = 4;
        private const int SocketsNumber = 2;

        public Knife(string name, WeaponRarity rarity) 
            : base(name, rarity, MinDamage, MaxDamage, SocketsNumber)
        {
        }
    }
}