using System;
using System.Text.RegularExpressions;

namespace PalindromeTDD
{
    public class Palindrome
    {
        public static bool IsPalindrome(string? input = "")
        {
            string reverse = string.Empty;
            string result = Regex.Replace(input, "[^0-9a-zA-Z]+", "");
            foreach (char c in result)
            {
                reverse = c + reverse;
            }
            if (result.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{input} is Palindrome");
                return true;
            }
            else
            {
                Console.WriteLine($"{input} is not Palindrome");
                return false;
            }
        }
    }
}
