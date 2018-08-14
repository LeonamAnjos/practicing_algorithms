using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticingAlgorithms.HackerRank
{
    public class CountTriplets
    {
        public static long Count(List<long> arr, long r)
        {
            return r == 1 ? CountForRadiosEqualOne(arr) : CountFor(arr, r);
        }

        private static long CountForRadiosEqualOne(List<long> arr)
        {
            const int tripletSizeMissingOne = 2;

            long result = 0;
            for (var i = 0; i < arr.Count - tripletSizeMissingOne; i++)
            {
                var range = arr.GetRange(i, arr.Count - i);
                var count = range.Count(l => l == range[0]) - tripletSizeMissingOne;
                result += count > 0 ? count : 0;
            }
            return result;
        }

        private static long CountFor(List<long> arr, long r)
        {
            var result = 0;
            foreach (var l in arr)
            {
                var c1 = arr.Count(l1 => l1 == l * r);
                var c2 = arr.Count(l2 => l2 == l * r * r);
                result += c1 * c2;
            }
            return result;
        }

    }

}