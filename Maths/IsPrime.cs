using System;

namespace CodingPractice.Maths
{
    public static class IsPrime
    {
        public static void run()
        {
            Console.WriteLine(isPrime(25));
        }

        private static bool isPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true; // lowest even rime number step 1
            if (n%2 == 0) return false;
            double m = Math.Sqrt(n); // this very imp all we need to check is if n is divisible by any number <= sqrt(n)

            for (int i = 3; i <= m; i += 2)
                //no is not divisible by 2 since it passed step1.. now that we have reached here keep trying with all odd numbers
                if (n%i == 0)
                    return false;

            return true;
        }
    }
}