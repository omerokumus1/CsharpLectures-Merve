using System;

namespace Ch2_4_RandomNumberGeneration
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            // Pozitif int sayı üretmek
            int number = random.Next(10); // 0-10 arası, 0 dahil 10 dahil değil
            Console.WriteLine("number: " + number);

            number = random.Next(10, 30); // 10-30 arası, 30 dahil değil

            // Negatif int sayı üretmek
            number = -random.Next(10);
            Console.WriteLine("number: " + number);

            // Double sayı üretmek
            double d = random.NextDouble(); // 0-1 arası
            Console.WriteLine("d: " + d);

            // aralığı genişletmek
            d = random.NextDouble() * 10; // 0-10 arası double


            // aralığı kaydırmak
            d = random.NextDouble() * 10 - 5; // -5 <= d < 5
            Console.WriteLine("-5 <= d < 5 " + d);

            // 0 <= d < 1 - *10 -> 0 <= d < 10 - -5 -> -5 <= d < 5
            // çarpma ile aralık genişletilir.
            // Toplama ile aralık kaydırılır: negatif sayı eklenirse sola kayar, pozitif sayı ise sağa kayar
            // Önce aralığın genişliğini bul: sağdaki sayıdan soldaki sayı çıkart: Örn; -10 ile 10 arasında sayı üretmek istiyorsan, aralık = 10 - (-10) = 20
            // Daha sonra kaydırma miktarını bul: soldaki sayı kaydırma miktarıdır: Örn; -10 ile 10 arasında sayı üretmek istiyorsan, kaydırma miktarı = -10

            d = random.NextDouble() * 20 - 10; // -10<= d < 10 
            Console.WriteLine("-10<= d < 10 " + d);

            // 13 <= d < 25: genişlik = 25-13=12, kaydırma miktarı = 13
            d = random.NextDouble() * 12 + 13;
            Console.WriteLine("13 <= d < 25 " + d);
            
            // Double sayıyı yuvarlayarak göstermek
            d = random.NextDouble() * 12 + 13;
            Console.WriteLine("13 <= d < 25 " + Math.Round(d, 3));
            
            // Seed: tohum demek -> kullanıldığında her seferinde aynı rastgele sayı üretilir
            Random r = new Random(1);
            number = r.Next(10);
            Console.WriteLine("seeded random: " + number);
            int n2 = r.Next(10);
            int n3 = r.Next(10);
            int n4 = r.Next(10);
            Console.WriteLine("n2: " + n2 );
            Console.WriteLine("n3: " + n3 );
            Console.WriteLine("n4: " + n4 );

        }
    }
}