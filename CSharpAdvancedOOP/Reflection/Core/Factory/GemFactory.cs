using InfernoInfinity.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace InfernoInfinity.Core.Factory
{
    public class GemFactory : IGemFactory
    {
        public IGem CreateGem(string clarity, string kindOfGem)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type type = assembly.GetTypes().First(x => x.Name == kindOfGem);

            IGem gem = (IGem)Activator.CreateInstance(type, new object[] { clarity });

            return gem;
        }
    }
}
