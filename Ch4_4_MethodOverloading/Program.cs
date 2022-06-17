using System;

namespace Ch4_4_MethodOverloading
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* Method overloading
             *  İki farklı methodun imzaları (signature) farklı olmak zorundadır. imza = method adı + parametre listesi
             *  Aynı method ismiyle farklı methodlar üretmeye method overloading denir.
             *  Bunu yapabilmek için aynı isme sahip olan methodların parametre listelerinin farklı olması gerekir
             *  Parametre listesini farklı yapmak:
             *      1. Parametre sayısı farklı olmalı
             *      ya da
             *      2. En az 1 parametrenin tipi farklı olmalı
             *  Örn;
             *      public static void Add(int n1, int n2)
             *      public static void Add(double n1, double n2)
             *      public static void Add(int n1, int n2, int n3)
             *
             *  Method overloading neden var?
             *      - Bilgisayarın sahip olduğu karar mekanizmasından faydalanmak için overloading kullanılır
             *      - Bilgisayar parametre listesi ile uygun olan methodu kendisi seçebilir.
             *      - Parametrelere en uygun method çağırılır
             *
             *  Method overloading olmasaydı:
             *      Senaryo: Kullanıcıdan input alıp toplama işlemi yapılacak. 3 farklı durum var.
             *          1. durum: iki tane integer
             *          2. durum: 2 tane double
             *          3. durum: 3 tane integer
             *      - Method overloading kullanmadan çözüm:
             *          - Kaç parametre verildi kontrolü yapılmalı
             *          - Verilen parametrelerin tiplerinin kontrolü yapılmalı
             *          - Uyan method manuel olarak çağırılmalı
             *       
             */
            
            Add(3, 5);
            Add(3.2, 5.4);
            Add(3.0, 5);
            Add(3, 2.2);
            Add(3, 2, 4);
        }

        public static void Add(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }
        
        public static void Add(double n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }
        
        public static void Add(double n1, double n2)
        {
            Console.WriteLine(n1 + n2);
        }
        
        public static void Add(int n1, int n2, int n3)
        {
            Console.WriteLine(n1 + n2 + n3);
        }
        
    }
}