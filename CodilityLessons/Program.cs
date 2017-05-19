using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodilityLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().solution(16);
            new Program().solution(8);
        }

        public int solution(int N)
        {
            Console.WriteLine(Convert.ToString(N, 2));

            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var maxBinaryGap = 0;
            var currentGap = 0;
            foreach (var bit in Convert.ToString(N, 2))
            {
                if (bit == '0')
                {
                    currentGap++;
                }
                else
                {
                    if (currentGap > maxBinaryGap)
                    {
                        maxBinaryGap = currentGap;
                    }
                    currentGap = 0;
                }
            }

            return maxBinaryGap;
        }
    }
}