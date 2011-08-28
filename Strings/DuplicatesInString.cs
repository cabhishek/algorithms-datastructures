using System;

namespace CodingPractice.Strings
{
    internal static class DuplicatesInString
    {
        public static void run()
        {
            char[] str = "geeksforgeeks".ToCharArray();
            printDups(str);
        }

        public static void printDups(char[] str)
        {
            char[] counts = getCharCountArray(str);

            for (int i = 0; i < 256; i++)
            {
                if (counts[i] > 1)
                    Console.WriteLine(String.Format("count of {0} is {1}", (char) i, (int) counts[i]));
            }
        }

        private static char[] getCharCountArray(char[] input)
        {
            var output = new char[256];
            for (int i = 0; i < input.Length; i++)
            {
                output[input[i]]++; //core logic
            }

            return output;
        }
    }
}