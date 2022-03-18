using System;
using System.Linq;

namespace Ch3_Homeworks
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // HW9:
            // c. verilen iki index ile alt string alan (substring methodu gibi)
            Console.WriteLine("HW9: c. verilen iki index ile alt string alan (substring methodu gibi)");
            string str = "C# programming is fun";
            string substr = "";
            int start = 3;
            int end = 700;
            // if (end >= str.Length)
            //     end = str.Length;
            //
            if (!(end >= str.Length) && !(start < 0))
            {
                for (int i = start; i < end; i++)
                    substr += str.ElementAt(i);
            
                Console.WriteLine("substr from 3 to 7 is " + substr);
                Console.WriteLine("str.substring(3,7): " + str.Substring(3, end-start));
            }
            else
                Console.WriteLine("end or start index is not valid");
            
            // Ek ödev: diğer tüm durumları kontrol ederek ekle: start end'den büyük olamaz, end start'tan küçük olamaz
            // tüm durumlar için olabilecek en açıklayıcı mesajları ver: Örn; start < 0 ve end > str.Length ise "end or start index is not valid" yazılacak
            //                                                               sadece start < 0 ise "start cannot be smaller than 0" 
                                                                            
            
                                                                            
            // HW10: iki stringin eşitliğini kontrol eden program
            Console.WriteLine("\nHW10: iki stringin eşitliğini kontrol eden program");
            string str1 = "tttta";
            string str2 = "ttttt";
            if (str1.Length == str2.Length)
            {
                bool areEqual = true;
                int str1Index = 0;
                for (int str2Index = 0; str2Index < str2.Length; str2Index++) 
                {
                    // en az 1 tane farklı eleman varsa bunlar aynı değildir
                    // fakat aynı olduklarını söylemek için bütün karakterleri kontrol etmek gerekir 
                    if (str1.ElementAt(str1Index) != str2.ElementAt(str2Index))
                    {
                        areEqual = false;
                        break; // en az 1 tane bulmak yeterli olduğu için gerisine bakmaya gerek yoktur
                    }
                    str1Index++;
                }

                if (areEqual)
                {
                    Console.WriteLine("str1 and str2 are equal");
                }
                else
                {
                    Console.WriteLine("str1 and str2 are not equal");
                }
            }
            else
            {
                Console.WriteLine("str1 and str2 are not equal");
            }
            // Ek ödev: akış diyagramı çiz (kendince çizmen yeterli) 
            
            
            // HW11: Verilen bir string için;
            // *a. verilen bir indexine verilen bir karakteri koy. 
            //      Örn; "abc" stringinin 1. indexine 'X' koyarsan "aXbc" üretmeli
            Console.WriteLine("\nHW11: Verilen bir string için;");
            Console.WriteLine("*a. verilen bir indexine verilen bir karakteri koy. ");

            str = "C# programming is fun.";
            int index = 5;
            char ch = 'X';
            string firstPart = "", lastPart = "";
            for (int i = 0; i < index; i++)
            {
                firstPart += str.ElementAt(i);
            }
            for (int i = index; i < str.Length; i++)
            {
                lastPart += str.ElementAt(i);
            }

            string newString = firstPart + ch + lastPart;
            Console.WriteLine("new string: " + newString);

            // 2. çözüm
            newString = "";
            for (int i = 0; i < index; i++)
            {
                newString += str.ElementAt(i);
            }
            newString += ch;
            for (int i = index; i < str.Length; i++)
            {
                newString += str.ElementAt(i);
            }
            Console.WriteLine("new string: " + newString);
            // kontrol
            Console.WriteLine("new string: " + str.Insert(5, "X"));

            // Ek ödev: index değişkenin değerlerini kontrol ederek hatalı durumları ayıkla. Hata mesajları duruma özgü basılması
            Console.WriteLine("\ne. verilen bir stringin sadece başındaki boşlukları sil");
            str = "  abc";
            Console.WriteLine("str:" + str);
            int startIndex = -1;
            // bool isFound = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str.ElementAt(i) != ' ') // ilk harfe kadar çalışır
                {
                    startIndex = i; // bulunan ilk harfın indexini tut
                    // isFound = true;
                    break; // gerisine bakmana gerek yok çünkü ilk harf bulundu
                }
            }

            newString = "";
            if (startIndex != -1)   // -1 değilse startIndex = i satırı çalışmış demektir. isFound gibi bir boolean değişken tutmaktan farkı yoktur.
            {
                for (int i = startIndex; i < str.Length; i++)
                {
                    newString += str.ElementAt(i);
                }
                Console.WriteLine("new string:" + newString);
            }
            else
            {
                Console.WriteLine("String has no character other than space");
            }
            
            // Ek ödev: Yukardaki programları debug modunda çalıştırıp takip edin. Bir sonraki çalışacak satırı tahmin etmeye çalışın

        }
    }
}