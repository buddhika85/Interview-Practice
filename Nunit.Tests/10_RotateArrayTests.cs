using Round3_29_01_2025;

namespace Nunit.Tests
{
    [TestFixture]
    public class _10_RotateArrayTests
    {
        private RotateArray cut;

        [SetUp]
        public void Setup()
        {
            cut = new RotateArray();
        }

        [Test]
        [TestCase(new int[] { }, 10, new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 1, new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 2, new int[] { 3, 4, 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 3, new int[] { 2, 3, 4, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 4, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 5, new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2 }, 1, new int[] { 2, 1 })]
        public void GetKRotatedArray_ReturnsCorrectResult_WhenCalled(int[] array, int k, int[] expected)
        {
            // a
            // a & a
            Assert.That(expected.SequenceEqual(cut.GetKRotatedArray(array, k)));
        }


        [Test]
        [TestCase(new int[] { }, 10, new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 1, new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 2, new int[] { 3, 4, 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 3, new int[] { 2, 3, 4, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 4, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 5, new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2 }, 1, new int[] { 2, 1 })]
        public void RotateInPlace_ReturnsCorrectResult_WhenCalled(int[] array, int k, int[] expected)
        {
            // a
            cut.RotateInPlace(array, k);    // void method call
            // a & a
            Assert.That(expected.SequenceEqual(array));
        }
    }
}
