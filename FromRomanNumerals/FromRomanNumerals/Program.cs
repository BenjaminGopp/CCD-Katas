// See https://aka.ms/new-console-template for more information

var interactors = new Interactors();

while (true)
{
    Console.WriteLine("Input Roman");
    var roman = Console.ReadLine();
    if (roman.FirstOrDefault() == 'e')
    {
        break;
    }

    var digit = interactors.ConvertRomanToNumber(roman);
    Console.WriteLine(digit);

}
