using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PhoneNumberExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This is a text with phone numbers: 0912345678, 0912121212,and 1234567890.";

            List<string> phoneNumbers = ExtractPhoneNumbers(text);

            foreach (string phoneNumber in phoneNumbers)
            {
                Console.WriteLine(phoneNumber);
            }
        }

        static List<string> ExtractPhoneNumbers(string text)
        {
            List<string> phoneNumbers = new List<string>();
            string pattern = @"0\d{9}";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                phoneNumbers.Add(match.Value);
            }

            return phoneNumbers;
        }
    }
}