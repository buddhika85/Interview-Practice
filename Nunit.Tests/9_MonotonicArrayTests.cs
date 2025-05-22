using Round3_29_01_2025;

namespace Nunit.Tests
{
    [TestFixture]
    public class MonotonicArrayTests
    {
        private MonotonicArray cut;

        [SetUp]
        public void Setup()
        {
            cut = new MonotonicArray(); // class under test
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, true)]
        [TestCase(new int[] { 3, 2, 1 }, true)]
        [TestCase(new int[] { 1, 2, 2 }, true)]
        [TestCase(new int[] { 7 }, true)]
        [TestCase(new int[] { }, true)]
        [TestCase(new int[] { 3, 3, 3}, true)]
        [TestCase(new int[] { 2, 3, 1, 2 }, false)]
        public void IsMonotonic_ReturnsMonotonicOrNot_WhenArraysPassed(int[] array, bool expected)
        {
            // A
            // A & A
            Assert.That(expected, Is.EqualTo(cut.IsMonotonic(array)));
        }

    }
}
