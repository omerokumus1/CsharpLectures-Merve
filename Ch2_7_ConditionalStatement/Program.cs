using System;

namespace Ch2_7_ConditionalStatement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // bir değişkene if-else koşulları ile atama yapmaya çalıştığımızda conditional statement kullanılabilir.
            // Örn; aşağıda x > 0 ise y = x, değilse y = 0 olur. Burada hem if hem else içinde y değişkenine bir atama yapıyoruz.
            // Bu durumda conditional statement kullanılabilir
            int x = 3, y;
            if (x > 0)
                y = x;
            else
                y = 0;

            // ternary operator = conditional statement
            // yapısı: (koşul) ? doğru-olması-durumu (true-statement) : yanlış-olması-durumu (false-statement);
            y = (x > 0) ? x : 0;
            
            // Örnek: basit lottery programı: sayı bilinirse 10k, bilinmezse 0 kazanılır
            Random random = new Random(1);
            int lotteryNumber = random.Next(10, 20);
            Console.WriteLine("lottery number: " + lotteryNumber);
            int guess = 11;
            int reward;
            // if (guess == lotteryNumber)
            //     reward = 1000;
            // else
            //     reward = 0;

            reward = (guess == lotteryNumber) ? 1000 : 0;
            
            Console.WriteLine("You've earned $" + reward);
            
            
            // Conditional statement ile ekrana bir şey bastırmak
            // Aşağıdaki örneğe göre Koşul doğru ise conditional statement yerinde doğru olma durumu yani 1000 varmış gibi düşünülür,
            // yanlış ise yanlış-olma-durumu yani 0 varmış gibi düşünülür
            // koşul doğru ise: (guess == lotteryNumber) ? 1000 : 0 = 1000 (yerinde 1000 varmış gibi)
            // koşul yanlış ise: (guess == lotteryNumber) ? 1000 : 0 = 0 (yerinde 0 varmış gibi)
            Console.WriteLine((guess == lotteryNumber) ? 1000 : 0);
            

        }
    }
}