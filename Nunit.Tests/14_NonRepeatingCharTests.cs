using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit.Tests
{
    [TestFixture]
    public class NonRepeatingCharTests
    {
        private NonRepeatingChar cut;

        [SetUp]
        public void Setup()
        {
            cut = new NonRepeatingChar();
        }

        [Test]
        [TestCase("a", 0)]
        [TestCase("ACbc", 0)]
        [TestCase("AACbc", 2)]
        [TestCase("AACCbbc", 6)]
        public void NonRepeatingChar_ReturnsIndexOfFirstNonRepeatChar_WhenCalledWithValidTests(string str, int index)
        {
            // a & a
            var actualIndex = cut.FirstNonRepeatingChar(str);

            // a
            Assert.That(actualIndex, Is.EqualTo(index));
        }


        [Test]
        [TestCase("")]
        [TestCase("AA")]
        [TestCase("aa")]
        [TestCase("aaAA")]
        [TestCase("aAbaAbABBB")]
        [TestCase("aaaaaa")]
        public void NonRepeatingChar_ReturnsNegativeOne_WhenCalledWithNoExistantUniqueChars(string str)
        {
            // a & a
            var actualIndex = cut.FirstNonRepeatingChar(str);

            // a
            Assert.That(actualIndex, Is.EqualTo(-1));
        }
    }
}
