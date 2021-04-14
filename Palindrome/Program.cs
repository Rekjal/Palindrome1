using System;
using Palindrome.Models;

namespace Palindrome
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string:");
            string enteredString = Console.ReadLine();
            
            Palindrome1 SomeObjectName = new Palindrome1();
            bool result = SomeObjectName.PalindromeCheck(enteredString);
            Console.WriteLine(result);

            
        }
    }
}