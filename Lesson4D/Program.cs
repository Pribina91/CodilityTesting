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
            Console.WriteLine(
                string.Join(
                    ",",
                    new Program().solution(
                        2,
                        Enumerable.Repeat(2, 150000).Concat(Enumerable.Repeat(1, 150000)).ToArray())));
            Console.WriteLine(string.Join(",", new Program().solution(2, Enumerable.Repeat(3, 150000).ToArray())));
            Console.WriteLine(string.Join(",", new Program().solution(5, new[] {3, 4, 4, 6, 1, 4, 4})));
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
                            .ToArray()));
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
                    var counterKeys = counters.Keys.AsParallel().ToArray();
                    //clearing dictionary
                    counters.Clear();
                    foreach (var key in counterKeys)
                    {
                        counters.Add(key, maxCounter);
                    }

                    lastMaxCounter = maxCounter;
                    continue;
                }

                if (!counters.ContainsKey(item))
                {
                    counters.Add(item, lastMaxCounter);
                }

                counters[item]++;

                if (counters[item] > maxCounter)
                {
                    maxCounter = counters[item];
                }
            }

            //generate final array from counters remebering last value of last max counter to fill gaps in array
            var resultArray = Enumerable.Repeat(lastMaxCounter, N).ToArray();
            foreach (var counter in counters)
            {
                resultArray[counter.Key - 1] = counter.Value;
            }

            return resultArray;
        }
    }
}