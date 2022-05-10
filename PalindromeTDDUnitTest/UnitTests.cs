using NUnit.Framework;
using PalindromeTDD;

namespace PalindromeTDDUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void VerifyIfRotatorIsAPalindrome()
        {
            Assert.True(Palindrome.IsPalindrome("Rotator"));
        }

        [Test]
        public void VerifyIfBobIsAPalindrome()
        {
            Assert.True(Palindrome.IsPalindrome("bob"));
        }

        [Test]
        public void VerifyIfMadamIsAPalindrome()
        {
            Assert.True(Palindrome.IsPalindrome("madam"));
        }

        [Test]
        public void VerifyIfmAlAyAlamIsAPalindrome()
        {
            Assert.True(Palindrome.IsPalindrome("mAlAyAlam"));
        }

        [Test]
        public void VerifyIf1IsAPalindrome()
        {
            Assert.True(Palindrome.IsPalindrome("1"));
        }

        [Test]
        public void VerifyIfPhrase1IsAPalindrome()
        {
            Assert.True(Palindrome.IsPalindrome("Able was I, ere I saw Elba"));
        }

        [Test]
        public void VerifyIfPhrase2IsAPalindrome()
        {
            Assert.True(Palindrome.IsPalindrome("Madam I'm Adam"));
        }
        
        [Test]
        public void VerifyIfPhrase3IsAPalindrome()
        {
            Assert.True(Palindrome.IsPalindrome("Step on no pets."));
        }
        
        [Test]
        public void VerifyIfPhrase4IsAPalindrome()
        {
            Assert.True(Palindrome.IsPalindrome("Top spot!."));
        }

        [Test]
        public void VerifyIfDateIsAPalindrome()
        {
            Assert.True(Palindrome.IsPalindrome("02/02/2020"));
        }


        [Test]
        public void VerifyIfxyzIsNOTAPalindrome()
        {
            Assert.False(Palindrome.IsPalindrome("xyz"));
        }

        [Test]
        public void VerifyIfelephantIsNOTAPalindrome()
        {
            Assert.False(Palindrome.IsPalindrome("elephant"));
        }


        [Test]
        public void VerifyIfCountryIsNOTAPalindrome()
        {
            Assert.False(Palindrome.IsPalindrome("Country"));
        }


        [Test]
        public void VerifyIfphrase1IsNOTAPalindrome()
        {
            Assert.False(Palindrome.IsPalindrome("Top . post!"));
        }

        [Test]
        public void VerifyIfphrase2IsNOTAPalindrome()
        {
            Assert.False(Palindrome.IsPalindrome("Wonderful-fool"));
        }

        [Test]
        public void VerifyIfphrase3IsNOTAPalindrome()
        {
            Assert.False(Palindrome.IsPalindrome("Wild imagination!"));
        }
    }
}