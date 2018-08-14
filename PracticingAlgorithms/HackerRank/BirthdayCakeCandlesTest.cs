using NUnit.Framework;

namespace PracticingAlgorithms.HackerRank
{
    [TestFixture]
    public class BirthdayCakeCandlesTest
    {
        [Test]
        public void HackerRankSampleOne()
        {
            var result = BirthdayCakeCandles.Perform(new[] {3, 2, 1, 3});
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void HackerRankSampleTwo()
        {
            var result = BirthdayCakeCandles.Perform(new[] { 3, 2, 4, 3 });
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void HackerRankSampleThree()
        {
            var result = BirthdayCakeCandles.Perform(new[] { 5, 2, 1, 3, 5, 2, 1, 1, 5, });
            Assert.That(result, Is.EqualTo(3));
        }
    }
}
