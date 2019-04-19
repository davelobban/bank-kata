using System;
using System.Collections.Generic;
using Bank06;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GivenAClientMakesADeposit
    {
        /*Started from defining an acceptance test:

Given a client makes a deposit of 1000 on 10-01-2012
And a deposit of 2000 on 13-01-2012
And a withdrawal of 500 on 14-01-2012
When she prints her bank statement
Then she would see
date || credit || debit || balance
14/01/2012 || || 500.00 || 2500.00
13/01/2012 || 2000.00 || || 3000.00
10/01/2012 || 1000.00 || || 1000.00

Do it yourself first and then compare the solutions.*/
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void When1000DepositedToBalance0_ThenBalanceIs1000()
        {
            var subject = WhenAccountOpenedWithBalanceOf1000();
            var actual = subject.GetBalance();
            var expected = 1000;
            Assert.AreEqual(expected, actual);
        }

        private static Account WhenAccountOpenedWithBalanceOf1000()
        {
            var subject = new Account(0);
            subject.Deposit(1000, new DateTime(2012, 1, 10));
            return subject;
        }

        [Test]
        public void When2000DepositedToBalance0_ThenBalanceIs2000()
        {
            var subject = new Account(0);
            WhenDepositMadeOf2000(subject);
            var actual = subject.GetBalance();
            var expected = 2000;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void When2000DepositedToBalance1000_ThenBalanceIs3000()
        {
            var subject = WhenAccountOpenedWithBalanceOf1000();
            WhenDepositMadeOf2000(subject);
            var actual = subject.GetBalance();
            var expected = 3000;
            Assert.AreEqual(expected, actual);
        }

        private static void WhenDepositMadeOf2000(Account subject)
        {
            subject.Deposit(2000, new DateTime(2012, 1, 13));
        }

        [Test]
        public void When2000DepositedToBalance1000And500Withdrawn_ThenBalanceIs2500()
        {
            var subject = SetupAcceptanceTestScenario1();
            var actual = subject.GetBalance();
            var expected = 2500;
            Assert.AreEqual(expected, actual);
        }

        private static Account SetupAcceptanceTestScenario1()
        {
            var subject = WhenAccountOpenedWithBalanceOf1000();
            WhenDepositMadeOf2000(subject);
            subject.Withdraw(500, new DateTime(2012, 1, 14));
            return subject;
        }

        [Test]
        public void When2000DepositedToBalance1000And600Withdrawn_ThenBalanceIs2400()
        {
            var subject = WhenAccountOpenedWithBalanceOf1000();
            WhenDepositMadeOf2000(subject);
            subject.Withdraw(600, new DateTime(2012, 1, 14));
            var actual = subject.GetBalance();
            var expected = 2400;
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void GetStatement_AcceptanceTest1_ThenFirstLineIsHeader()
        {
            var statement = GetStatementForAcceptanceTestScenario1();
            var actual = statement[0];
            var expected = "date || credit || debit || balance";
            Assert.AreEqual(expected, actual);
        }

        private static IList<string> GetStatementForAcceptanceTestScenario1()
        {
            var subject = SetupAcceptanceTestScenario1();
            var statement = subject.GetStatement();
            return statement;
        }

        [Test]
        public void GetStatement_AcceptanceTest1_ThenSecondLineIsTransaction3()
        {
            var statement = GetStatementForAcceptanceTestScenario1();
            var actual = statement[1];
            var expected = "14/01/2012 || || 500.00 || 2500.00";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetStatement_AcceptanceTest1_ThenThirdLineIsTransaction2()
        {
            var statement = GetStatementForAcceptanceTestScenario1();
            var actual = statement[2];
            var expected = "13/01/2012 || 2000.00 || || 3000.00";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetStatement_AcceptanceTest1_ThenFourthLineIsTransaction1()
        {
            var statement = GetStatementForAcceptanceTestScenario1();
            var actual = statement[3];
            var expected = "10/01/2012 || 1000.00 || || 1000.00";
            Assert.AreEqual(expected, actual);
        }
    }
}