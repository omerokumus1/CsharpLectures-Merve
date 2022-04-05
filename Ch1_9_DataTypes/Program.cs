using System;
using System.Linq;

namespace Ch1_9_DataTypes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Overflow
            sbyte b1 = 100;
            sbyte b2 = 30;
            Console.WriteLine((sbyte)(b1 + b2));

            float f = 2.3f;
            
            // rounding error
            double d = 0.1f; 
            Console.WriteLine(d); // 0,100000001490116

            // char veri tipi
            char c = 'a';
            Console.WriteLine(c);
            Console.WriteLine((int)c);
            Console.WriteLine(97);
            Console.WriteLine((char)97);
            Console.WriteLine((char)109);
            Console.WriteLine('a' < 'b');

            string str = "JaVa 11";
            int uppercaseCount = 0, lowercaseCount = 0;
            char ch;
            for (int i = 0; i < str.Length; i++)
            {
                ch = str.ElementAt(i);
                if (97 <= ch && ch <= 122)
                {
                    Console.WriteLine("char: " + ch);
                    lowercaseCount++;
                }
                else if (65 <= ch && ch <= 90)
                {
                    Console.WriteLine("char: " + ch);
                    uppercaseCount++;
                }
            }
            Console.WriteLine("uppercase count: " + uppercaseCount + ", lowercase count: " + lowercaseCount);
            // char c5 = Convert.ToChar(33); -> neden '33' çıkartmıyor?
            char c5 = Convert.ToChar(33); // ascii table'de decimal sütununda 33'ün karşılığı neyse onu getirir
            Console.WriteLine(c5);
            // int i5 = Convert.ToInt32('4'); -> neden 52 çıkartıyor?
            int i5 = Convert.ToInt32('4')-48;
            Console.WriteLine(i5);

            char c1 = Convert.ToChar(0+48);
            Console.WriteLine(c1);
            
            /*  Value type vs reference type
             *      value type: değişkenin tuttuğu değeri direkt olarak verir.
             *          Örn; int x = 7; dediğimizde x'i ekrana bastırmak istersek 7 olarak basar
             *
             *      reference type: değişkenler memory'de (RAM) bir alana yerleştirilir. Bu alanlar 0 dan başlayarak
             *          isimlendirilen alanlardır. reference type ise oluşturduğumuz değişkeni hangi alanda olduğunu bize söyler
             *          Örn; x değişkeni oluşturduk diyelim. C# ramde bize bir yer bulup x'in değerini, 7 olsun, oraya koyar.
             *              Diyelimki koyduğu yerin numarası (adres değeri) 2. x değişkeni 2 değerine sahip olur yani memory'de
             *              hangi adrese koyulduğunu tutar.
             *
             *      pointer: reference type değerin nereye koyulduğunu gösterir (point eder). Nereye koyulduğunu gösterdiğinden
             *          ötürü özel olarak pointer (gösterici) adını alır.
             *          Örn; x reference tipinin değeri 2 ise, "x pointer'ı 2 numaralı adresi gösteriyor" diye söylenir
             */
            
            /*  null: 0, boşluk, hiçlik gibi anlamlara gelir. reference yoksa null olarak atanır. reference tipinin default
             *      değeri null'dur. Bu şu demek; C# kullanmak için bize bir adres vermedi yani memory'deki kutuların hangisine
             *      koyulacağı henüz belli değil.
             *      pointer'ın hiçbir şey göstermemesi demektir.
             * 
             * 
             */
            // nullable types: soru işareti ile oluşturulur. null değer alabilir. Örn; int?, double?, bool?
            int? i3 = null; // int? reference tiptir
            int? i2 = 55;
            Console.WriteLine(i2);
            Console.WriteLine(i2.Value);
            Console.WriteLine(i2.HasValue);
            
            // operators: as, is, typeof, ??, sizeof
            // as: type conversion yapar, tip dönüşümü yapılmazsa null döndürür
            // is: type check yapar. 
            Console.WriteLine("5 is int: " + (5 is int));
            Console.WriteLine("true is int: " + (true is int));
            Console.WriteLine("true is bool: " + (true is bool));
            
            // typeof: veri tipinin asıl tipini döndürür
            Console.WriteLine(typeof(int));

        }
    }
}