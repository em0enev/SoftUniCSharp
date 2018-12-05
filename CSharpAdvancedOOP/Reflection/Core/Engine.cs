using InfernoInfinity.Contracts;
using InfernoInfinity.Core.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfernoInfinity.Core
{
    public class Engine : IRunnable
    {
        ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] data = input.Split(';');
                string commandName = data[0];
                IExecutable execute = this.commandInterpreter.InterpretCommand(data, commandName);
                execute.Execute();

                //string input = Console.ReadLine();
                //string[] data = input.Split();
                //string commandName = data[0];
                //IExecutable execute = this.commandInterpreter.InterpretCommand(data, commandName);
                //string result = execute.Execute();
                //Console.WriteLine(result);


                input = Console.ReadLine();
            }

            
        }
    }
}
