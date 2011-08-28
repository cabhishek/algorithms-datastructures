using System;

namespace CodingPractice.Maths
{
    public static class GeneratePrimeNumbers
    {
        public static void run()
        {
            bool[] data = sieve(10);

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i])
                    Console.WriteLine(i);
            }
        }

        private static bool[] sieve(int n)
        {
            var prime = new bool[n];

            for (int i = 0; i < n; i++)
            {
                prime[i] = true;
            }

            prime[0] = false;
            prime[1] = false;

            double m = Math.Sqrt(n);

            for (int i = 2; i < m; i++)
            {
                if (prime[i])
                    for (int j = i*i; j < n; j = j + i)
                        prime[j] = false;
            }

            return prime;
        }
    }
}