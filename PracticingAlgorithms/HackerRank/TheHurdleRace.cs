using System.Linq;

namespace PracticingAlgorithms.HackerRank
{
    public class TheHurdleRace
    {
        public static int MagicPotion(int naturalHeight, int[] hurdlesHeight)
        {
            var potionDoses = hurdlesHeight.Max() - naturalHeight;
            return potionDoses > 0 ? potionDoses : 0;
        }
    }
}