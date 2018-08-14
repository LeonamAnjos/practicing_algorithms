using System;
using NUnit.Framework;

namespace PracticingAlgorithms.Codility
{
    [TestFixture]
    public class SmallestNumberMissingTest
    {
        [Test]
        public void CodilitySampleOneTest()
        {
            var result = SmallestNumberMissing.Perform(new[] { 1, 3, 6, 4, 1, 2 });
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void CodilitySampleTwoTest()
        {
            var result = SmallestNumberMissing.Perform(new[] { 1, 2, 3 });
            Assert.That(result, Is.EqualTo(4));

        }

        [Test]
        public void CodilitySampleThreeTest()
        {
            var result = SmallestNumberMissing.Perform(new[] { -1, -3 });
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
