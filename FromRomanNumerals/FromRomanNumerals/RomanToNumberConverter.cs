internal static class RomanToNumberConverter
{

    static Dictionary<char,int> romanToNumber = new Dictionary<char,int>();

    internal static int[] MapRomanToNumbers(string roman)
    {
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

        for (int i = 0; i < numbers.Length-1; i++)
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