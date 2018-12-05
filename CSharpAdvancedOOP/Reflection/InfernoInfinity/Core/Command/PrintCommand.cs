using System;
using System.Collections.Generic;
using System.Text;
using InfernoInfinity.Contracts;

namespace InfernoInfinity.Core.Command
{
    class PrintCommand : Command
    {
        public PrintCommand(string[] data, IRepository repository, IWeaponFactory weaponFactory, IGemFactory gemFactory)
            : base(data, repository, weaponFactory, gemFactory)
        {
        }

        public override void Execute()
        {
            Console.WriteLine(Repository.WeaponsInfo(Data[1]));
        }
    }
}
