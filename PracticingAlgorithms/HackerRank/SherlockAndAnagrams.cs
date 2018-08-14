using System.Collections.Generic;
using System.Linq;

namespace PracticingAlgorithms.HackerRank
{
    public class SherlockAndAnagrams
    {
        public static int AnagrammaticPairs(string s)
        {
            var dictionary = new Dictionary<string, Anagram>();

            var words = BreakIntoWords(s);
            foreach (var word in words)
            {
                var w = string.Concat(word.OrderBy(c => c));
                
                if (dictionary.ContainsKey(w))
                    dictionary[w].Add(1);
                else
                    dictionary[w] = new Anagram();
            }

            return dictionary.Values.Select(v => v.Result).Sum();
        }

        private static IEnumerable<string> BreakIntoWords(string s)
        {
            var words = new List<string>();
            for (var i = 1; i <= s.Length; i++)
                for(var y = 0; y + i <= s.Length; y++)
                    words.Add(s.Substring(y, i));

            return words;
        }
    }

    public class Anagram
    {
        public void Add(int i)
        {
            Count += i;
            Result += Count;
        }

        public int Result { get; private set; }
        public int Count { get; private set; }

        public override string ToString()
        {
            return $"{Count}-{Result}";
        }
    }
}