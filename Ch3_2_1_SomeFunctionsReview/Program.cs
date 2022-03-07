using System;
using System.Linq;

namespace Ch3_2_1_SomeFunctionsReview
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* 1- Math class: matematiksel işlemler yapmak istediğimizde Math classını kullanırız.
                            Kullanım: 
                                    a. Math yazıp noktaya basarak istenilen fonksiyon bulunabilir. Fonksiyon için gerekli parametrelerde burada gözükür.
                                    b. Kullanılan fonksiyon geriye değer döndürüyorsa bu değer bir değişkende tutulabilir
                            Örnek: Math.Round: yuvarlama yapar, Math.Max: büyük sayıyı bulur, Math.Floor: aşağı yuvarlar vs
            */

            // Kullanım a
            Console.WriteLine("Math.Max(4, 6): " + Math.Max(4, 6));

            // Kullanım b
            int min = Math.Min(4, 2);

            Console.WriteLine("Math.Round(Math.PI, 4): " + Math.Round(Math.PI, 4));
            Console.WriteLine("Math.Round(Math.PI): " + Math.Round(Math.PI));

            Console.WriteLine("Math.Sqrt(81): " + Math.Sqrt(81));

            Console.WriteLine("Math.Floor(3.11): " + Math.Floor(3.11));
            Console.WriteLine("Math.Floor(3.81): " + Math.Floor(3.81));
            Console.WriteLine("Math.Round(3.81): " + Math.Round(3.81));

            Console.WriteLine("Math.Ceiling(3.11): " + Math.Ceiling(3.11));
            Console.WriteLine("Math.Ceiling(3.81): " + Math.Ceiling(3.81));


            /*  2- Strings: Kendisi bir veri tipidir.
                        Kullanım: a. stringDeğişkeni.fonksiyon şeklinde kullanılır
                                  b. stringLiteral.fonkyon
                                  Fonksiyonlar geriye bir değer veriyorsa bir dğeişkene atanıp kullanılabilir
            */

            // Kullanım a
            string str1 = "C# Programming.";
            Console.WriteLine("str1.Length" + str1.Length);

            // Kullanım b
            int strLen = "Java Programming".Length; // stringteki karakter sayısını verir
            Console.WriteLine("strLen: " + strLen);

            // Contains boolean sonuç döndürür -> Boolean istenilen her yere yazılabilir. Örn; if, while içerisinde kullanılabilir. 
            Console.WriteLine("str1.Contains('C#'): " + str1.Contains("C#"));
            Console.WriteLine("str1.Contains('C++'): " + str1.Contains("C++"));

            if (str1.Contains("C#"))
                Console.WriteLine("Contains C#");

            // Equals
            if (str1.Equals("C# Programming."))
                Console.WriteLine("String is 'C# Programming'");


            // Insert
            string str2 = str1.Insert(3, "and Java ");
            Console.WriteLine("new string: " + str2);
            Console.WriteLine("old string: " + str1);


            // Replace
            str2 = str1.Replace(' ', '_');
            Console.WriteLine("new string: " + str2);
            Console.WriteLine("old string: " + str1);


            // Substring
            str2 = str1.Substring(3);
            Console.WriteLine("new string: " + str2);
            str2 = str1.Substring(0, 3);
            Console.WriteLine("new string: " + str2);


            // IndexOf and LastIndexOf 
            int ind = str1.IndexOf('#');
            Console.WriteLine("index of #: " + ind);
            Console.WriteLine("index of m: " + str1.IndexOf('m'));
            Console.WriteLine("Last index of m: " + str1.LastIndexOf('m'));


            // ElementAt
            Console.WriteLine("character at index 1: " + str1.ElementAt(1));
            Console.WriteLine("character at index 3: " + str1.ElementAt(3));
            Console.WriteLine("character at last index: " + str1.ElementAt(str1.Length - 1));

            // First and Last
            Console.WriteLine("character at last index: " + str1.Last()); // str1.ElementAt(str1.Length - 1) yerine bunu kullan
            Console.WriteLine("first character: " + str1.First()); // str1.ElementAt(0) yerine bunu kullan

            
            // Max and Min
            str1 = "123456789";
            Console.WriteLine("Max: "+str1.Max());
            Console.WriteLine("Min: "+str1.Min());

            
            
             /* 3- Char class: karakterler üzerinde işlem yapmak için kullanılır
                            Kullanım: Char.fonksiyon şeklinde kullanılır (Math class'ı gibi)
              */
             
             // IsDigit: boolean döndürür. If, while gibi yapılar içerisinde kullanılır
             Console.WriteLine("Char.IsDigit('1'): " + Char.IsDigit('1'));
             Console.WriteLine("Char.IsDigit('a'): " + Char.IsDigit('a'));

             str1 = "1. C#";
             if (Char.IsDigit(str1.First()))
                Console.WriteLine("First character is a digit");

             // IsLetter
             Console.WriteLine("Char.IsLetter('1'): " + Char.IsLetter('1'));
             Console.WriteLine("Char.IsLetter('b'): " + Char.IsLetter('b'));

             // IsUpper, IsLower, IsLetterOrDigit 
             
             
             // ToUpper and ToString
             string c = Char.ToUpper('c').ToString(); // fonksiyon zincirleme: ToString fonksiyonu Char.ToUpper fonksiyonunun sonucunun üzerine çağırılır
                            // 'C'.ToString() ile aynı anlama gelir. Çünkü Char.ToUpper('c') geriye 'C' döndürür.
             string x = Char.ToString(Char.ToUpper('x')); // Char.ToUpper fonksiyonunun sonucu Char.ToString fonksiyonunun girdisi olur
             
             
             //** değişkenAdı.fonksiyon -> değişken üzerine çağırılır
             //** ClassAdı.Fonksiyon -> fonksiyona değişken/arguman gönderilir
             //                                                                 diye okunurlar
        }
    }
}