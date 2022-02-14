using System;

namespace CsharpLectures_Merve
{
    public class Arithmetic
    {
        public static void Main(string[] args)
        {
            // 1- operatörler: +, -, /, *, %
            
            Console.WriteLine(3+4);
            Console.WriteLine(3-4);
            Console.WriteLine(3*4);
            
            Console.WriteLine(12 % 5);
            
            // bir sayının çift olup olmadığını bulmak
            Console.WriteLine(7 % 2);
            
            // bölünebilme kuralları ile daha hızlı sonuçlar üretilebilir.
            
            // Bölme işlemi 2 tanedir
            // 1- integer division: tam sayı bölmesi, virgülden sonrasını sıfır verir: iki integer sayıyı bölersen sonucu integer bulursun
            // 2- double division: ondalıklı bölme, virgülden sonrasını tam verir: en az bir tanesi double ise sonuç double olur.

            // integer division example 
            int i1 = 4, i2 = 6;
            Console.WriteLine(i2 / i1);
            
            // double division example-1 
            double d1 = 4, d2 = 6;
            Console.WriteLine(d2 / d1);

            // double division example-2
            int i3 = 4;
            double d3 = 6;
            Console.WriteLine(d3 / i3);
            
            // double division example-3
            //Console.WriteLine(1/3); -> integer division olur: nokta yoksa bilgisayar integer olarak kabul eder (1, 3, -7 ..)
              Console.WriteLine(1.0/3);  // double division -> nokta olduğu için double olarak kabul eder, double division olur
              Console.WriteLine(1/3.0);  // double division
            
            // 2- operator precedence (işlem önceliği)
            // çarpma bölme önce gelir, toplama çıkartma sonra gelir
            // parantez varsa önce parantez içi yapılır
            // çarpma bölme veya toplama çıkartma arasında öncelik soldan sağa olacak şekilde ayarlanır
            
            Console.WriteLine(6 / 3 * 2); // burada önce 6 / 3 yapılır
            
            // 3- Math class
            Console.WriteLine("abs");
            Console.WriteLine(Math.Abs(-7));
            Console.WriteLine(Math.Abs(4 - 7 * 3));
            
            Console.WriteLine("max, ceiling, floor");
            Console.WriteLine(Math.Max(3.8, 2));
            Console.WriteLine(Math.Ceiling(3.7));
            Console.WriteLine(Math.Floor(3.7));
            
            Console.WriteLine("round");
            Console.WriteLine(Math.Round(3.7));
            Console.WriteLine(Math.Round(3.4));
            
            Console.WriteLine("sqrt and pow");
            Console.WriteLine(Math.Sqrt(4));
            Console.WriteLine(Math.Pow(4, 3));
            
            Console.WriteLine("pow for root");
            Console.WriteLine(Math.Pow(64, 1.0/3));
        }
    }
}