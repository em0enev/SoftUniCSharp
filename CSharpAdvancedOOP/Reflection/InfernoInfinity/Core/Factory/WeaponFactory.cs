using InfernoInfinity.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace InfernoInfinity.Core.Factory
{
    public class WeaponFactory : IWeaponFactory
    {
        public IWeapon CreateWeapon(string weaponType, string[] data)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.GetTypes().First(t => t.Name == weaponType);
            IWeapon weapon = (IWeapon)Activator.CreateInstance(type, data);

            return weapon;
        }
    }
}
