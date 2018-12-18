namespace TheTankGame.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using IO.Contracts;
    using TheTankGame.Entities.Parts;
    using TheTankGame.Entities.Parts.Contracts;
    using TheTankGame.Entities.Vehicles.Contracts;
    using TheTankGame.Entities.Vehicles.Factories;
    using TheTankGame.Entities.Vehicles.Factories.Contracts;

    public class Engine : IEngine
    {
        private bool isRunning;
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(
            IReader reader,
            IWriter writer,
            ICommandInterpreter commandInterpreter)
        {
            this.reader = reader;
            this.writer = writer;
            this.commandInterpreter = commandInterpreter;

            this.isRunning = false;
        }

        public void Run()
        {
            while (true)
            {

                var input = Console.ReadLine();

                var parameters = input.Split().Select(s => s).ToList();

                var abc = commandInterpreter.ProcessInput(parameters);
                Console.WriteLine(abc);
                if (input == "Terminate")
                {
                    break;
                }
            }
        }
    }
}