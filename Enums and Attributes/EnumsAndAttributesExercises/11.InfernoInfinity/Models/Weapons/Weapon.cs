using _11.InfernoInfinity.Interfaces;
using _11.InfernoInfinity.Enums;
using System.Linq;

namespace _11.InfernoInfinity.Models.Weapons
{
    public abstract class Weapon : IWeapon
    {
        protected Weapon(string name, WeaponRarity rarity, int minDamage, int maxDamage, int socketsNumber)
        {
            this.Name = name;
            this.Rarity = rarity;
            this.MinDamage = minDamage * (int)rarity;
            this.MaxDamage = maxDamage * (int)rarity;
            this.Gems = new IGem[socketsNumber];
        }

        public string Name { get; }

        public int MinDamage { get; private set; }

        public int MaxDamage { get; private set; }

        public WeaponRarity Rarity { get; private set; }

        public IGem[] Gems { get; private set; }

        public void AddGem(IGem gem, int socketIndex)
        {
            if (socketIndex < 0 || socketIndex >= this.Gems.Length)
            {
                return;
            }

            this.Gems[socketIndex] = gem;
        }

        public void RemoveGem(int socketIndex)
        {
            if (socketIndex < 0 || socketIndex >= this.Gems.Length)
            {
                return;
            }

            this.Gems[socketIndex] = null;
        }

        public override string ToString()
        {
            var strength = this.Gems.Where(g => g != null).Select(g => g.Strength).Sum();
            var agility = this.Gems.Where(g => g != null).Select(g => g.Agility).Sum();
            var vitality = this.Gems.Where(g => g != null).Select(g => g.Vitality).Sum();

            var minDamage = this.MinDamage + (strength * 2) + agility;
            var maxDamage = this.MaxDamage + (strength * 3) + (agility * 4);

            return $"{this.Name}: {minDamage}-{maxDamage} Damage, +{strength} Strength, +{agility} Agility, +{vitality} Vitality";
        }
    }
}
