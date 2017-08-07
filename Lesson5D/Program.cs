using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}:{1}", 1, string.Join(",", new Program().solution("CAGCCTA", new[] {2,5,0},new []{4,5,6})));
            Console.WriteLine("{0}:{1}", 2, string.Join(",", new Program().solution("CAGCCTA", new[] {2,2,0},new []{4,5,6})));
            //Console.WriteLine("{0}:{1}", 3, new Program().solution(new[] { 5, 4, 3, 2, 1 }));
            //Console.WriteLine("{0}:{1}", 3, new Program().solution(new[] { 5, 4, 3, 2, 1, 3, 3, }));
        }

        enum DnaSequenceLetter
        {
            A=1,
            C=2,
            G=3,
            T=4,
        }

        public int[] solution(string S, int[] P, int[] Q)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var lowerBounds = new Dictionary<int, NuclStorage>();

            for (int i = 0; i < P.Length; i++)
            {
                lowerBounds.Add(P[i],new NuclStorage()
                {
                    Index = i,
                    Start = P[i],
                    End = Q[i],
                    Minimum = null,
                });
            }

            var continuesLowValue = GetLetterValue(S[0]);
            var minValues = new List<NuclStorage>();
            var opened = new List<NuclStorage>();
            for (int i = 0; i < S.Length; i++)
            {
                var localValue = GetLetterValue(S[i]);
                if (lowerBounds.ContainsKey(i))
                {
                    opened.Add(lowerBounds[i]);
                }

                for (int k = opened.Count - 1, j = 0; k >= 0; k--,j++)
                    //foreach (var nucl in opened)
                {
                    if (!opened[k].Minimum.HasValue
                        || opened[k].Minimum.Value > localValue)
                    {
                        opened[k].Minimum = localValue;
                    }
                    if (opened[k].End == i)
                    {
                        minValues.Add(opened[k]);
                        opened.RemoveAt(k);
                    }
                }
            }

            return minValues.Select(m => m.Minimum.Value).DefaultIfEmpty(0).ToArray();
        }


        private int GetLetterValue(char letter)
        {
            return (int)Enum.Parse(typeof(DnaSequenceLetter), letter.ToString());
        }

        class NuclStorage
        {
            public int Start { get; set; }
            public int End { get; set; }
            public int? Minimum { get; set; }
            public int Index { get; set; }
        }

    }
}
