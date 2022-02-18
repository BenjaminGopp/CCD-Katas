// See https://aka.ms/new-console-template for more information


internal class Interactors
{
    internal int ConvertRomanToNumber(string roman)
    {
        bool isValid = RomanToNumberConverter.ValidateRoman(roman);
        if (isValid)
        {
            return RomanToNumberConverter.ConvertRomanToNumber(roman);
        }
        else {
            return 0;
        }
    }
}