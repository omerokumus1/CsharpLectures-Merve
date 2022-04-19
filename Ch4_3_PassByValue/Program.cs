using System;

namespace Ch4_3_PassByValue
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* Variable Scope: Değişkenlerin erişilebildiği aralıktır. Fonkiyonlarda tanımlı olan değişkenlere local değişken denir.
             *
             * PassByValue: Argumanların fonksiyonlara gönderilme biçimlerinden biridir. Argümanlar kopyalanarak gönderilir,
             *          yani orjinal değişken değil, o değişkenin kopyası gönderilir.
             *          Bu sebeple fonksiyon içerisinde yapılan değişiklik dışarıya yansımaz.
             */

            // Variable scope
            var x = 3; // x değişkenine tanımlandığı satırdan sonra Main fonksiyon içerisinde herhang bir yerde erişilebilir

            if (true)
            {
                var y = 3; // y değişkenine bu if bloğu dışında erişilemez
                x = 2; // x'in tanım aralığı main fonksiyon olduğundan ötürü burada erişim sağlanabilir
            }
            // y = 2; // hatalıdır, çünkü y değişkeni if bloğu içerisinde tanımlıdır

            while (x < 5)
            {
                // yukarda tanımlanan y değişkeninin tanım aralığı 14. satırdaki if bloğu içerisinde olduğundan dolayı
                // burada aynı isimde başka bir değişken tanımlayabiliriz. Çünkü, tanımlandığı if bloğu bittiğinde bu blok 
                // içerisinde tanımlanan tüm değişkenler ölür.
                var y = 2; // y değişkenine bu while bloğu dışında erişilemez
                x++;
            }
            // y = 2; // hatalıdır, çünkü y değişkeni while bloğu içerisinde tanımlıdır
            
            // else, else-if, for, do-while, fonksiyonlar gibi blok içeren bütün yapılarda bu durum aynıdır.
            
            // Blok belirleme: değişkeni kapsayan en küçük blok değişkenin tanımlandığı bloktur
            
            // PassByValue

            var n = 5;
            increment(n); // burada n değişkeninin değeri kopyalanıp increment fonksiyonundaki n parametresine atanır ve artık 2 tane n değişkeni olmuş olur
            Console.WriteLine("n after increment in main: " + n); // bu operasyon üstte tanımlı olan n'yi ekrana bastırır
            
        }

        public static void increment(int n) // buradaki n ile maindeki n değişkeni birbirinden alakasızdır
        {
            var x = 3; // local değişken 
            n += 1; // bu operasyon parametre olan n'yi arttırır, main'de tanımlı olan n ile bir alakası yoktur
            Console.WriteLine("n in increment: " + n); // bu operasyon parametre olan n'yi ekrana bastırır, maindekini değil
        } // fonksiyon işini bitirdikten sonra tüm parametreler ve local değişkenler ölür.
    }
}