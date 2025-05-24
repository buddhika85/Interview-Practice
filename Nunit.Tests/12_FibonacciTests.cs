namespace Nunit.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        private Fibonacci cut;

        [SetUp]
        public void Setup()
        {
            cut = new Fibonacci();
        }

        [Test]
        [TestCase(0,0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(8, 21)]
        public void GetFib_ReturnsFibonacciNumBySeqIndex_WhenCalled(int index, int fibonacci)
        {
            // a
            // a & a
            Assert.That(cut.GetFib(index), Is.EqualTo(fibonacci));
        }


        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(8, 21)]
        public void GetFibMemoization_ReturnsFibonacciNumBySeqIndex_WhenCalled(int index, int fibonacci)
        {
            // a
            // a & a
            Assert.That(cut.GetFibMemoization(index), Is.EqualTo(fibonacci));
        }
    }
}
