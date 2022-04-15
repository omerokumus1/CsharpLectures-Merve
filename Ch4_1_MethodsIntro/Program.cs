using System;

namespace Ch4_1_MethodsIntro
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Math.Abs(-2);
            "abc".Remove('a');

            /* Fonksiyon avantajları
             *      1. Kodumuzu modülarize/organize eder
             *      2. Kodun okunulabilirliğini arttırır
             *      3. Code reusability artar (Kodun tekrar kullanılabilirliği)
             *      4. Kod üzerindeki kontrol artar
             *      5. Hatalar daha kolay bulunur
             *      6. Kodların birbirine olan bağımlılığı azalır
             */
            
            /*  İş terimi: Gerçek hayatta yaptığımız iş anlamına gelir. Örn; markete gitme işi,
             *      yemek yapma işi, ev temizleme işi, ödev yapma işi vs.
             *      Yazılımdaki örnekler;
             *          - bir stringden bir karakteri silme işi (Remove fonksiyonu)
             *          - Verilen bir stringi konsola yazma işi (Console.WriteLine)
             *          - Verilen bir sayının pozitifini alma işi (Math.Abs)
             *          - Verilen iki stringin aynı olup olmadığını kontrol etme işi (Equals)
             *
             *      İşler alt işlerden oluşabilir. Örn;
             *                      Ev temizleme işi = Bulaşık yıkama işi + evi süpürme işi 
             *      
             *  İş terimi ne işimize yarar?
             *      İşler methodlar yardımıyla halledilir. Bu sebeple eğerki bir iş yapılacaksa
             *      o işi yapan fonksiyon yazılmalı. Yani iş terimi ile ne zaman fonksiyon yazılmalı
             *      sorusuna cevap buluruz. 
             */
            
            /*  Fonksiyon isimlendirme kuralları
             *      - Her bir fonksiyon bir iş yapar. Bundan sebep Fonksiyonun adı yaptığı işin ne
             *          olduğunu tanımlamalı
             *      Örn; Remove -> silme işi yapar
             *          Math.Abs -> mutlak değer alır
             *          Math.Round -> sayıyı yuvarlar
             *          Math.Floor -> sayıyı alttaki tam sayıya yuvarlar
             *          Math.Pow -> sayıyının kuvvetini alır
             *
             *      - Fonksiyon isimleri fiil olmalıdır. (Her zaman değil)
             *          Örn;
             *              findUppercaseLetters(str) -> stringdeki büyük harfleri bulur
             *              findDigitsOf(str) -> stringdeki rakamları bulur
             */
        }
    }
}