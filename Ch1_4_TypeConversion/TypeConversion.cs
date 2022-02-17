using System;

namespace Ch1_4_TypeConversion
{
    internal class TypeConversion
    {
        public static void Main(string[] args)
        {
            // veri tipleri arasındaki dönüşüme casting/type conversion denir
            // Örn; int -> double, double -> string, boolean -> string, string -> char, char -> string, int -> char
            /* İki tip casting vardır.
             *      1. Implicit casting: Bilgisayar tip dönüşümünü kendisi halleder
             *      2. Explicit casting: Bilgisayar tip dönüşümünü kendisi halledemez, bizim halletmemizi bekler.
             *                              Halledilmezse hata verir
             */     
            
            // Implicit casting: int -> double
            int i1 = 5;
            double d1 = i1; // double kümesi int kümesi kapsadığı için int bir sayıyı double bir sayıya bilgisayar kendisi çevirebilir
                            // Her int bir double olduğu için dönüşüm sorunu yaşanmaz
            // Explicit casting: double -> int
            double d2 = 3.0;
            //int i2 = d2; // her double bir int olmadığı için dönüşüm sorunu yaşanır, bilgisayar kendisi karar veremez
            int i2 = (int)d2; // casting
            
            // diğer tipler -> string
            int i3 = 7;
            double d3 = 2.3;
            char c3 = 'c';
            bool b3 = true;
            string str1 = i3 + ""; // int -> string
            // str1.Length; -> string operasyonu ile tip dönüşümü testi yapılabilir
            string str2 = d3 + ""; // double -> string
            string str3 = c3 + ""; // char -> string
            string str4 = b3 + ""; // boolean -> string
            Console.WriteLine(str1);

            // Casting with Convert
            // Convert.ToBoolean();
            // Convert.ToChar();
            // Convert.ToDouble();
            // Convert.ToInt32();
            // Convert.ToString();

            char c4 = Convert.ToChar("C");
            char c5 = Convert.ToChar(5);
            double d4 = Convert.ToDouble("3,4");
            int i4 = Convert.ToInt32("3");
            int i5 = Convert.ToInt32('4');
            string str5 = Convert.ToString(3.14);
            
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(d4);
            Console.WriteLine(i4);
            Console.WriteLine(i5);
            Console.WriteLine(str5);
            
            
            // Type conversion'da veri kaybı
            double d6 = 3.12;
            int i6 = (int) d6;
            Console.WriteLine("i6: " + i6);

            double d7 = 3.12;
            int i7 = (int) Math.Pow(d7, 2);
            Console.WriteLine("d7 squared: " + Math.Pow(d7, 2));
            Console.WriteLine("i7: " + i7);

        }
    }
}