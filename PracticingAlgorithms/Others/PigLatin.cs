using System;
using System.Text;
using System.Threading.Tasks;

namespace PracticingAlgorithms.Others
{
    public class PigLatin
    {
        public static string Run(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
                return sentence;

            var task = Task<string[]>.Factory.StartNew(() => Map(sentence))
                .ContinueWith<string[]>(t => Process(t.Result))
                .ContinueWith<string>(t => Reduce(t.Result));

            return task.Result;
        }

        private static string Reduce(string[] result)
        {
            var sb = new StringBuilder();
            foreach (var w in result)
                sb.Append(w);

            sb.Length -= 1;
            return sb.ToString();
        }

        private static string[] Process(string[] words)
        {
            for(var i = 0; i < words.Length; i++)
            {
                var index = i;
                Task.Factory.StartNew(
                    () => words[index] = PinLatinalize(words[index]),
                    TaskCreationOptions.AttachedToParent | TaskCreationOptions.LongRunning);
            }

            return words;
        }

        private static string[] Map(string sentence)
        {
            return sentence.Split(' ');
        }

        private static string PinLatinalize(string w)
        {
            var w1 = w.ToLower();
            var w2 = $"{w1.Substring(1, w1.Length - 1)}{w1[0]}";
            var w3 = $"{w2}ay ";

            return w3;
        }
    }
}
