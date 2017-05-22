using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2B
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Program().solution(new[] {1, 2, 3}, 2);
            Console.WriteLine(string.Join(",", result));

            var result2 = new Program().solution(new[] {3, 8, 9, 7, 6}, 3);
            Console.WriteLine(string.Join(",", result2));
            var result3 = new Program().solution(new[] {1}, 1000);
            Console.WriteLine(string.Join(",", result3));
            var result4 = new Program().solution(new int[] {}, 1000);
            Console.WriteLine(string.Join(",", result4));
            var result55 = new Program().solution(new int[] {1, 2, 3, 4}, 45);
            Console.WriteLine(string.Join(",", result55));
        }

        public int[] solution(int[] A, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var resultArray = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                var newIndex = GetNewIndex(K, i, A.Length);
                resultArray[newIndex] = A[i];
            }

            return resultArray.ToArray();
        }

        private static int GetNewIndex(int rotation, int originalIndex, int arraySize)
        {
            var newIndex = originalIndex + rotation;
            while (newIndex >= arraySize)
            {
                newIndex -= arraySize;
            }

            while (newIndex < 0)
            {
                newIndex += arraySize;
            }

            return newIndex;
        }
    }
}