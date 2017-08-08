using _11.InfernoInfinity.Factories;
using _11.InfernoInfinity.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace _11.InfernoInfinity.Controllers
{
    public class WeaponManager
    {
        private IList<IWeapon> weapons;
        private WeaponFactory weaponFactory;

        public WeaponManager()
        {
            this.weapons = new List<IWeapon>();
            this.weaponFactory = new WeaponFactory();
        }

        public void CreateWeapon(string weaponType, string weaponName, string weaponRarirty)
        {
            var weapon = this.weaponFactory.CreateWeapon(weaponType, weaponName, weaponRarirty);

            this.weapons.Add(weapon);
        }

        public void AddGemToWeapon(string weaponName, int socketIndex, IGem gem)
        {
            var weapon = this.weapons.
                FirstOrDefault(w => w.Name == weaponName);

            weapon.AddGem(gem, socketIndex);
        }

        public void RemoveGemFromWeapon(string weaponName, int socketIndex)
        {
            var weapon = this.weapons.
                FirstOrDefault(w => w.Name == weaponName);

            weapon.RemoveGem(socketIndex);
        }

        public string Print(string weaponName)
        {
            var weapon = this.weapons.
                FirstOrDefault(w => w.Name == weaponName);

            return weapon.ToString();
        }
     }
}
