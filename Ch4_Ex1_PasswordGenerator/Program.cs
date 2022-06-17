using System;
using System.Linq;

namespace Ch4_Ex1_PasswordGenerator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* Password içeriği:
             *      - En az 8 uzunluğunda
             *      - En az 1 tane sayı
             *      - En az 1 tane büyük harf
             *      - En az 1 tane özel karakter
             *      - En az 2 tane küçük harf
             * 
             */

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 1) + ". password: " + GeneratePassword(14));
            }
        }

        public static string GeneratePassword(int passLength)
        {
            var password = GetNumber() + GetLowercaseLetter() + GetLowercaseLetter() + GetSpecialCharacter() +
                           GetUppercaseLetter();
            var random = new Random();
            for (var i = 0; i < passLength - 5; i++)
            {
                switch (random.Next(4))
                {
                    case 0:
                        password += GetNumber();
                        break;
                    case 1:
                        password += GetUppercaseLetter();
                        break;
                    case 2:
                        password += GetSpecialCharacter();
                        break;
                    case 3:
                        password += GetLowercaseLetter();
                        break;
                }
            }

            return ShuffleString(password);
        }

        public static string ShuffleString(string str)
        {
            var newStr = "";
            var str2 = str;
            var random = new Random();
            int index;
            for (int i = 0; i < str.Length; i++)
            {
                index = random.Next(str2.Length);
                newStr += str2.ElementAt(index);
                str2 = str2.Remove(index, 1);
            }

            return newStr;
        }

        public static string GetNumber()
        {
            var random = new Random();
            return random.Next(10).ToString();
        }

        public static char GetUppercaseLetter()
        {
            var uppercaseLetters = "ABCDEFGHIJKLMNOPRSTUVYZQWX";
            var random = new Random();
            return uppercaseLetters.ElementAt(random.Next(uppercaseLetters.Length));
        }

        public static char GetLowercaseLetter()
        {
            var lowercaseLetters = "abcdefghijklmnoprstuvyzqwx";
            var random = new Random();
            return lowercaseLetters.ElementAt(random.Next(lowercaseLetters.Length));
        }

        public static char GetSpecialCharacter()
        {
            var specialChars = "!+%&/()=?_-*";
            var random = new Random();
            return specialChars.ElementAt(random.Next(specialChars.Length));
        }
    }
}