using System;
using System.Security.Policy;
using NUnit.Framework;

namespace PracticingAlgorithms.Codility
{
    [TestFixture]
    public class BinarianSmallestSequenceTest
    {
        [Test]
        public void CodilitySampleTest()
        {
            var result = BinarianSmallestSequence.Perform(new[] { 1, 0, 2, 0, 0, 2 });
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void ShouldReturnTwoWhenTheBinarianSumIsTwentyFour()
        {
            var result = BinarianSmallestSequence.Perform(new[] {3, 3, 3});
            Assert.That(result, Is.EqualTo(2));

        }

        [Test]
        public void ShouldReturnOneWhenTheBinarianSumIsEight()
        {
            var result = BinarianSmallestSequence.Perform(new[] {2, 2});
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
