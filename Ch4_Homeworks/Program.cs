using System;
using System.Data.OleDb;
using System.Linq;
using System.Security.AccessControl;

namespace Ch4_Homeworks
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // HW16.7- Java exercise 3.9'daki soruyu fonksiyon ile yaz (ISBN)
            /*
             * (Business: check ISBN-10) An ISBN-10 (International Standard Book Number)
                consists of 10 digits: d1d2d3d4d5d6d7d8d9d10. The last digit, d10, is a checksum,
                which is calculated from the other nine digits using the following formula:
                (d1 * 1 + d2 * 2 + d3 * 3 + d4 * 4 + d5 * 5 +
                d6 * 6 + d7 * 7 + d8 * 8 + d9 * 9) % 11
                If the checksum is 10, the last digit is denoted as X according to the ISBN-10
                convention. Write a program that prompts the user to enter the first 9 digits and
                displays the 10-digit ISBN (including leading zeros). Your program should read
                the input as an integer.
             */

            /*  TODO:
             *      1. Fonksiyon ile input al
             *      2. Fonksiyon ile ISBN hesapla
             * 
             */

            // var digits = GetDigitsFromConsole();
            // var isbn = CalculateIsbn(digits);
            // Console.WriteLine("isbn: " + isbn);
            //013601267 -> 0136012671
            //013031997 -> 013031997X

            /*
             * HW16.4- Rastgele bir ay üreten bir fonksiyon yaz. Her çalıştırıldığında farklı bir ay ekrana yazılacak. Örn; Ocak, Temmuz gibi aylar.
                    public static void randomMonth()
             */
            // RandomMonth();


            // HW17.11- Capitalize turkish letters, lower others fonksiyonu yaz
            var str = "GÖkTuğ Işık";
            CapitalizeTurkishLettersLowerOthers(str);

            /*
                HW19.2- Replace string: verilen bir stringi verilen başka bir string ile değiştir. Sadece ilk eşleşme için değişim olacak
                Örn; ab--ab--ab stringinde ab stringini xd ile değişirsek xd--ab--ab olur
             */
            str = "--ac--ab--abc";
            var oldStr = "abc";
            var newStr = "xd";
            ReplaceFirstString(str, oldStr, newStr);
        }

        private static void ReplaceFirstString(string str, string oldStr, string newStr)
        {
            var str2 = "";
            var startIndex = -1;
            var isFound = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str.ElementAt(i).Equals(oldStr.First()))
                {
                    isFound = true;
                    // var k = i; // iç içe döngülerde içteki döngü dışardaki döngülerin döngü değişkenini değiştirmemeli (çoğu zaman*)
                    for (int j = 0, k = i; j < oldStr.Length; j++, k++)
                    {
                        if (!str.ElementAt(k).Equals(oldStr.ElementAt(j)))
                        {
                            isFound = false;
                            break;
                        }
                    
                        // k++;
                    }

                    var substr = str.Substring(i, oldStr.Length);
                    isFound = substr.Equals(oldStr);
                    // if (substr.Equals(oldStr))
                    // {
                    //     startIndex = i;
                    //     break;
                    // }
                }

                if (isFound)
                {
                    startIndex = i;
                    break;
                }
            }
            for (int i = 0; i < startIndex; i++)
                str2 += str.ElementAt(i);
            str2 += newStr;
            for (int i = startIndex + oldStr.Length; i < str.Length; i++)
                str2 += str.ElementAt(i);
            
            Console.WriteLine("new string: " + str2);
        }

        public static void CapitalizeTurkishLettersLowerOthers(string str)
        {
            var lowercaseTurkishLetters = "çğıöşü";
            var uppercaseTurkishLetters = "ÇĞIÖŞÜ";
            char ch;
            var newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                ch = str.ElementAt(i);
                if (lowercaseTurkishLetters.Contains(ch))
                    newStr += Char.ToUpper(ch);
                else if (uppercaseTurkishLetters.Contains(ch))
                    newStr += ch;
                else
                    newStr += Char.ToLower(ch);
            }

            Console.WriteLine(newStr);
        }

        public static void RandomMonth()
        {
            Random random = new Random();
            var number = random.Next(1, 13);
            switch (number)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                case 7:
                    Console.WriteLine("Temmuz");
                    break;
                case 8:
                    Console.WriteLine("Ağustos");
                    break;
                case 9:
                    Console.WriteLine("Eylül");
                    break;
                case 10:
                    Console.WriteLine("Ekim");
                    break;
                case 11:
                    Console.WriteLine("Kasım");
                    break;
                case 12:
                    Console.WriteLine("Aralık");
                    break;
            }
        }

        public static string CalculateIsbn(string digits)
        {
            var sum = GetSum(digits);
            var lastChar = GetLastChar(sum);
            return digits + lastChar;
        }

        public static char GetLastChar(int sum)
        {
            char lastChar;
            var lastDigit = sum % 11;
            if (lastDigit == 10)
                lastChar = 'X';
            else
                lastChar = IntToChar(lastDigit);
            // lastChar = lastDigit == 10 ? 'X' : IntToChar(lastDigit);
            return lastChar;
        }

        public static char IntToChar(int n)
        {
            return Convert.ToChar(n + 48);
        }

        public static int GetSum(string digits)
        {
            var sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += CharToInt(digits.ElementAt(i)) * (i + 1);
            }

            return sum;
        }

        public static int CharToInt(char ch)
        {
            return Convert.ToInt32(ch) - 48;
        }

        public static string GetDigitsFromConsole()
        {
            string digits;
            do
            {
                Console.WriteLine("Enter 9-digit number: ");
                digits = Console.ReadLine();
                if (digits.Length != 9)
                {
                    Console.WriteLine("Enter only 9 digits");
                }
            } while (digits.Length != 9);

            return digits;
        }
    }
}