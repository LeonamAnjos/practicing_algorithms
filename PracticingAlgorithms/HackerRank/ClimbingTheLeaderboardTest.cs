using NUnit.Framework;

namespace PracticingAlgorithms.HackerRank
{
    [TestFixture]
    public class ClimbingTheLeaderboardTest
    {
        [Test]
        public void HackerRankTest()
        {
            int[] scores = { 100, 100, 50, 40, 40, 20, 10 };
            int[] alice = { 5, 25, 50, 120 };

            int[] result = ClimbingTheLeaderboard.Positions(scores, alice);

            Assert.That(result.Length, Is.EqualTo(alice.Length));
            Assert.That(result, Is.EqualTo(new [] {6, 4, 2, 1}));
        }

        [Test]
        public void ShouldReturn4ThPosition()
        {
            int[] scores = {100, 90, 80};
            int[] alice = {70};

            int[] result = ClimbingTheLeaderboard.Positions(scores, alice);

            Assert.That(result, Is.EqualTo(new[] { 4 }));
        }

        [Test]
        public void ShouldReturn3ThPosition()
        {
            int[] scores = {100, 90, 90};
            int[] alice = {70};

            int[] result = ClimbingTheLeaderboard.Positions(scores, alice);

            Assert.That(result, Is.EqualTo(new[] { 3 }));
        }

        [Test]
        public void ShouldReturn2ThPosition()
        {
            int[] scores = {100, 90, 90};
            int[] alice = {90};

            int[] result = ClimbingTheLeaderboard.Positions(scores, alice);

            Assert.That(result, Is.EqualTo(new[] { 2 }));
        }

        [Test]
        public void ShouldReturn1ThPosition()
        {
            int[] scores = {100, 90, 90};
            int[] alice = {100};

            int[] result = ClimbingTheLeaderboard.Positions(scores, alice);

            Assert.That(result, Is.EqualTo(new[] { 1 }));
        }

    }
}
