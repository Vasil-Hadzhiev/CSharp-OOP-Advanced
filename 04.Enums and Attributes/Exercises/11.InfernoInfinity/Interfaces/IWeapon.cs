namespace _11.InfernoInfinity.Interfaces
{
    using Enums;

    public interface IWeapon
    {
        string Name { get; }

        int MinDamage { get; }

        int MaxDamage { get; }

        WeaponRarity Rarity { get; }

        IGem[] Gems { get; }

        void AddGem(IGem gem, int socketIndex);

        void RemoveGem(int socketIndex);
    }
}