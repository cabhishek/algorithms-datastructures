using System;

namespace CodingPractice.Maths
{
    public static class ToDecimal
    {
        public static void run()
        {
            Console.WriteLine(toDecimal(1011, 2));
            Console.WriteLine(fromDecimal(11, 2));
            Console.WriteLine(43/10);
            Console.WriteLine(43%10);
        }

        private static int toDecimal(int n, int b)
        {
            int result = 0;
            int multiplier = 1;

            while (n > 0)
            {
                result = result + n%10*multiplier;
                multiplier = multiplier*b;
                n = n/10;
            }

            return result;
        }

        private static int fromDecimal(int n, int b)
        {
            int result = 0;
            int multiplier = 1;

            while (n > 0)
            {
                result += n%b*multiplier;
                multiplier *= 10;
                n /= b;
            }

            return result;
        }
    }
}