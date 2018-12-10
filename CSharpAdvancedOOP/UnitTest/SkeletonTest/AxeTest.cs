using NUnit.Framework;
using System;

namespace SkeletonTest
{
    [TestFixture]
    public class AxeTest
    {
        [Test]
        public void TestIfWeaponLosesDurabilityAgterAtack()
        {
            //Arange
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(10, 10);

            //Act
            axe.Attack(dummy);

            var expectedResult = 9;
            var actualResult = axe.DurabilityPoints;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void AtackingWithBrokenWeapon()
        {
            //Arange
            Axe axe = new Axe(10, 0);
            Dummy dummy = new Dummy(10, 10);

            //Act
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));


        }
    }
}
