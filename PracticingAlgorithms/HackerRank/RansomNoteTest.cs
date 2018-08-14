using NUnit.Framework;

namespace PracticingAlgorithms.HackerRank
{
    [TestFixture]
    public class RansomNoteTest
    {
        [Test]
        public void HackerRankSample1Test()
        {
            string[] magazine = { "guive", "me", "one", "grand", "today", "night", };
            string[] note = { "guive", "one", "grand", "today", };

            var result = RansomNote.CheckMagazine(magazine, note);
            Assert.That(result, Is.True);
        }

        [Test]
        public void HackerRankSample2Test()
        {
            string[] magazine = { "two", "times", "three", "is", "not", "four", };
            string[] note = { "two", "times", "two", "is", "four", };

            var result = RansomNote.CheckMagazine(magazine, note);
            Assert.That(result, Is.False);
        }
        
        [Test]
        public void HackerRankSample3Test()
        {
            string[] magazine = { "ive", "got", "a", "lovely", "bunch", "of", "coconuts", };
            string[] note = { "ive", "got", "some", "coconuts", };

            var result = RansomNote.CheckMagazine(magazine, note);
            Assert.That(result, Is.False);
        }

        [Test]
        public void HackerRankSample4Test()
        {
            string[] magazine = { "two", "times", "two", "three", "is", "not", "four", };
            string[] note = { "two", "times", "two", "is", "four", };

            var result = RansomNote.CheckMagazine(magazine, note);
            Assert.That(result, Is.True);
        }


    }
}
