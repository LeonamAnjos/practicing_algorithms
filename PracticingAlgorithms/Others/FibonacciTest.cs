using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingAlgorithms.Others
{
    [TestFixture]
    public class FibonacciTest
    {
        [Test]
        public void ShouldReturnTheFirstFibonacciNumber()
        {
            var actual = Fibonacci.Elements(1);

            Assert.That(actual.Length, Is.EqualTo(1));
            Assert.That(actual, Is.EqualTo(new int[] { 1 }));
        }

        [Test]
        public void ShouldReturnTheFirstThreeFibonacciNumbers()
        {
            var actual = Fibonacci.Elements(3);

            Assert.That(actual.Length, Is.EqualTo(3));
            Assert.That(actual, Is.EqualTo(new int[] { 1, 1, 2 }));
        }

        [Test]
        public void ShouldReturnTheFirstTenFibonacciNumbers()
        {
            var actual = Fibonacci.Elements(10);

            Assert.That(actual.Length, Is.EqualTo(10));
            Assert.That(actual, Is.EqualTo(new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 }));
        }
    }
}
