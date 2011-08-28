using System;

namespace CodingPractice.Recursion
{
    public static class RecBinarySearch
    {
        private static int[] arr;

        public static void run()
        {
            arr = new[] {1, 2, 3, 4};
            Console.WriteLine(search(22, 0, arr.Length - 1));
        }

        private static bool search(int n, int start, int end)
        {
            if (start > end)
                return false;
            int mid = (start + end)/2;

            if (arr[mid] == n)
                return true;
            if (arr[mid] > n)
                start = mid + 1;
            if (arr[mid] < n)
                end = mid - 1;

            return search(n, start, end);
        }
    }
}