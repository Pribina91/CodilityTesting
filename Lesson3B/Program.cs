using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Program().solution(10, 80, 100));
        }

        public int solution(int X, int Y, int D)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var result = Math.Ceiling((Y - X) / (double)D);
            return Convert.ToInt32(result);
        }
    }
}