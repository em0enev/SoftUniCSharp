using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfernoInfinity.Contracts;

namespace InfernoInfinity.Core.Command
{
    public class RemoveCommand : Command
    {
        public RemoveCommand(string[] data, IRepository repository, IWeaponFactory weaponFactory, IGemFactory gemFactory)
            : base(data, repository, weaponFactory, gemFactory)
        {
        }

        public override void Execute()
        {
            string weaponName = Data[1];
            int slot = int.Parse(Data[2]);
            IWeapon weapon = this.Repository.Weapons.FirstOrDefault(x => x.Name == weaponName);

            weapon.RemoveGem(slot);

        }
    }
}
