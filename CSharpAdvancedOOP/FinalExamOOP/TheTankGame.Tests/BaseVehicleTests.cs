namespace TheTankGame.Tests
{
    using NUnit.Framework;
    using TheTankGame.Entities.Miscellaneous;
    using TheTankGame.Entities.Parts;
    using TheTankGame.Entities.Parts.Contracts;
    using TheTankGame.Entities.Vehicles;
    using TheTankGame.Entities.Vehicles.Contracts;

    [TestFixture]
    public class BaseVehicleTests
    {
        [Test]
        public void TestTotalStats()
        {
            IVehicle vehicle = new Revenger("model", 5, 5, 5, 5, 5, new VehicleAssembler());

            IPart arsenalPart = new ArsenalPart("arsenal", 5, 5, 5);
            vehicle.AddArsenalPart(arsenalPart);

            IPart endurancePart = new EndurancePart("endurance", 6, 6, 6);
            vehicle.AddEndurancePart(endurancePart);

            IPart shelPart = new ShellPart("shell", 4, 4, 4);
            vehicle.AddShellPart(shelPart);

            string actualResult = vehicle.ToString();
            string expectedResult = "Revenger - model\r\nTotal Weight: 20.000\r\nTotal Price: 20.000\r\nAttack: 10\r\nDefense: 9\r\nHitPoints: 11\r\nParts: arsenal, endurance, shell";

            Assert.That(actualResult, Is.EqualTo(expectedResult));

        }
    }
}