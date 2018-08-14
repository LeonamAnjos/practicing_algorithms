using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticingAlgorithms.Codility
{
    public class BinarianSmallestSequence
    {
        public static int Perform(int[] input)
        {
            var binarian = Binarian(input);
            var count = 0;
            while (binarian > 0)
            {
                var exp = Math.Truncate(Math.Log(binarian, 2));
                binarian -= Math.Pow(2, exp);
                count++;
            }

            return count;
        }

        private static double Binarian(IEnumerable<int> input)
        {
            return input.Select(i => Math.Pow(2, i)).Sum();
        }

    }
}