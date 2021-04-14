using System;

namespace Palindrome.Models
{
    public class Palindrome1
    {
        public bool PalindromeCheck(string enteredString)     // level ==> l e v e l
        {
            char[] cArray = enteredString.ToCharArray();
            string reversedString = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reversedString += cArray[i];
            }
            if (reversedString.Equals(enteredString) ) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}

