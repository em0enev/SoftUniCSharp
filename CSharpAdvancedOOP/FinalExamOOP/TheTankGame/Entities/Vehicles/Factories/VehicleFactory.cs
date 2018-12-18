using System;
using System.Linq;
using System.Reflection;
using TheTankGame.Entities.Miscellaneous;
using TheTankGame.Entities.Vehicles.Contracts;
using TheTankGame.Entities.Vehicles.Factories.Contracts;

namespace TheTankGame.Entities.Vehicles.Factories
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string vehicleType, string model, double weight, decimal price, int attack, int defense, int hitPoints)
        {
            Assembly assembly = Assembly.GetCallingAssembly();

            Type type = assembly.GetTypes().First(t => t.Name == vehicleType);

            IVehicle vehicle = (IVehicle)Activator.CreateInstance(type, new object[] { model,weight,price,attack
            ,defense,hitPoints, new VehicleAssembler()});

            return vehicle;
        }
    }
}
