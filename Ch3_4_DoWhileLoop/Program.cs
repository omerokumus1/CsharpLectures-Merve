using System;

namespace Ch3_4_DoWhileLoop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // do-while loop
            // Temelde bir döngüdür. while döngüsünden farkı do-while döngüsünün en az 1 kere çalışıyor olmasıdır.
            // while döngüsü önce kontrol eder sonra çalıştırır. do-while döngüsü önce çalıştırır sonra kontrol eder
            // Bir kodun veya kod satırlarının en az 1 kere çalışmasını istiyorsak do-while kullanmalıyız


            int n;
            int loopCounter = 1;
            bool isCorrect = true;
            do
            {
                // if (loopCounter > 1)
                //     Console.WriteLine("Invalid Input. Try again.");
                
                if (!isCorrect)
                    Console.WriteLine("Invalid input. Try again.");
                Console.Write("Enter number: ");
                Int32.TryParse(Console.ReadLine(), out n);
                Console.WriteLine();
                // loopCounter++;
                isCorrect = false;
            } while (!(0 <= n && n <= 9));
            Console.WriteLine("Your number is " + n);

        }
    }
}