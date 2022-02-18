using NUnit.Framework;

namespace FromRomanNumerals.Tests
{
    public class NumberToRoman_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void _1_is_I()
        {
            var roman = NumberToRomanConverter.ToLongRoman(1);
            Assert.That(roman, Is.EqualTo("I"));
        }

        [Test]
        public void _2_is_II()
        {
            var roman = NumberToRomanConverter.ToLongRoman(2);
            Assert.That(roman, Is.EqualTo("II"));
        }

        [Test]
        public void _3_is_III()
        {
            var roman = NumberToRomanConverter.ToLongRoman(3);
            Assert.That(roman, Is.EqualTo("III"));
        }

        [Test]
        public void _4_is_IIII()
        {
            var roman = NumberToRomanConverter.ToLongRoman(4);
            Assert.That(roman, Is.EqualTo("IIII"));
        }

        [Test]
        public void _5_is_V()
        {
            var roman = NumberToRomanConverter.ToLongRoman(5);
            Assert.That(roman, Is.EqualTo("V"));
        }

        [Test]
        public void _6_is_VI()
        {
            var roman = NumberToRomanConverter.ToLongRoman(6);
            Assert.That(roman, Is.EqualTo("VI"));
        }

        [Test]
        public void _7_is_VII()
        {
            var roman = NumberToRomanConverter.ToLongRoman(7);
            Assert.That(roman, Is.EqualTo("VII"));
        }

        [Test]
        public void _8_is_VIII()
        {
            var roman = NumberToRomanConverter.ToLongRoman(8);
            Assert.That(roman, Is.EqualTo("VIII"));
        }

        [Test]
        public void _9_is_VIIII()
        {
            var roman = NumberToRomanConverter.ToLongRoman(9);
            Assert.That(roman, Is.EqualTo("VIIII"));
        }

        [Test]
        public void _10_is_X()
        {
            var roman = NumberToRomanConverter.ToLongRoman(10);
            Assert.That(roman, Is.EqualTo("X"));
        }

        [Test]
        public void _100_is_C()
        {
            var roman = NumberToRomanConverter.ToLongRoman(100);
            Assert.That(roman, Is.EqualTo("C"));
        }

        [Test]
        public void _99_is_LXXXXVIIII()
        {
            var roman = NumberToRomanConverter.ToLongRoman(99);
            Assert.That(roman, Is.EqualTo("LXXXXVIIII"));
        }
    }
}