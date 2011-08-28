using System;

namespace CodingPractice.Strings
{
    public static class RemoveChar
    {
        private static string ip;
        private static char removeChar;
        private static string op;
        private static int index;

        public static void run()
        {
            ip = "hleehllo";
            removeChar = 'l';
            Console.WriteLine(remove(ip));
        }


        private static string remove(string str)
        {
            if (str.Length == 0)
                return op;
            if (str[0] != removeChar)
                op += str[0];

            return remove(ip.Substring(++index)); // make sure u use original ip and not str
        }
    }
}