using System;
using System.Collections.Generic;

namespace PracticingAlgorithms.Others
{
    public class ReversePolishNotationCalculator
    {
        private static readonly Dictionary<char, Func<double, double, double>> Operations = new Dictionary<char, Func<double, double, double>>
        {
            {'+', (x, y) => y + x },
            {'-', (x, y) => y - x },
            {'*', (x, y) => y * x },
            {'/', (x, y) => y / x },
        };

        public static double Calculate(string input)
        {
            var stack = new Stack<double>();
            foreach (var c in input)
            {
                if (char.IsNumber(c))
                {
                    stack.Push(char.GetNumericValue(c));
                    continue;
                }

                if(!Operations.ContainsKey(c))
                    throw new ApplicationException($"The input with '{c}' is invalid!");

                if (stack.Count < 2)
                    throw new ApplicationException($"The input '{input}' is invalid!");

                stack.Push(Operations[c].Invoke(stack.Pop(), stack.Pop()));
            }

            if (stack.Count > 1)
                throw new ApplicationException($"The input '{input}' is invalid!");

            return stack.Pop();
        }
    }
}