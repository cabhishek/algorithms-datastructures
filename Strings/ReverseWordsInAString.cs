using System;
using System.Linq;

namespace CodingPractice.Strings
{
    public static class ReverseWordsInAString
    {
        public static void run()
        {
            string[] words = "i like this program very much".Split(' ');
            reverseWords(words);
        }


        private static void reverseWords(string[] inputString)
        {
            for (int i = 0; i < inputString.Length; i++)
            {
                inputString[i] = reverse(inputString[i]);
            }

            Console.WriteLine(reverse(string.Join(" ", from data in inputString select data)));
        }

        private static string reverse(string input)
        {
            int low = 0;
            int high = input.Length - 1;
            char[] inputArray = input.ToCharArray();
            while (low < high)
            {
                char temp = inputArray[low];
                inputArray[low] = inputArray[high];
                inputArray[high] = temp;
                low++;
                high--;
            }

            return new string(inputArray);
        }
    }
}