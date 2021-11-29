using System;
using System.Text;
using System.Text.RegularExpressions;
namespace ConsoleApp1
{
    class Program
    {
        private static readonly string[] groups =
        {
            "trillion",
            "billion",
            "million",
            "thousand",
            "hundred",
            "cents"
        };
        private static readonly string pattern =
            @"^(?<trillion>\d{1,3})?(?<billion>\d{1,3})?(?<million>\d{1,3})?(?<thousand>\d{1,3})?(?<hundred>\d{1,3})(\.(?<cents>\d{1,2}))?$";
        private static readonly RegexOptions options = RegexOptions.RightToLeft;
        static void Main(string[] args)
        {
            Regex regex = new Regex(pattern, options);
            Console.WriteLine("Hello, Please enter a numeric value.");
            string input = Console.ReadLine();
            decimal result = 0;
            if (decimal.TryParse(input, out result))
            {
                Console.WriteLine(BuildNumberTextOf(result, ref regex));
            }
            else
            {
                Console.WriteLine("Input needs to be a numeric value");
            }
            Console.ReadLine();
           
        }
        public static string BuildNumberTextOf(decimal value, ref Regex regex)
        {
            var match = regex.Match(Convert.ToString(value));

            var sb = new StringBuilder();
            foreach (var group in groups)
            {
                var capturedValue = match.Groups[group].Value.TrimStart(new char[] { '0' });

                // Dollars wont be appended to result if the 
                // hundred group contains all zeros.
                if (capturedValue == "" && group == "hundred")
                {
                    sb.Append("dollars ");
                    continue;
                }
                else if (capturedValue == "")
                {
                    continue;
                }
                else
                {
                    var words = HundredsToWords(Convert.ToInt32(capturedValue));

                    // Make sure "hundred" doesnt double up since
                    // "hundred" is also appended in the HundredsToWords
                    // function.
                    if (group != "hundred")
                    {
                        var cents = group == "cents" ? "and " : "";
                        sb.Append($"{cents}{words} {group} ");
                    }
                    else
                    {
                        sb.Append($"{words} dollars ");
                    }
                }
            }

            return sb.ToString().TrimEnd();
        }

        private static string HundredsToWords(int number)
        {
            if (number > 999) throw new ArgumentOutOfRangeException("Passed value too large.");

            var sb = new StringBuilder();

            if ((number / 100) > 0)
            {
                sb.Append(HundredsToWords(number / 100) + " hundred ");
                number %= 100;
            }

            if (number > 0)
            {
                var units = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tens = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                {
                    sb.Append(units[number]);
                }
                else
                {
                    sb.Append(tens[number / 10]);
                    if ((number % 10) > 0)
                    {
                        sb.Append("-" + units[number % 10]);
                    }
                }
            }

            return sb.ToString();
        }
    }
}
