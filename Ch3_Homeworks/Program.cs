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

            
            
            // HW12
            
            // b. verilen bir karakteri tüm stringden sil
            //  Örn; "abbc" stringinden b karakterini silersen "ac" üretmeli
            str = "b abbc xy xby bb, xb";
            ch = 'b';
            newString = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str.ElementAt(i) != ch)
                {
                    newString += str.ElementAt(i);
                }
            }
            Console.WriteLine("HW12-b. newString: " + newString);
            
            // c. verilen bir karakterden verilen sayıda sil
            //  Örn; "abb bbc" stringinden b karakterini 2 kez silersen "a bbc" üretmeli
            //  var olan toplam verilen karakter sayısından daha fazla sayı verilirse tüm hepsini sil
            //  Örn; "abbc" stringinden b karakterini 3 kez silersen "ac" üretmeli
            str = "abb bbc";
            ch = 'b';
            newString = "";
            int removeCount = 0;
            int toBeRemovedCount = 20;
            for (int i = 0; i < str.Length; i++)
            {
                if (str.ElementAt(i) != ch || removeCount == toBeRemovedCount)
                {
                    newString += str.ElementAt(i);
                }
                else // elemanı alma
                {
                    removeCount++; // almadığın elemanları say
                }
            }
            Console.WriteLine("HW12-c. newString: " + newString);

            
            // d. verilen bir karakteri verilen bir indexten başlayıp verilen sayı kadar sil
            // Örn; "abb bbc" stringinden b karakterini 2. indexten itibaren 2 kez silersen "ab bc" üretmeli
            // indexten sonrası için var olan toplam sayıdan daha fazla sayı verilirse hepsini sil.
            // index kontrolü yap
            // verilenler
            str = "abb bbc";
            ch = 'b';
            toBeRemovedCount = 2;
            startIndex = 2;
            
            // benim değiştireceklerim
            newString = "";
            removeCount = 0;
            // startIndex'e kadar koşulsuz tüm karakteri al
            for (int i = 0; i < startIndex; i++)
            {
                newString += str.ElementAt(i);
            }
            // newString = str.Substring(0, startIndex);
            // startIndex'ten sonra koşullu seçmeye başla
            for (int i = startIndex; i < str.Length; i++)
            {
                if (str.ElementAt(i) != ch) // verilen karaktere eşit değilse direkt al
                {
                    newString += str.ElementAt(i);
                }
                else // verilen karaktere eşitse;
                {
                    if (removeCount == toBeRemovedCount) // eğer yeteri kadar eleman sildiysen bu karakteri dahil et
                    {
                        newString += str.ElementAt(i);
                    }
                    else // silmediysen bunu sil
                    {
                        removeCount++; // silinenleri say
                    }
                }
            }
            Console.WriteLine("HW12-d. newString: " + newString);
            
            
            // e. verilen bir karakterin hepsini verilen başka bir karakterle değiştir
            //     Örn; "abbc" stringinde b karakteri X ile değiştirirsen "aXXc" üretmeli
            str = "abbc";
            char chToBeChanged = 'b';
            ch = 'X';
            newString = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str.ElementAt(i) == chToBeChanged)
                {
                    newString += ch;
                }
                else
                {
                    newString += str.ElementAt(i);
                }
            }
            Console.WriteLine("HW12-e. newString: " + newString);
            
            // f. verilen bir karakteri verilen başka bir karakterle verilen sayı kadar değiştir
            // Örn; "abb bbc" stringinde b karakterini X ile 2 tane değiştirirsen "aXX bbc" üretmeli
            str = "abb bbc";
            chToBeChanged = 'b';
            ch = 'X';
            int toBeChangedCount = 2;

            newString = "";
            int changeCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str.ElementAt(i) != chToBeChanged || toBeChangedCount == changeCount)
                {
                    newString += str.ElementAt(i);
                }
                else
                {
                    newString += ch;
                    changeCount++;
                }
            }
            Console.WriteLine("HW12-f. newString: " + newString);
            
            
            // g. verilen bir karakteri verilen başka bir karakterle verilen bir indexten başlayıp verilen sayı kadar değiştir
            // Örn; "abb bbc" stringinde b karakterini 2. indexten başlayıp 2 tane değiştirirsen "abX Xbc" üretmeli
            str = "abb bbc";
            chToBeChanged = 'b';
            ch = 'X';
            startIndex = 2;
            toBeChangedCount = 20;
            newString = "";
            changeCount = 0;
            for (int i = 0; i < startIndex; i++)
            {
                newString += str.ElementAt(i);
            }

            for (int i = startIndex; i < str.Length; i++)
            {
                if (str.ElementAt(i) != chToBeChanged || changeCount == toBeChangedCount)
                {
                    newString += str.ElementAt(i);
                }
                else
                {
                    changeCount++;
                    newString += ch;
                }
            }
            Console.WriteLine("HW12-g. newString: " + newString);
        }
    }
}