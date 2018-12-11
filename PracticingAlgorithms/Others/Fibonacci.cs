using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingAlgorithms.Others
{
    public class Fibonacci 
    {
        private static IEnumerable<int> ElementsWithYield()
        {
            int current = 1, previous = 0;
            while(true)
            {
                yield return current;
                int old = current;
                current += previous;
                previous = old;
            }
        }

        public static int[] Elements(int size)
        {
            var result = new List<int>();
            foreach (var n in ElementsWithYield())
            {
                result.Add(n);
                if (--size <= 0)
                    break;
            }

            return result.ToArray();
        }
    }
}
