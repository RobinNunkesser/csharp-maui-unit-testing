using MoneyExample.Core;
using NUnit.Framework;

namespace MoneyExample.Tests
{
    public class BankTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestReduceMoney()
        {
            var bank = new Bank();
            var result = bank.Reduce(Money.Dollar(1), "USD");
            Assert.AreEqual(result, Money.Dollar(1));
        }

        [Test]
        public void TestSimpleAddidtion()
        {
            var five = Money.Dollar(5);
            var ten = five + five;
            var bank = new Bank();
            var result = bank.Reduce(ten, "USD");
            Assert.AreEqual(result, Money.Dollar(10));
        }

        [Test]
        public void TestReduceMoneyDifferentCurrency()
        {
            var bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            var result = bank.Reduce(Money.Franc(2), "USD");
            Assert.AreEqual(result, Money.Dollar(1));
        }

        [Test]
        public void TestIdentityRate()
        {
            Assert.AreEqual(new Bank().Rate("USD", "USD"), 1);
        }
    }
}