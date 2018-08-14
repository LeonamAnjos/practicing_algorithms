using System.Collections.Generic;
using System.Linq;
using NUnit.Framework.Interfaces;

namespace PracticingAlgorithms.HackerRank
{
    public class ClimbingTheLeaderboard
    {
        public static int[] Positions(int[] scores, int[] alice)
        {
            var result = new List<int>();

            var uniqueScores = scores.Distinct().ToArray();
            result.Add(uniqueScores.Count(s => s > alice[0]) + 1);

            for(var i = 1; i < alice.Length; i++)
            {
                var currentPosition = result[i - 1];
                for (var y = currentPosition - 1; y > 0; y--)
                {
                    if (uniqueScores[y - 1] <= alice[i])
                        currentPosition--;
                    else
                        break;
                }

                result.Add(currentPosition);
            }

            return result.ToArray();
        }
    }
}