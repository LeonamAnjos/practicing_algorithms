using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace PracticingAlgorithms.HackerRank
{
    [TestFixture]
    public class SherlockAndAnagramsTest
    {
        [Test]
        public void HackerRankSample1Test()
        {
            string[] words = { "abba", "abcd" };
            var result = words.Select(SherlockAndAnagrams.AnagrammaticPairs).ToList();

            Assert.That(result, Is.EqualTo(new List<int>{ 4, 0 }));
        }

        [Test]
        public void HackerRankSample2Test()
        {
            string[] words = { "ifailuhkqq", "kkkk" };
            var result = words.Select(SherlockAndAnagrams.AnagrammaticPairs).ToList();

            Assert.That(result, Is.EqualTo(new List<int> { 3, 10 }));
        }

        [Test]
        public void HackerRankSample3Test()
        {
            string[] words = { "cdcd", };
            var result = words.Select(SherlockAndAnagrams.AnagrammaticPairs).ToList();

            Assert.That(result, Is.EqualTo(new List<int> { 5 }));
        }

    }
}
