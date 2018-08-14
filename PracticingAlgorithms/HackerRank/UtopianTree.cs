using System;

namespace PracticingAlgorithms.HackerRank
{
    public class UtopianTree
    {
        public static int HeightAt(int n)
        {
            var result = 1;
            for (var i = 1; i <= n; i++)
            {
                if (IsSpring(i))
                    result *= 2;
                else
                    result++;
            }
            return result;
        }

        private static bool IsSpring(int i)
        {
            return i % 2 != 0;
        }
    }
}