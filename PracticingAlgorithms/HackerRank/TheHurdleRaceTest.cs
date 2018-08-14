using NUnit.Framework;

namespace PracticingAlgorithms.HackerRank
{
    [TestFixture]
    public class TheHurdleRaceTest
    {
        [Test]
        public void HackerRankTest()
        {
            const int normalHeight = 7;
            int[] hurlesHeight = { 2, 5, 4, 5, 2 };

            var result = TheHurdleRace.MagicPotion(normalHeight, hurlesHeight);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void HackerRankOtherTest()
        {
            const int normalHeight = 4;
            int[] height = { 1, 6, 3, 5, 2 };

            var result = TheHurdleRace.MagicPotion(normalHeight, height);

            Assert.That(result, Is.EqualTo(2));
        }


    }
}
