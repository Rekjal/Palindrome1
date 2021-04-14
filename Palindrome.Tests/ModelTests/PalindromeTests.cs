using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;

namespace Palindrome.Tests
{
    [TestClass]
    public class PalindromeTester
    {
        [TestMethod]
        public void PalindromeCheck_CheckValidStringPalindrome_True()
        {
            bool testResult = false;
            Palindrome1 testPalindrome = new Palindrome1();
            Assert.AreEqual(testResult, testPalindrome.PalindromeCheck("level"));
        }


    }
}