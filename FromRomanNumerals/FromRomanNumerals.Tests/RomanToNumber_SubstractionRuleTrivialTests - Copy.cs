using NUnit.Framework;

namespace FromRomanNumerals.Tests
{
    public class SubstractionRuleTrivialTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void _1_is_1()
        {
            var numbers = new[] { 1 };

            var signedNumbers = RomanToNumberConverter.ApplySubstractionRule(numbers);

            Assert.That(signedNumbers, Is.EquivalentTo(new[] { 1 }));
        }

        [Test]
        public void _5_is_5()
        {
            var numbers = new[] { 5 };

            var signedNumbers = RomanToNumberConverter.ApplySubstractionRule(numbers);

            Assert.That(signedNumbers, Is.EquivalentTo(new[] { 5 }));
        }

        [Test]
        public void _10_is_10()
        {
            var numbers = new[] { 10 };

            var signedNumbers = RomanToNumberConverter.ApplySubstractionRule(numbers);

            Assert.That(signedNumbers, Is.EquivalentTo(new[] { 10 }));
        }


        [Test]
        public void _50_is_50()
        {
            var numbers = new[] { 50 };

            var signedNumbers = RomanToNumberConverter.ApplySubstractionRule(numbers);

            Assert.That(signedNumbers, Is.EquivalentTo(new[] { 50 }));
        }


        [Test]
        public void _100_is_100()
        {
            var numbers = new[] { 100 };

            var signedNumbers = RomanToNumberConverter.ApplySubstractionRule(numbers);

            Assert.That(signedNumbers, Is.EquivalentTo(new[] { 100 }));
        }


        [Test]
        public void _500_is_500()
        {
            var numbers = new[] { 500 };

            var signedNumbers = RomanToNumberConverter.ApplySubstractionRule(numbers);

            Assert.That(signedNumbers, Is.EquivalentTo(new[] { 500 }));
        }


        [Test]
        public void _1000_is_1000()
        {
            var numbers = new[] { 1000 };

            var signedNumbers = RomanToNumberConverter.ApplySubstractionRule(numbers);

            Assert.That(signedNumbers, Is.EquivalentTo(new[] { 1000 }));
        }
    }
}