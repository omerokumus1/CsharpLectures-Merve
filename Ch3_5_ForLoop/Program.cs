using System;

namespace Ch3_5_ForLoop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // For döngüsü: while döngüsünden bir farkı yoktur. Sadece daha derli toplu bir yapı oluşturur.

            for (int i = 0; i < 10; i++)
                Console.WriteLine(i);
            
            
            // while to for
            // int i = 0; // for parantezlerindeki ilk statement
            // while (i < 10) // 2. statement
            // {
            //     Console.WriteLine(i);
            //     i++; // 3. statement
            // }
            
            // Ne zaman while?: sentinel controlled loop oluşturmak için while döngüsü daha kullanışlı
            // Ne zaman for?: counter controlled loop oluşturmak için for döngüsü daha iyi
            
            
            
            
            
        }
    }
}