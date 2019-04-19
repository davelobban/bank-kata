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
            var actual = Account.GetBalance();
            var expected = 1000;
            Assert.AreEqual(expected,actual);
        }
    }
}