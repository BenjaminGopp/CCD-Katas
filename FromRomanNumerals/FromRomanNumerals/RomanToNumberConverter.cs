internal static class RomanToNumberConverter
{


    public static int ConvertRomanToNumber(string roman)
    {
        var numbers = MapRomanToNumbers(roman);
        var signedNumbers = ApplySubstractionRule(numbers);
        var sum = signedNumbers.Sum();
        return sum;
    }

    static Dictionary<char, int> romanToNumber = new Dictionary<char, int>()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 },
    };

    internal static bool ValidateRoman(string roman)
    {
        roman = roman.ToUpper();

        for (int i = 0; i < roman.Length; i++)
        {
            if (!romanToNumber.ContainsKey(roman[i]))
            {
                return false;
            }
        }

        return true;
    }

    internal static int[] MapRomanToNumbers(string roman)
    {
        roman = roman.ToUpper();

        var numbers = new int[roman.Length];
        for (int i = 0; i < roman.Length; i++)
        {
            numbers[i] = romanToNumber[roman[i]];
        }
        return numbers;
    }

    internal static int[] ApplySubstractionRule(int[] numbers)
    {
        var sign = 1;

        var signedNumbers = new int[numbers.Length];

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] < numbers[i+1])
            {
                sign = -1;
            }
            else
            {
                sign = 1;
            }

            signedNumbers[i] = numbers[i] * sign;
        }

        signedNumbers[^1] = numbers[^1];

        return signedNumbers;
    }
}