using Round3_29_01_2025;


namespace Nunit.Tests
{
    [TestFixture]
    public class TwoSumTests
    {
        private TwoSum cut;

        [SetUp]
        public void setup()
        {
            cut = new TwoSum();
        }

        [Test]
        [TestCase(new int[] { }, 0, new int[] { })]
        [TestCase(new int[] { 25 }, 25, new int[] { })]
        [TestCase(new int[] { 1, 1, 1 }, 3, new int[] { })]
        [TestCase(new int[] { 2, 7 }, 9, new int[] { 0, 1 })]
        [TestCase(new int[] { 2, 7, 3, -1, 4 }, 2, new int[] { 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 5, new int[] { 1, 2 })]
        [TestCase(new int[] { 2, 1, 3 }, 5, new int[] { 0, 2 })]
        [TestCase(new int[] { 2, 1, -3 }, -1, new int[] { 0, 2 })]
        [TestCase(new int[] { -2, 1, -3 }, -5, new int[] { 0, 2 })]
        public void GetTwoSum_ReturnsCorrectIndexes_WhenTargetValuePassed(int[] array, int target, int[] indexes)
        {
            // A

            // A
            var actual = cut.GetTwoSum(array, target);
            // A
            Assert.That(indexes.SequenceEqual(actual));
        }
    }
}
