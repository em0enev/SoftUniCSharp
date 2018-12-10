using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkeletonTest
{
    [TestFixture]
    public class HeroTest
    {
        [Test]
        public void TestHeroGainXp()
        {
            var fakeWeapon = new Mock<IWeapon>();
            Mock<ITarget> fakeTarget = new Mock<ITarget>();

            // set AtackPoints using Mocking
            fakeWeapon.Setup(x => x.AttackPoints).Returns(10);
            fakeWeapon.Setup(x => x.DurabilityPoints).Returns(15);

            fakeTarget.Setup(x => x.Health).Returns(0);
            fakeTarget.Setup(x => x.GiveExperience()).Returns(10);
            fakeTarget.Setup(x => x.IsDead()).Returns(true);


            Hero hero = new Hero(fakeWeapon.Object, "Gosho");
            hero.Attack(fakeTarget.Object);

            var actualResult = hero.Experience;
            var expectedResult = 10;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
