using Round3_29_01_2025;

namespace Nunit.Tests
{
    public class SortedSquaredArrayTests
    {
        private SortedSquaredArray cut;

        [SetUp]
        public void Setup()
        {
             cut = new SortedSquaredArray();
        }

        [Test]
        [TestCase(new int [] { -4, -2, 0, 1, 3 }, new int [] { 0, 1, 4, 9, 16 })]
        [TestCase(new int[] { 1, 3, 5 }, new int[] { 1, 9, 25 })]
        [TestCase(new int[] { 0, 5, 6 }, new int[] { 0, 25, 36 })]
        public void GetSortedSquaredArray_ReturnsCorrectSortedSquaredArray_WhenArrayPassed(int[] testCase, int[] expected)
        {
            // Arrange
            // done in setup

            // Act
            var actual = cut.GetSortedSquaredArray(testCase);

            // Assert
            Assert.That(actual, Is.EquivalentTo(expected));
        }
    }
}