using InfernoInfinity.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfernoInfinity.Core.Command
{
    public abstract class Command : IExecutable
    {
        private string[] data;
        private IRepository repository;
        private IWeaponFactory weaponFactory;
        private IGemFactory gemFactory;

        protected Command(string[] data, IRepository repository, IWeaponFactory weaponFactory, IGemFactory gemFactory)
        {
            this.Data = data;
            this.Repository = repository;
            this.weaponFactory = weaponFactory;
            this.gemFactory = gemFactory;
        }

        protected string[] Data { get => data; private set => data = value; }

        protected IRepository Repository { get => repository; private set => repository = value; }

        protected IWeaponFactory WeaponFactory { get => weaponFactory; private set => weaponFactory = value; }

        protected IGemFactory GemFactory { get => gemFactory; private set => gemFactory = value; }

        public abstract void Execute();

    }
}
