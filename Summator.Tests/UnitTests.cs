namespace Summator.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSumTwoNumbers()
        {
         long result = ConsoleApp1.Summator.Sum(new int[] { 5, 7 });
         Assert.That(result == 12);
        }
        [Test]
        public void TestSumOneNumber()
        {
            long result = ConsoleApp1.Summator.Sum(new int[] { 5 });
            Assert.That(result == 5);
        }
        [Test]
        public void TestSumNegativeNumbers()
        {
            long result = ConsoleApp1.Summator.Sum(new int[] { -5, -7 });
            Assert.That(result == -12);
        }
        [Test]
        public void TestSumBigInt()
        {
            long result = ConsoleApp1.Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000 });
            Assert.That(result == 6000000000);
        }
        [Test]
        public void TestEmptyArray()
        {
            long result = ConsoleApp1.Summator.Sum(new int[] {  });
            Assert.That(result == 0);
        }
        [Test]
        public void TestAverage()
        {
            long result = ConsoleApp1.Summator.Average(new int[] { 5, 10, 15});
            Assert.That(result == 10);
        }
    }
}