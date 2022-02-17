using NUnit.Framework;

namespace FromRomanNumerals.Tests
{
    public class SubstractionRuleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void _1_before_5()
        {
            var numbers = new[] { 1, 5 };

            var signedNumbers = RomanToNumberConverter.ApplySubstractionRule(numbers);

            Assert.That(signedNumbers, Is.EquivalentTo(new[] { -1, 5 }));
        }

        [Test]
        public void _1_before_10()
        {
            var numbers = new[] { 1, 10 };

            var signedNumbers = RomanToNumberConverter.ApplySubstractionRule(numbers);

            Assert.That(signedNumbers, Is.EquivalentTo(new[] { -1, 10 }));
        }

        [Test]
        public void _1_before_50()
        {
            var numbers = new[] { 1, 50 };

            var signedNumbers = RomanToNumberConverter.ApplySubstractionRule(numbers);

            Assert.That(signedNumbers, Is.EquivalentTo(new[] { -1, 50 }));
        }


        [Test]
        public void _1_before_100()
        {
            var numbers = new[] { 1, 100 };

            var signedNumbers = RomanToNumberConverter.ApplySubstractionRule(numbers);

            Assert.That(signedNumbers, Is.EquivalentTo(new[] { -1, 100 }));
        }


        [Test]
        public void _1_before_500()
        {
            var numbers = new[] { 1, 500 };

            var signedNumbers = RomanToNumberConverter.ApplySubstractionRule(numbers);

            Assert.That(signedNumbers, Is.EquivalentTo(new[] { -1, 500 }));
        }


        [Test]
        public void _1_before_1000()
        {
            var numbers = new[] { 1, 1000 };

            var signedNumbers = RomanToNumberConverter.ApplySubstractionRule(numbers);

            Assert.That(signedNumbers, Is.EquivalentTo(new[] { -1, 1000 }));
        }


    }
}