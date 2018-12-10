using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkeletonTest
{
    public class DummyTests
    {
         

         
        [Test]
        public void DummyLosesHealthIfAtack()
        {
            Dummy dummy = new Dummy(10, 10);
            dummy.TakeAttack(5);

            var expectedResult = 5;
            var actualResult = dummy.Health;

            Assert.AreEqual(expectedResult, actualResult, "dummy doesnt lose health if atacked");
        }

        [Test]
        public void DeadDummyThrowExceptionIfAtack()
        {
            Dummy dummy = new Dummy(0, 10);

            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(20), "Dead dummy doesnt throw invalidOperationException ");
        }

        [Test]
        public void DeadDummycanGiveXp()
        {
            Dummy dummy = new Dummy(0, 10);

            var actualResult = dummy.GiveExperience();
            var excpectedResult = 10;

            Assert.AreEqual(excpectedResult, actualResult);
        }

        [Test]
        public void AliveDummyCantGiveXp()
        {
            Dummy dummy = new Dummy(10, 10);

            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}
