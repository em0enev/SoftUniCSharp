using System;
using System.Collections.Generic;
using System.Text;
using InfernoInfinity.Contracts;

namespace InfernoInfinity.Core.Command
{
    public class CreateCommand : Command
    {
        public CreateCommand(string[] data, IRepository repository, IWeaponFactory weaponFactory, IGemFactory gemFactory) 
            : base(data, repository, weaponFactory,gemFactory)
        {
        }

        public override void Execute()
        {
            string[] weapInfo = Data[1].Split();
            string weapName = Data[2];
            IWeapon weapon = WeaponFactory.CreateWeapon(weapInfo[1], new string[] { weapName, weapInfo[0] });
            Repository.AddWeapon(weapon);
        }
    }
}
