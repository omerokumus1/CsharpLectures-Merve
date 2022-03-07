using System;

namespace Ch3_Exercise1_GuessingNumbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* Rastgele oluşturulan bir sayının bulunması oyunudur. Oyun sonunda Kullanıcının kaçında doğru bildiğini 
             * söyleyen bir program.
             */
            
            /* TODO:
             *      1. Rastgele bir sayı oluştur
             *      2. Kullanıcıdan input al.
             *          2.1. Eğer input ile oluşturulan rastgele sayı eşleşirse oyunu bitir
             *          2.2. Eğer eşleşmezse kullanıcıdan input almaya devam et. (döngü oluştur)
             *      3. Bir değişken oluştur. Kullanıcının kaçıncı denemede doğru bildiğini
             * 
             */
            
            // 1. Rastgele bir sayı oluştur
            Random random = new Random();
            int number = random.Next(10, 20);
            
            // 3. Bir değişken oluştur. Kullanıcının kaçıncı denemede doğru bildiğini
            int counter = 0;
            
            // 2. Kullanıcıdan input al.
            Console.WriteLine("Enter your guess in [10,20]");
            int guess;
            Int32.TryParse(Console.ReadLine(), out guess);
            counter++;
            int guessLimit = 5;
            // sentinel controlled loop çünkü döngünün bitmesi doğru tahminin yapılması olayına bağlıdır
            while (guess != number || counter != guessLimit) // 2.1. Eğer input ile oluşturulan rastgele sayı eşleşirse oyunu bitir
            { // 2.2. Eğer eşleşmezse kullanıcıdan input almaya devam et. (döngü oluştur)
                Console.WriteLine("Wrong. Enter your guess in [10,20] again");
                Int32.TryParse(Console.ReadLine(), out guess);
                counter++;
            }
            
            Console.WriteLine("Congrats! You guessed the number on " + counter + ". try");
 
            
        }
    }
}