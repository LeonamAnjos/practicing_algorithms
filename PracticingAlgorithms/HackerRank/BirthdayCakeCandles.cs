using System.Linq;

namespace PracticingAlgorithms.HackerRank
{
    public class BirthdayCakeCandles
    {
        public static int Perform(int[] input)
        {
            var max = input.Max();
            return input.Count(e => e == max);
        }
    }
}