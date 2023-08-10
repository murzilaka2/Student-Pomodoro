using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro
{
    public static class Extensions
    {
        public static TimeSpan TotalTime(this List<Models.TaskObject> tasks)
        {
            if (tasks.Count < 1) return new TimeSpan(0, 0, 0);
            TimeSpan totalTime = new TimeSpan();
            foreach (var task in tasks)
            {
                totalTime += task.Time;
            }
            return totalTime;
        }
    }
}
