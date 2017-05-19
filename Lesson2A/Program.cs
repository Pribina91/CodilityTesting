using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2A
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Program().solution(new[] {1, 1, 2});
        }

        public int solution(int[] A)
        {
            var nonPairedValues = new HashSet<int>();
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            foreach (var itemValue in A)
            {
                if (nonPairedValues.Contains(itemValue))
                {
                    nonPairedValues.Remove(itemValue);
                    continue;
                }
                else
                {
                    nonPairedValues.Add(itemValue);
                }
            }

            if (!nonPairedValues.Any())
            {
                throw new Exception();
            }

            return nonPairedValues.First();
        }
    }
}