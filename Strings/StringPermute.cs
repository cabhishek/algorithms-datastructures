using System;
using System.Text;

namespace CodingPractice.Strings
{
    public static class StringPermute
    {
        private static int len;

        public static void run()
        {
            char[] ip = "abc".ToCharArray();
            len = ip.Length;
            var op = new StringBuilder();
            var used = new bool[len];
            permute(ip, op, used, len, 0);
        }

        private static void permute(char[] ip, StringBuilder op, bool[] used, int len, int level)
        {
            if (level == len)
            {
                Console.WriteLine(op);
                return;
            }

            for (int i = 0; i < len; i++) //for every input value 
            {
                if (used[i]) continue; // if marked then skip

                op.Append(ip[i]); //append char 
                used[i] = true; // mark that char as used
                permute(ip, op, used, len, level + 1); // permute

                //back track
                used[i] = false; // unmark last used char as unused
                op.Length = op.Length - 1; // decrease op
            }
        }
    }
}