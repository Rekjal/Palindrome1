using System;

namespace Palindrome.Models
{
    public class Palindrome1
    {
        public bool PalindromeCheck(string userEnteredString)     // level ==> l e v e l
        {
            char[] cArray = userEnteredString.ToCharArray();
            string reversedString = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reversedString += cArray[i];
            }
            if (reversedString.Equals(userEnteredString) ) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}

