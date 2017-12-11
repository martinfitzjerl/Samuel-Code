using System;
using Palindrome.Library.Models;
using Xunit;

namespace Palindrome.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            bool isValidString = true;
            Assert.IsTrue(isValidString, $"String should be valid");
        }

        [TestMethod]
        public void TestMethodTwo()
        {
            bool isValidPalindrome = true;
            Assert.IsTrue(isValidPalindrome, $"String should be valid");
        }

        

    }

}