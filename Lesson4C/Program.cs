using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson4C
{
    /// <summary>
    ///     MissingInteger
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Program().solution(new int[] {1000000000}));
            Console.WriteLine(new Program().solution(Enumerable.Range(-50000, 150000).Where(i => i != 5).ToArray()));
        }

        public int solution(int[] A)
        {
            var positiveSet = A.Where(a => a > 0);
            var elemetns = new SortedSet<int>();
            foreach (var positiveNumber in positiveSet)
            {
                if (!elemetns.Contains(positiveNumber))
                {
                    elemetns.Add(positiveNumber);
                }
            }

            var minimalMissingNumber = 1;
            foreach (var elemetn in elemetns)
            {
                if (elemetn != minimalMissingNumber)
                {
                    break;
                }

                minimalMissingNumber++;
            }

            return minimalMissingNumber;
        }
    }
}