using System;

namespace LeftOrRight
{
    class Program
    {
        int MaxReach(string program)
        {
            int max = int.MinValue;
            int c = 0;

            foreach (var command in program)
            {
                if (command =='L') c--;
                else c++;

                max = Math.Max(max, Math.Abs(c));
            }

            return max;
        }


        int MaxDistance(string program)
        {
            if (program.Contains('?') == false)
                return MaxReach(program);

            return Math.Max(MaxReach(program.Replace('?', 'L')), MaxReach(program.Replace('?', 'R')));
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
