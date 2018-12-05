using InfernoInfinity.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace InfernoInfinity.Core.Command
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private IRepository repository;
        private IWeaponFactory weaponFactory;
        private IGemFactory gemFactory;

        public CommandInterpreter(IRepository repository, IWeaponFactory weaponFactory, IGemFactory gemFactory)
        {
            this.repository = repository;
            this.weaponFactory = weaponFactory;
            this.gemFactory = gemFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {

            Assembly assembly = Assembly.GetExecutingAssembly();

            Type type = assembly.GetTypes().FirstOrDefault(t => t.Name == commandName + "Command");

            IExecutable executable = (IExecutable)Activator.CreateInstance(type, new object[] { data, this.repository, this.weaponFactory, this.gemFactory });

            return executable;
        }
    }
}
