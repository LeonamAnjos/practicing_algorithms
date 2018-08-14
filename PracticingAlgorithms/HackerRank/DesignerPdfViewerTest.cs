using System;
using System.Linq;
using NUnit.Framework;

namespace PracticingAlgorithms.HackerRank
{
    [TestFixture]
    public class DesignerPdfViewerTest
    {
        [Test]
        public void HackerRankTest()
        {
            string word = "abc";
            int[] height = "1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5"
                .Split()
                .Select(s => Convert.ToInt32(s))
                .ToArray();

            int result = DesignerPdfViewer.HighlightedArea(height, word);

            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void HackerRankOtherTest()
        {
            string word = "zaba";
            int[] height = "1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 7"
                .Split()
                .Select(s => Convert.ToInt32(s))
                .ToArray();

            int result = DesignerPdfViewer.HighlightedArea(height, word);

            Assert.That(result, Is.EqualTo(28));
        }

    }
}
