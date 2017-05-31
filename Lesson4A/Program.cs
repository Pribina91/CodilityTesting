using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4A
{
    /// <summary>
    ///     PermCheck
    /// </summary>
    [System.Runtime.InteropServices.Guid("71790733-CD91-4C2B-BC7A-666B7E7C905F")]
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Program().solution(new[] {3, 1, 2, 4, 5}));
            Console.WriteLine(new Program().solution(new[] {3, 1, 4, 4, 4, 5}));
            Console.WriteLine(new Program().solution(new[] {3, 1, 2, 5}));
            Console.WriteLine(new Program().solution(new int[] {2}));
            Console.WriteLine(new Program().solution(new int[] {1, 3}));
            Console.WriteLine(new Program().solution(new int[] {3, 2, 1}));
            Console.WriteLine(new Program().solution(new int[] {3, 2, 1444}));
            Console.WriteLine(new Program().solution(new int[] {1000000000}));
            Console.WriteLine(new Program().solution(Enumerable.Range(1, 1000000).ToArray()));
        }

        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            var maxValue = A.Max();
            if (maxValue != A.Length)
            {
                return 0;
            }

            var permutationNumberAvailable = new HashSet<int>();
            for (int i = 1; i <= maxValue; i++)
            {
                permutationNumberAvailable.Add(i);
            }

            foreach (var number in A)
            {
                if (permutationNumberAvailable.Contains(number))
                {
                    permutationNumberAvailable.Remove(number);
                }
                else
                {
                    return 0;
                }
            }

            if (permutationNumberAvailable.Any())
            {
                return 0;
            }

            return 1;
        }
    }
}