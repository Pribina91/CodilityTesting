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

        public void Execute(Action action)
        {
            _stopwatch.Restart();
            action();
            _stopwatch.Stop();
            Console.WriteLine(_stopwatch.ElapsedMilliseconds);
        }
    }
}