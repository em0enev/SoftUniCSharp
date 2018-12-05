using System;
using System.Collections.Generic;
using System.Text;
using InfernoInfinity.Contracts;
using System.Linq;

namespace InfernoInfinity.Core.Command
{
    public class AddCommand : Command
    {
        public AddCommand(string[] data, IRepository repository, IWeaponFactory weaponFactory, IGemFactory gemFactory)
            : base(data, repository, weaponFactory, gemFactory)
        {
        }

        public override void Execute()
        {
            string weaponName = Data[1];
            int weaponSlot = int.Parse(Data[2]);
            string[] socketInfo = Data[3].Split();
            string clarity = socketInfo[0];
            string socketType = socketInfo[1];

            IWeapon weapon = Repository.Weapons.FirstOrDefault(x => x.Name == weaponName);

            IGem gem = GemFactory.CreateGem(clarity, socketType);
            weapon.AddGem(weaponSlot, gem);

        }
    }
}
