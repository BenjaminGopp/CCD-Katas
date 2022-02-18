// See https://aka.ms/new-console-template for more information

var interactors = new Interactors();

while (true)
{
    Console.Write("Input Roman:");
    var roman = Console.ReadLine();

    if (String.IsNullOrEmpty(roman))
        continue;

    if (roman.FirstOrDefault() == 'e')
    {
        break;
    }

    var digit = interactors.ConvertRomanToNumber(roman);

    if (digit == 0)
    {
        Console.WriteLine($"Invalid roman: {roman}");
    }
    else
    {
        Console.WriteLine(digit);
    }


}
