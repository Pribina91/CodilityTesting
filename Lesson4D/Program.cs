using System;
using System.Collections.Generic;
using System.Linq;
using Stopwatch;

namespace Lesson4D
{
    /// <summary>
    ///     MaxCounters
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",", new Program().solution(5, new[] {3, 4, 4, 6, 1, 4, 4})));
            Console.WriteLine(
                string.Join(
                    ",",
                    new Program().solution(
                        2,
                        Enumerable.Repeat(2, 150000).Concat(Enumerable.Repeat(1, 150000)).ToArray())));
            Console.WriteLine(string.Join(",", new Program().solution(2, Enumerable.Repeat(3, 150000).ToArray())));
            var randNum = new Random();
            Console.WriteLine(
                string.Join(
                    ",",
                    new Program().solution(
                        5,
                        Enumerable
                            .Repeat(0, 10000)
                            .Select(i => randNum.Next(1, 5))
                            .ToArray())));
            Console.WriteLine(
                string.Join(
                    ",",
                    new Program().solution(
                        5,
                        Enumerable
                            .Repeat(0, 1000000)
                            .Select(i => randNum.Next(1, 6))
                            .ToArray())));

            Console.WriteLine("-----PERFORMANCE TEST -----");
            var stopwatch = new LessonStopwatch();
            var program = new Program();
            for (int k = 0; k < 20; k++)
            {
                stopwatch.Execute(
                    () => program.solution(
                        5,
                        Enumerable
                            .Repeat(0, 10000)
                            .Select(i => randNum.Next(1, 5))
                            .ToArray()),
                    50);
            }
        }

        public int[] solution(int N, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var counters = new Dictionary<int, int>() { };
            var maxCounter = 0;
            var lastMaxCounter = 0;
            foreach (var item in A)
            {
                if (item == N + 1)
                {
                    lastMaxCounter = maxCounter;
                    continue;
                }

                if (!counters.ContainsKey(item))
                {
                    counters.Add(item, lastMaxCounter);
                }

                if (counters[item] < lastMaxCounter)
                {
                    counters[item] = lastMaxCounter;
                }

                counters[item]++;

                if (counters[item] > maxCounter)
                {
                    maxCounter = counters[item];
                }
            }

            //generate final array from counters remebering last value of last max counter to fill gaps in array
            var resultArray = new int[N];
            for (int i = 0; i < N; i++)
            {
                resultArray[i] = counters.ContainsKey(i + 1) && counters[i + 1] > lastMaxCounter
                    ? counters[i + 1]
                    : lastMaxCounter;
            }
            return resultArray;
        }
    }
}