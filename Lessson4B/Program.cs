using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson4B
{
    /// <summary>
    ///     FrogRiverOne Submitted in: C#
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Program().solution(3, new[] {3, 1, 2, 4, 5}));
            Console.WriteLine(new Program().solution(4, new[] {3, 1, 2, 4, 5}));
            Console.WriteLine(new Program().solution(5, new[] {3, 1, 2, 4, 5}));
            Console.WriteLine(new Program().solution(5, new[] {3, 1, 1, 2, 3, 1, 2, 4, 5}));
        }

        public int solution(int X, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var neededPositions = new HashSet<int>(Enumerable.Range(1, X));

            for (int i = 0; i < A.Length; i++)
            {
                if (neededPositions.Contains(A[i]))
                {
                    neededPositions.Remove(A[i]);
                }

                if (!neededPositions.Any())
                {
                    return i;
                }
            }

            return -1;
        }
    }
}