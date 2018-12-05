using System;
using System.Collections.Generic;
using System.Text;

namespace InfernoInfinity.Contracts
{
    public interface IWeapon
    {
        string Name { get; }
        int MinDmg { get; }
        int MaxDmg { get; }
        int TotalAgility { get; }
        int TotalStrength { get; }
        int TotalVitality { get; }
        IReadOnlyCollection<IGem> Sockets { get; }

        void AddGem(int slot, IGem gem);
        void RemoveGem(int slot);

    }
}
