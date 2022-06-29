using System;

namespace Ch5_Ex1_AnalyzingNumbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*  TODO: 
             *      1. Random array oluştur
             *      2. Oluşturduğun arrayin ortalamasını bul
             *      3. Oluşturduğun arrayi ortalama değere göre filtrele: ortalamadan büyük olanları al
             *          3.1. Filtrelenen elemanları tutacak olan dizinin boyutunu bul
             */
            var size = 5;
            int[] numbers = GetRandomArray(size);
            PrintArray(numbers);
            double avg = GetAverage(numbers);
            Console.WriteLine("avg: " + avg);
            int[] filtered = GetFilteredArray(numbers, avg);
            PrintArray(filtered);
           
        }

        private static int[] GetFilteredArray(int[] numbers, double avg)
        {
            int size = GetFilteredArraySize(numbers, avg);
            int[] filtered = new int[size];
            int i = 0;
            foreach (var number in numbers)
            {
                if (number > avg)
                {
                    filtered[i] = number;
                    i++;
                }
            }

            return filtered;
        }

        private static int GetFilteredArraySize(int[] numbers, double avg)
        {
            int size = 0;
            foreach (var number in numbers)
            {
                if (number > avg)
                    size++;
            }

            return size;
        }

        private static double GetAverage(int[] numbers)
        {
            double sum = 0;
            foreach (var e in numbers)
            {
                sum += e;
            }

            return sum / numbers.Length;
        }

        private static void PrintArray(int[] numbers)
        {
            foreach (var e in numbers)
            {
                Console.Write(e + ", ");
            }
            Console.WriteLine();
        }

        private static int[] GetRandomArray(int size)
        {
            Random random = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(20);
            }

            return arr;
        }
        
    }
}