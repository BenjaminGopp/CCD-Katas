using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromRomanNumerals
{
    public static class NumberToRomanConverter
    {
        internal static string ConvertNumberToRoman(int number)
        {
            //var roman = ToLongRoman(number);
            //var simplyfiedRoman = ToSimpleRoman(roman);
            //return simplyfiedRoman;
            return ToShortRoman(number);
        }

        internal static string ToSimpleRoman(string roman)
        {
            //var list = new List<(string, string)>()
            //{
            //    ("DDDD", "DM"),
            //    ("CCCC", "CD"),
            //    ("LLLL", "LC"),
            //    ("XXXX", "XL"),
            //    ("VVVV", "VX"),
            //    ("IIII","IV"),
            //};

            var list = new List<(string, string)>()
            {
                ("IIII","IV"),
                ("VVVV", "VX"),
                ("XXXX", "XL"),
                ("LLLL", "LC"),
                ("CCCC", "CD"),
                ("DDDD", "DM"),
            };

            var simpleRoman = roman;

            foreach (var (full, simple) in list)
            {
                simpleRoman = simpleRoman.Replace(full, simple);
            }

            return simpleRoman;

        }

        internal static string ToLongRoman(int number)
        {
            var roman = new StringBuilder();

            var list = new List<(int, string)>()
            {
                (1000, "M"),
                (500, "D"),
                (100,"C"),
                (50, "L"),
                (10, "X"),
                (5, "V"),
                (1, "I")
            };


            foreach (var (value, literal) in list)
            {
                var rest = Math.Ceiling((double)(number / value));
                number -= (int)rest * value;

                for (int i = 0; i < rest; i++)
                {
                    roman.Append(literal);
                }
            }


            return roman.ToString();
        }


        internal static string ToShortRoman(int number)
        {
            var roman = new StringBuilder();

            var list = new List<(int, string)>()
            {
                (1000, "M"),
                (900, "CM"),
                (500, "D"),
                (400, "CD"),
                (100,"C"),
                (90,"LC"),
                (50, "L"),
                (40, "XL"),
                (10, "X"),
                (9, "IX"),
                (5, "V"),
                (4, "IV"),
                (1, "I")
            };


            foreach (var (value, literal) in list)
            {
                var rest = Math.Ceiling((double)(number / value));
                number -= (int)rest * value;

                for (int i = 0; i < rest; i++)
                {
                    roman.Append(literal);
                }
            }


            return roman.ToString();
        }
    }
}
