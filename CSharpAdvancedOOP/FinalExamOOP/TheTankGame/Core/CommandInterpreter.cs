namespace TheTankGame.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private readonly IManager tankManager;

        public CommandInterpreter(IManager tankManager)
        {
            this.tankManager = tankManager;
        }

        public string ProcessInput(IList<string> inputParameters)
        {
            string command = inputParameters[0];

            inputParameters.RemoveAt(0);

            string result = string.Empty;

            Assembly assembly = Assembly.GetCallingAssembly();

            Type type = this.tankManager.GetType(); //assembly.GetTypes().First(t => t.Name == "TankManager");

            var method = type
                            .GetMethods((BindingFlags)62)
                            .FirstOrDefault(m => m.Name.ToString().Contains(command));

            result = (string)method.Invoke(this.tankManager, new object[] { inputParameters });

            return result;
        }
    }
}