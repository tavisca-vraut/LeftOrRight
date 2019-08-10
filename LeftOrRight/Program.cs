using System;

namespace LeftOrRight
{
    class Program
    {
        int MaxDistance(string program)
        {
            var canAllBeOneMove = new ReachMaximizer();
            var leftMax = canAllBeOneMove.GetMaxDistance(program.Replace('?', 'L'));
            var righMax = canAllBeOneMove.GetMaxDistance(program.Replace('?', 'R'));

            return Math.Max(leftMax, righMax);
        }

        static void Main(string[] args)
        {
            Program leftOrRight = new Program();
            String input = Console.ReadLine();
            do
            {
                Console.WriteLine(leftOrRight.MaxDistance(input));
                input = Console.ReadLine();
            } while (input != "-1");
        }
    }
}
