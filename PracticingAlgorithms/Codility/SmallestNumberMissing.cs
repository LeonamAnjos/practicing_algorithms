using System.Linq;

namespace PracticingAlgorithms.Codility
{
    public class SmallestNumberMissing
    {
        public static int Perform(int[] input)
        {
            var ordered = input.Where(e => e > 0).OrderBy(e => e).Distinct();
            var i = 1;

            foreach (var e in ordered)
            {
                if (e > i) return i;
                i++;
            }

            return i;
        }
    }
}