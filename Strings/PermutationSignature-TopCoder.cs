using System;
using System.Linq;

namespace CodingPractice.Strings
{
    public static class PermutationSignature_TopCoder
    {
        public static void run()
        {
            Console.WriteLine(string.Join(",",reconstruct("IDI")));

        }

        public static int[] reconstruct(String signature)
        {
            int n = signature.Length + 1;
            if (n == 1)
            {
                /* Base case */
                // Empty signature, the result is {1}:
                return new[] { 1 };
            }
            // declare the res array
            var res = new int[n];
            // recurse to find the next array
            // which is the result permutation  for the suffix
            // of the signature.
            int[] next = reconstruct(signature.Substring(1));

            // Pick the necessary value of res[0]:
            res[0] = (signature[0] == 'D') ? (next[0] + 1) : 1;

            // Place the next values in the result array,
            // Values higher than res[0] must be incremented.
            for (int i = 1; i < n; i++)
            {
                res[i] = next[i - 1] + (next[i - 1] >= res[0] ? 1 : 0);
            }
            return res;
        }
    }
}