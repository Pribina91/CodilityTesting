using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Program().solution(new[] {3, 1, 2, 4, 3}));
            Console.WriteLine(new Program().solution(new[] {3, 5, 2, 4, -3}));
            Console.WriteLine(new Program().solution(new[] {-1, -244, 44}));
            Console.WriteLine(new Program().solution(new[] {-1000, 1000}));
        }

        public int solution(int[] A)
        {
            //var list = new List<int>();
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var totalSum = A.Sum();
            int leftPart = A[0];
            int rightPart = totalSum - A[0];
            var minimalDiff = Math.Abs(leftPart - rightPart);
            for (int i = 1; i < A.Length - 1; i++)
            {
                leftPart += A[i];
                rightPart -= A[i];
                var currentDiff = Math.Abs(leftPart - rightPart);
                //list.Add(currentDiff);
                //Console.WriteLine($"{i + 1}-{currentDiff}");
                if (minimalDiff > currentDiff)
                {
                    minimalDiff = currentDiff;
                }
            }

            //Console.WriteLine(string.Join(",", list));
            return minimalDiff;
        }
    }
}