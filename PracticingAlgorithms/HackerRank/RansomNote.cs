using System.Collections.Generic;

namespace PracticingAlgorithms.HackerRank
{
    public class RansomNote
    {
        public static bool CheckMagazine(string[] magazine, string[] note)
        {
            var words = WordsOf(magazine);

            foreach (var n in note)
            {
                if (!words.ContainsKey(n))
                    return false;

                words[n] -= 1;
                if (words[n] <= 0)
                    words.Remove(n);
            }

            return true;
        }

        private static Dictionary<string, int> WordsOf(string[] magazine)
        {
            var dictionary = new Dictionary<string, int>();
            foreach (var m in magazine)
                if (dictionary.ContainsKey(m))
                    dictionary[m] += 1;
                else
                    dictionary[m] = 1;
            return dictionary;
        }
    }
}