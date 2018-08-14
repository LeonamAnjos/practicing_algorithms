using System.Linq;
using NUnit.Framework;

namespace PracticingAlgorithms.HackerRank
{
    [TestFixture]
    public class UtopianTreeTest
    {
        [Test]
        public void HackerRankTest()
        {
            int result = UtopianTree.HeightAt(5);
            Assert.That(result, Is.EqualTo(14));
        }

        [Test]
        public void HackerRankOther0Test()
        {
            int result = UtopianTree.HeightAt(0);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void HackerRankOther1Test()
        {
            int result = UtopianTree.HeightAt(1);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void HackerRankOther4Test()
        {
            int result = UtopianTree.HeightAt(4);
            Assert.That(result, Is.EqualTo(7));
        }

    }
}
