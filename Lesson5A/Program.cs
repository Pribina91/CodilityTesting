using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Program().solution(new int[] { 0,1,0,1,1 }));
            Console.WriteLine(new Program().solution(new int[] { 0,1,0,1,1,1 }));
            Console.WriteLine(new Program().solution(new int[] { 0,1,0,1,1,1,0 }));
            Console.WriteLine(new Program().solution(new int[] { 1,0,1,0,1,1,1,0 }));
            Console.WriteLine(new Program().solution(Enumerable.Repeat(0, 50000).Concat(Enumerable.Repeat(1, 50000)).ToArray()));

        }

        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            //prefix sums
            if (!A.Any())
            {
                throw new ArgumentException("Parameter empty", nameof(A));
            }

            int pairs = 0;
            int prefixSum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0) //east
                {
                    prefixSum++;
                }
                else // west based on precondition that A contains only 0 and 1
                //else if(A[i] == 1) // west
                {
                    pairs += prefixSum;
                }

                if (pairs > 1000000000)
                {
                    return -1;
                }
            }

            return pairs;
        }
    }
}
