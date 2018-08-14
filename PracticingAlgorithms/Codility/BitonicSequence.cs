using System;
using System.Collections.Generic;

namespace PracticingAlgorithms.Codility
{
    public class BitonicSequence
    {
        public static int Perform(int[] input)
        {
            var deeper = -1;
            var p = 0;
            var q = 0;
            var r = 0;

            for(var i = 1; i < input.Length; i++)
            {
                if (input[i] < input[i - 1])
                {
                    if (r > q) p = i - 1;
                    q = i;
                    r = i;
                }
                else if (input[i] > input[i - 1])
                {
                    r = i;
                }

                if (!IsPit(p, q, r)) continue;

                var depth = Depth(input, p, q, r);
                if (deeper < depth) deeper = depth;
//                    Console.WriteLine("Pit! p={0} q={1} r={2} => Depth={3}", p, q, r, depth);

            }

            return deeper;
        }

        private static int Depth(IReadOnlyList<int> input, int p, int q, int r)
        {
            return Math.Min(input[p] - input[q], input[r] - input[q]);
        }

        private static bool IsPit(int p, int q, int r)
        {
            return p < q && q < r;
        }
    }
}