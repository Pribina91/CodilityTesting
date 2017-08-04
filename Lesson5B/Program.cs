using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}:{1}", 1, new Program().solution(2, 5, 3));
            Console.WriteLine("{0}:{1}", 2, new Program().solution(6, 11, 3));
            Console.WriteLine("{0}:{1}", 4, new Program().solution(6, 12, 2));
            Console.WriteLine("{0}:{1}", 6, new Program().solution(0, 10, 2));
            Console.WriteLine("{0}:{1}", 0, new Program().solution(3, 3, 2));
            Console.WriteLine("{0}:{1}", 0, new Program().solution(3, 3, 4));
            Console.WriteLine("{0}:{1}", 20, new Program().solution(11, 345, 17));
            Console.WriteLine("{0}:{1}", 0, new Program().solution(2, 14, 17));
            Console.WriteLine("{0}:{1}", 1, new Program().solution(2, 17, 17));
        }

        public int solution(int A, int B, int K)
        {
            //ShowDividers(A, B, K);

            // write your code in C# 6.0 with .NET 4.5 (Mono)

            var modA = A % K;

            var sum = B / K;
            if (modA == 0 || A == 0)
            {
                sum++;
            }

            sum -= A / K;
            return sum;
        }

        private void ShowDividers(int A, int B, int K)
        {
            Console.WriteLine($"______________________");
            Console.WriteLine($"test start: {A},{B},{K}");
            var diffToNextDiv = (K - (A % K)) % K;
            for (int o = A + diffToNextDiv, i = 1; o <= B; o += K, i++)
            {
                Console.WriteLine(i + ":" + o);
            }

            Console.WriteLine($"- - - - - - - ");
        }
    }
}
