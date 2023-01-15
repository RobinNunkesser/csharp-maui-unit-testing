using MoneyExample.Core;
using NUnit.Framework;

namespace MoneyExample.Tests
{
    public class MoneyTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCurrency()
        {
            Assert.AreEqual(Money.Dollar(1).Currency, "USD");
            Assert.AreEqual(Money.Franc(1).Currency, "CHF");
        }

        [Test]
        public void TestDollarMultiplication()
        {
            var five = Money.Dollar(5);
            Assert.AreEqual(five * 2, Money.Dollar(10));
        }

        [Test]
        public void TestEquality()
        {
            Assert.AreEqual(Money.Dollar(5), Money.Dollar(5));
            Assert.AreNotEqual(Money.Dollar(5), Money.Dollar(6));
            Assert.AreNotEqual(Money.Dollar(5), Money.Franc(5));
        }
    }
}