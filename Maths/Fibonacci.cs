using System;

namespace CodingPractice.Maths
{
    public static class Fibonacci
    {
        public static long fib(int n)
        {
            if (n <= 1) return n;
            else return fib(n - 1) + fib(n - 2);
        }

        public static void run()
        {
            int N = 7;
            for (int i = 1; i <= N; i++)
                Console.WriteLine(i + ": " + fib(i));
        }
    }
}