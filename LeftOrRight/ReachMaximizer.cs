using System;
using System.Collections.Generic;

namespace LeftOrRight
{
    public class ReachMaximizer
    {
        Dictionary<string, int> movement = new Dictionary<string, int>
        {
            { "L", -1 },
            { "R", +1 }
        };
        public int GetMaxDistance(string program)
        {
            int tracker = 0;
            int max = int.MinValue;
            foreach (var command in program)
            {
                tracker += movement[command.ToString()];
                max = Math.Max(max, Math.Abs(tracker));
            }
            return max;
        }
    }
}
