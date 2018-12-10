using NUnit.Framework;
using Problem._01;
using System;

namespace Promblem01.Tests
{
    public class BankAccountTest
    {
        [Test]
        public void ValidateDepositAmount()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount();

            //Act
            bankAccount.Deposit(20);
            bankAccount.Deposit(20);

            var expectedResult = 40;
            var actualResult = bankAccount.Amount;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
