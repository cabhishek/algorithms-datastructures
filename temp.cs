using System;

namespace CodingPractice
{
    public static class temp
    {
        private static int[] arr;

        public static void run()
        {
            arr = new[] {2, 3, 4, 5, 6, 7, 8, 9};
            Console.WriteLine(isThere(93, 0, arr.Length - 1));
        }

        private static bool isThere(int n, int low, int high)
        {
            if (low > high)
                return false;
            int mid = (low + high)/2;

            if (arr[mid] == n)
                return true;
            if (arr[mid] < n)
                low = mid + 1;
            if (arr[mid] > n)
                high = mid - 1;

            return isThere(n, low, high);
        }
    }
}