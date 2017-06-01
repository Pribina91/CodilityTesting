using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    public class LessonStopwatch
    {
        private System.Diagnostics.Stopwatch _stopwatch;

        public LessonStopwatch() : base()
        {
            _stopwatch = new System.Diagnostics.Stopwatch();
        }

        public void Execute(Action action, int iterations)
        {
            _stopwatch.Restart();
            for (int i = 0; i < iterations; i++)
            {
                action();
            }
            _stopwatch.Stop();
            Console.WriteLine(_stopwatch.ElapsedMilliseconds);
        }
    }
}