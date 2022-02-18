using FromRomanNumerals;

internal class Interactors
{
    internal int ConvertRomanToNumber(string roman)
    {
        bool isValid = RomanToNumberConverter.ValidateRoman(roman);
        if (isValid)
        {
            return RomanToNumberConverter.ConvertRomanToNumber(roman);
        }
        else
        {
            return 0;
        }
    }

    internal string ConvertNumberToRoman(int number)
    {
        return NumberToRomanConverter.ConvertNumberToRoman(number);
    }
}