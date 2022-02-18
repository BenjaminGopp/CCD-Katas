using CsvHelper;
using CsvHelper.Configuration;
using NUnit.Framework;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;

namespace FromRomanNumerals.Tests
{
    public class IntegrationTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        [TestCaseSource("TestData")]
        public void IntegrationTest(RomanTestData data)
        {
            var interactors = new Interactors();
            var number = interactors.ConvertRomanToNumber(data.Roman);

            Assert.That(number, Is.EqualTo(data.Number));
        }

        public static IEnumerable<RomanTestData> TestData()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
                Delimiter = ";"
            };

            var stream = File.OpenText("IntegrationTests\\Romans.csv");
            var csv = new CsvReader(stream, config);

            while (csv.Read())
            {
                yield return new RomanTestData()
                {
                    Roman = csv.GetField<string>(0),
                    Number = csv.GetField<int>(1)
                };

            }


        }


    }
}