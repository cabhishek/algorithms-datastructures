using System;

namespace CodingPractice.TernaryTree
{
    public static class TernaryTreeRunner
    {
        public static void run()
        {
            var tree = new TernaryTree();
            tree.Add("ab");
            tree.Add("abba");
            tree.Add("abcd");
            tree.Add("bcd");

            Console.WriteLine(tree.Contains("aa"));
        }
    }
}