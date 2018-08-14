using System;
using NUnit.Framework;

namespace PracticingAlgorithms.Codility
{
    [TestFixture]
    public class BitonicSequenceTest
    {
        [Test]
        public void CodilitySampleTest()
        {
            var result = BitonicSequence.Perform(new[] { 0, 1, 3, -2, 0, 1, 0, -3, 2, 3 });
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void CodilitySampleTwoTest()
        {
            var result = BitonicSequence.Perform(new[] { 0 });
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void ShouldReturnLessOneIfThereIsNoPit()
        {
            var result = BitonicSequence.Perform(new[] { 1, 3, 6, 7, 9 });
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void ShouldReturnSixAsDeepestPit()
        {
            var result = BitonicSequence.Perform(new[] { 1, 3, -2, -3, 0, 2, 4, 0, -1, 5 });
            Assert.That(result, Is.EqualTo(6));
        }
    }
}
