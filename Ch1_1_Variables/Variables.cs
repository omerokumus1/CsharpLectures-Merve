using System;

namespace CsharpLectures_Merve
{
    internal class Variables
    {
        public static void Main(string[] args)
        {
            // 1- declaration: bilgisayara bir şeyi tanıtmaktır.
            int x;
            int y;
            int k, l, m;
            
            // 2- Assignment: bir değişkene değer atamak, sağdan sola çalışır
            x = 3;
            y = 4;
            k = -2;
        
            double d, t, p;
            d = 3.12;
            t = -22.8;
            p = t;
            t = 3;
            t = p; // p = t 'den farklıdır.
            double q = -12.9;
            // 3.12 = d; // hatalı
            
        
            char c = ' ';
            string s = "C sharp programming is fun.";
            
            // int, double, char, string vb -> veri tipi
            // Declaration formula: <veri tipi> <değişken adı>; -> double aylıkGider;
        
            char c2 = '0';
            string s2 = "0";
            int i2 = 0;
            double d2 = 0;
            
            Console.WriteLine(c2);
            Console.WriteLine(s2);
            Console.WriteLine(i2);
            Console.WriteLine(d2);
        
            bool b = true;
            b = false;
        
            // Reusability
            
            // 3- constants: değiştirilemek, 1 kez tanımlanır
            const double pi = 3.14;
            // const int i3;  // hatalı; constant değer declare edilirken initialize edilmeli (assignment yapılmalı)
            // pi = 3;
        
            // 4- Escape sequences
            string s3 = "Kobe Bryant says \"Be the best version of yourself\"";
            Console.WriteLine(s3);
        
            char c3 = '\\';
            Console.WriteLine(c3);
            
            // new line: \n, tab: \t
            Console.WriteLine("new\nline");
            Console.WriteLine("tab\tline");
        
            // 5- Naming conventions
            // kısıtlamalar: değişkenler sayı ile başlayamaz, boşluk içeremez, tek başlarına sayı olamazlar.
            // int 1 = 3;
            // int 2d = 5;
            // int aylık ödeme = 1200;
            
            // camel case: kelimelerin ikincisinden başlanarak baş harfler büyük yazılır
            int monthlyPayment;
            double monthlyInterestRate;
            double annual_rate;
        
            t = 3;
        }
    }
}