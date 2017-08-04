using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}:{1}", 1, new Program().solution(new []{4,2,2,5,1,5,8}));
            Console.WriteLine("{0}:{1}", 3, new Program().solution(new []{5,4,3,2,1}));
            Console.WriteLine("{0}:{1}", 3, new Program().solution(new []{5,4,3,2,1,3,3,}));
        }
        public int solution(int[] A)
        {
            int position = 0;
            double minAvg = GetAverage(A[position], A[position+1]);
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            for (int i = 0; i +1 < A.Length; i++)
            {
                //Mathematically we know that result can be only pair or tripple
                double? avgTripple = null;
                var avgPair = GetAverage(A[i], A[i + 1]);
                if (i + 2 < A.Length)
                {
                    avgTripple = GetAverage(A[i], A[i + 1], A[i + 2]);
                }

                var localAvg = avgTripple.HasValue ? Math.Min(avgPair, avgTripple.Value) : avgPair;

                if (minAvg > localAvg)
                {
                    minAvg = localAvg;
                    position = i;
                }
            }

            return position;
        }

        public double GetAverage(int A, int B, int? C = null)
        {
            if (C.HasValue)
            {
                return (A + B + C.Value )/ 3.0;
            }

            return (A + B) / 2.0;
        }
    }
}
