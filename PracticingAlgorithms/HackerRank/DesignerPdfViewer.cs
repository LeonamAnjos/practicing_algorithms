using System;
using System.Linq;

namespace PracticingAlgorithms.HackerRank
{
    public class DesignerPdfViewer
    {
        public static int HighlightedArea(int[] height, string word)
        {
            var maxHeight = word.ToCharArray()
                .Select(c => height[CharPosition(c)])
                .Max();

            return maxHeight * word.Length;
        }

        private static int CharPosition(char c)
        {
            const int a = 97;
            return c - a;
        }
    }
}