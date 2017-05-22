using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Program().solution(new[] {1, 3, 4, 5}));
            Console.WriteLine(new Program().solution(new int[] {}));
        }

        public int solution(int[] A)
        {
            var searchSet = new HashSet<int>();
            for (int i = 1; i <= A.Length + 1; i++)
            {
                searchSet.Add(i);
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (searchSet.Contains(A[i]))
                {
                    searchSet.Remove(A[i]);
                }
            }

            if (searchSet.Count == 1)
            {
                return searchSet.First();
            }

            return A[0];
        }
    }
}