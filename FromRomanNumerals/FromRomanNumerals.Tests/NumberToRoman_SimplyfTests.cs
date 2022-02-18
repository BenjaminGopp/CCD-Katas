using NUnit.Framework;

namespace FromRomanNumerals.Tests
{
    public class NumberToRomanSimplyfy_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void _IIII_is_IV()
        {
            var roman = NumberToRomanConverter.ToSimpleRoman("IIII");
            Assert.That(roman, Is.EqualTo("IV"));
        }

        [Test]
        public void _9_is_IX()
        {
            var simply = NumberToRomanConverter.ToShortRoman(9);
            Assert.That(simply, Is.EqualTo("IX"));
        }

    }
}