using System;

namespace PalindromeTDD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to Check Palindrome : ");
            string name = Console.ReadLine();
            Palindrome.IsPalindrome(name);
            Console.ReadKey();
        }
    }
}
