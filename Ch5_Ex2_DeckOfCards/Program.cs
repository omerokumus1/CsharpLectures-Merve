using System;
using System.Diagnostics.Eventing.Reader;

namespace Ch5_Ex2_DeckOfCards
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution1();
        }

        private static void Solution1()
        {
            /*  TODO:
             *      1. 52 boyutunda bir array oluştur
             *      2. Array'i karıştır
             *      3. İlk 4 tanesini al
             *      4. Aldığın ilk 4 tane kartı düzgün formatta ekrana bastır (map, transformasyon, transformation)
             *          4.1. Her bir kartın suit'ini al
             *          4.2. Her bir kartın rank'ını al
             *          4.3. Her bir kartı rank ve suite göre ekrana bastır
             */

            int[] deck = GetDeckArray();
            ShuffleArray(deck);
            // PrintArray(deck);
            int cardCount = 4;
            int[] randomCards = GetRandomCards(deck, cardCount);
            PrintRandomCards(randomCards);
        }

        private static void PrintRandomCards(int[] randomCards)
        {
            foreach (var card in randomCards)
            {
                string suit = GetCardSuit(card);
                string rank = GetCardRank(card);
                Console.WriteLine(rank + " of " + suit);
            }
        }

        private static string GetCardRank(int card)
        {
            int rank = card % 13;
            switch (rank)
            {
                case 0: return "Ace";
                case 10: return "Jack";
                case 11: return "Queen";
                case 12: return "King";
                default: return (rank + 1) + "";
            }
        }

        private static string GetCardSuit(int card)
        {
            int range = card / 13;
            switch (range)
            {
                case 0: return "Spades";
                case 1: return "Hearts";
                case 2: return "Diamonds";
                case 3: return "Clubs";
                default: return "";
            }

            // return "";
        }

        private static int[] GetRandomCards(int[] deck, int cardCount)
        {
            int[] randomCards = new int[cardCount];
            for (int i = 0; i < cardCount; i++)
            {
                randomCards[i] = deck[i];
            }

            return randomCards;
        }

        private static int[] GetDeckArray()
        {
            int[] deck = new int[52];
            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = i;
            }

            return deck;
        }

        private static void PrintArray(int[] arr)
        {
            foreach (var number in arr)
            {
                Console.Write(number + ", ");
            }

            Console.WriteLine();
        }

        private static void ShuffleArray(int[] arr)
        {
            Random random = new Random();
            int index, temp;
            for (int i = 0; i < arr.Length; i++)
            {
                index = random.Next(arr.Length);
                temp = arr[i]; // 4 5 6
                arr[i] = arr[index]; // 6 5 6
                arr[index] = temp; // 6 5 4
            }
        }
    }
}