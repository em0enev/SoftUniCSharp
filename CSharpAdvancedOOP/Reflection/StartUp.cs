using InfernoInfinity.Contracts;
using InfernoInfinity.Core;
using InfernoInfinity.Core.Command;
using InfernoInfinity.Core.Factory;
using InfernoInfinity.Data;
using InfernoInfinity.Enums;
using InfernoInfinity.Models.Gems;
using InfernoInfinity.Models.Weapons;
using System;

namespace InfernoInfinity
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IRepository repository = new WeaponRepository();
            IWeaponFactory weaponFactory = new WeaponFactory();
            IGemFactory gemFactory = new GemFactory();


            ICommandInterpreter commandInterpreter = new CommandInterpreter(repository, weaponFactory, gemFactory);
            Engine engine = new Engine(commandInterpreter);
            engine.Run();

        }
    }
}
