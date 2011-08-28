using System;

namespace CodingPractice
{
    public static class ShuffleCards
    {
        public static void run()
        {
            var cards = new int[52];
            for (int i = 0; i < cards.Length; i++)
            {
                cards[i] = i;
            }

            shuffle(cards);
            Console.WriteLine(string.Join(",", cards));
        }

        private static void shuffle(int[] cards)
        {
            var rand = new Random();

            for (int i = cards.Length - 1; i > 0; i--)
            {
                int n = rand.Next(i + 1);
                int temp = cards[i];
                cards[i] = cards[n];
                cards[n] = temp;
            }
        }
    }
}