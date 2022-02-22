using System;

namespace Ch2_2_IfStatements
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 1- If statements

            /* If Structure
            if (boolean-expr)
            {
                // do something
            }
            */

            // Console.WriteLine("Enter a number");
            // int i;
            // Int32.TryParse(Console.ReadLine(), out i);
            // if (i < 10)
            // {
            //     Console.WriteLine("The number is smaller than 10.");
            // }
            //
            // if (i >= 10)
            // {
            //     Console.WriteLine("The number is bigger than or equal to 10.");
            // }
            //             
            // Console.WriteLine("Program ends.");

            // Console.WriteLine("Enter a number");
            // int i;
            // Int32.TryParse(Console.ReadLine(), out i);
            //
            // if (i % 2 == 0)
            // {
            //     Console.WriteLine("The number is even.");
            // }
            //
            // if (i % 2 != 0)
            // {
            //     Console.WriteLine("The number is odd.");
            // }

            // Peşpeşe yazılan if statement'ları birbirinden bağımsızdır


            // 2- Nested if statements: iç içe if yazmaktır, koşulları birbirine bağlar
            int x = 7, y = 1, z = 5;

            if (x > y)
            {
                Console.WriteLine("x is greater than y");
                if (x > z)
                {
                    Console.WriteLine("x is also greater than z");
                }
            }

            // Ex: verilen inputun hem 5'in hem de 4'ün bir katı olup olmadığını kontrol eden program
            // Console.WriteLine("Enter a number");
            // int i;
            // Int32.TryParse(Console.ReadLine(), out i);
            //
            // if (i % 5 == 0)
            // {
            //     Console.WriteLine("i is divisible by 5.");
            //     if (i % 4 == 0)
            //     {
            //         Console.WriteLine("i is divisible by 4 as well.");
            //     }
            // }


            // 3- if else statements
            // Ex: girilen sayının çift ya da tek olduğunu bulan program
            // Console.WriteLine("Enter a number");
            // int i;
            // Int32.TryParse(Console.ReadLine(), out i);
            // if (i % 2 == 0)
            // {
            //     Console.WriteLine("The number is even.");
            // }
            // else
            // {
            //     Console.WriteLine("The number is odd.");
            // }

            // if else yapısı birbirine bağlıdır. if içerisindeki expression true gelirse program direkt olarak else bloğunun sonuna atlar;
            // false gelirse direkt else bloğu çalışır
            // Yukarıda if else ile yazılan çift sayı bulma örneği ile daha yukarıdaki if if ile yazılan örnek arasındaki fark şudur; if if ile yazılanda bilgisayar 2 kontrol
            // yaparken if else ile yapılanda tek kontrol yapar çünkü if else birbirine bağlıdır fakat if if bağlı değildir.


            // 4- if else-if else statements
            // Ex: öğrenci puanı input olarak alınsın, puanın değerine göre A, B, C gibi sonuçlar ekrana basılsın.
            Console.WriteLine("Enter student score");
            int score;
            Int32.TryParse(Console.ReadLine(), out score);
            if (score >= 90)
                Console.WriteLine("A"); // -> tek satır var ise süslü paranteze ihtiyacımız yok
            else if (score >= 80)
                Console.WriteLine("B");
            else if (score >= 70)
                Console.WriteLine("C");
            else if (score >= 60)
                Console.WriteLine("D");
            else // -> Yukarıdaki koşullardan hiçbiri gerçekleşmezse burası çalışır
                Console.WriteLine("F");
            // if doğru çalışırsa diğer else if blokları çalışmadan buraya atlar. Veya herhahangi bir else if bloğu çalışırsa yine buraya gelir
            // bir else if bloğunun çalışması için kendisinin true yukarısındaki if ve else if blokları false gelmelidir.
            // yukarıdaki if else if ve else blokları birbirine bağlıdır. Bir if-else zinicir oluşur.
            // else bloğu zorunlu değildir, yazılmasa da olur
            
            
        }
    }
}