using System;

namespace Ch5_3_ProcessingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //InitializeArrayWithInputValues();

            //int[] numbers = InitializeArrayWithRandomValues();
            //PrintArray(numbers);

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("sum: " + SumAllElements(numbers));

            int[] numbers = { 1, 7, 2, 3, 6, 9, 11, 25, 14, 10 };
            Console.WriteLine("max: " + FindLargestElement(numbers));
        }

        // 5. Finding the largest element
        public static int FindLargestElement(int[] arr)
        {
            int max = arr[0];
            foreach (var item in arr)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }

        // 4. Summing all elements
        public static int SumAllElements(int[] arr) // 1 2 3 4 5
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        // 2. Initializing arrays with random values
        public static int[] InitializeArrayWithRandomValues()
        {
            int[] numbers = new int[5];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(10); // [0 - 10)
            }
            return numbers;
        }

        // 1. Initializing arrays with input values:
        public static void InitializeArrayWithInputValues()
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter an integer: ");
                Int32.TryParse(Console.ReadLine(), out numbers[i]);
                Console.WriteLine();
            }
            PrintArray(numbers);
        }

        // 3. Print array
        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + ", ");
            }
        }
    }
}

