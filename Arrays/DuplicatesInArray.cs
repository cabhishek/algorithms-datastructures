using System;

namespace CodingPractice
{
    internal static class DuplicatesInArray
    {
        public static void run()
        {
            int[] arr = {1, 3, 2, 5, 2, 1, 2, 2, 5, 6, 7, 6, 7, 8, 8, 8, 9, 9, 0};
            int arr_size = arr.Length;
            printRepeating(arr, arr_size);
        }

        private static void printRepeating(int[] arr, int size)
        {
            Console.WriteLine("The Repeating numbers are");

            for (int i = 0; i < size; i++)
            {
                if (arr[Math.Abs(arr[i])] > 0)
                {
                    arr[Math.Abs(arr[i])] = -arr[Math.Abs(arr[i])];
                }
                else
                {
                    Console.WriteLine(Math.Abs(arr[i]));
                }
            }
        }
    }
}