// See https://aka.ms/new-console-template for more information


internal class Interactors
{
    internal int ConvertRomanToNumber(string roman)
    {
        var numbers = RomanToNumberConverter.MapRomanToNumbers(roman);
        var signedNumbers = RomanToNumberConverter.ApplySubstractionRule(numbers);
        var sum = signedNumbers.Sum();
        return sum;
    }
}