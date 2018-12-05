using System;
using System.Collections.Generic;
using System.Text;

namespace InfernoInfinity.Contracts
{
    public interface IRepository
    {
        void AddWeapon(IWeapon weapon);
        string WeaponsInfo(string weaponName);
        IReadOnlyCollection<IWeapon> Weapons { get; }
    }
}
