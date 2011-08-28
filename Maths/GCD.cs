using System;

namespace CodingPractice.Maths
{
    public static class GCD
    {
        public static void run()
        {
            Console.WriteLine(gcd(1071, 462));
        }

        private static int gcd(int a, int b)
        {
            if (b == 0) return a;
            return gcd(b, a%b);
        }
    }
}