using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using NUnit.Compatibility;
using NUnit.Framework.Constraints;

namespace PracticingAlgorithms.HackerRank
{
    [TestFixture]
    public class CountTripletsTest
    {
        [Test]
        public void HackerRankSample1Test()
        {
            var r = 2;
            var arr = new List<long> { 1, 2, 2, 4 };
            
            var result = CountTriplets.Count(arr, r);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void HackerRankSample2Test()
        {
            var r = 3;
            var arr = new List<long> { 1, 3, 9, 9, 27, 81 };

            var result = CountTriplets.Count(arr, r);

            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void HackerRankSample3Test()
        {
            var r = 5;
            var arr = new List<long> { 1, 5, 5, 25, 125 };

            var result = CountTriplets.Count(arr, r);

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void HackerRankSample4Test()
        {
            var r = 2;
            var arr = new List<long> { 1, 1, 2, 2, 4, 4};

            var result = CountTriplets.Count(arr, r);

            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void HackerRankSample5Test()
        {
            var r = 1;
            var arr = new List<long> { 1, 1, 1 };

            var result = CountTriplets.Count(arr, r);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void HackerRankSample6Test()
        {
            var r = 1;
            var arr = new List<long> { 1, 1, 1, 1 };

            var result = CountTriplets.Count(arr, r);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void HackerRankSample7Test()
        {
            var r = 1;
            var arr = new List<long> { 1, 1, 1, 1, 1 };

            var result = CountTriplets.Count(arr, r);

            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void HackerRankSample8Test()
        {
            var r = 1;
            var arr = new List<long> { 1, 1, 2, 2, 2, 2 };

            var result = CountTriplets.Count(arr, r);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void HackerRankSample9Test()
        {
            var r = 1;
            var input = "1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1";
            var arr = new List<long>(input.Split(' ').Select(s => Convert.ToInt64(s)));

            var result = CountTriplets.Count(arr, r);

            Assert.That(result, Is.EqualTo(161700));
        }

    }
}
