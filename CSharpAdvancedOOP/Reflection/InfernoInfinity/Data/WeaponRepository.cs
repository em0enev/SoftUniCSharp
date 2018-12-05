using InfernoInfinity.Contracts;
using InfernoInfinity.Core.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfernoInfinity.Data
{
    public class WeaponRepository : IRepository
    {
        private List<IWeapon> weapons;

        public WeaponRepository()
        {
            this.weapons = new List<IWeapon>();
        }

        public void AddWeapon(IWeapon weapon)
        {
            weapons.Add(weapon);
        }

        public string WeaponsInfo(string weaponName)
        {

            IWeapon wep = weapons.First(x => x.Name == weaponName);

            string result = ($"{wep.Name}: {wep.MinDmg}-{wep.MaxDmg} Damage, +{wep.TotalStrength} Strength, +{wep.TotalAgility} Agility, +{wep.TotalVitality} Vitality");

            return result;
        }

        public IReadOnlyCollection<IWeapon> Weapons
        {
            get { return this.weapons.AsReadOnly(); }
        }
    }
}
