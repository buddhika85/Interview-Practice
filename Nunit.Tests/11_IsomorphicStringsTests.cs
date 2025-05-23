namespace Nunit.Tests
{
    [TestFixture]
    public class IsomorphicStringsTests
    {
        private IsomorphicStrings cut;

        [SetUp]
        public void setup()
        {
            cut = new IsomorphicStrings();
        }

        [Test]
        [TestCase("", "", true)]
        [TestCase("abacus", "rirfgs", true)]
        [TestCase("green", "abccd", true)]
        [TestCase("aba", "pqr", false)]
        [TestCase("ababr", "eoeoo", false)]
        [TestCase("ababr", "pqrqo", false)]
        public void IsIsomorphic_ReturnsCorrectResult_WhenTested(string source, string target, bool isIsomorphic)
        {
            // a
            // a & a
            Assert.That(cut.IsIsomorphic(source, target), Is.EqualTo(isIsomorphic));
        }


        [Test]
        [TestCase("", "", true)]
        [TestCase("abacus", "rirfgs", true)]
        [TestCase("green", "abccd", true)]
        [TestCase("aba", "pqr", false)]
        [TestCase("ababr", "eoeoo", false)]
        [TestCase("ababr", "pqrqo", false)]
        public void IsIsomorphic_UsingDictionaryAndSet_ReturnsCorrectResult_WhenTested(string source, string target, bool isIsomorphic)
        {
            // a
            // a & a
            Assert.That(cut.IsIsomorphic_UsingDictionaryAndSet(source, target), Is.EqualTo(isIsomorphic));
        }
    }
}
