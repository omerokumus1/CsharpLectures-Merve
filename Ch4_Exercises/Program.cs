using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Xsl;

namespace Ch4_Exercises
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Substring
            Console.WriteLine("Substring");
            var str = "I love C# programming.";
            var startIndex = -2;
            var endIndex = 52;
            string substr = Substring(str, startIndex, endIndex);
            Console.WriteLine("substr: " + substr);

            // StartsWith
            Console.WriteLine("\nStartsWith");
            var startWith = "I love C# programming.I love C# programming.I love C# programming.";
            if (StartsWith(str, startWith))
                Console.WriteLine(str + " starts with " + startWith);
            else
                Console.WriteLine(str + " does not start with " + startWith);


            // EndsWith
            Console.WriteLine("\nEndsWith");
            var endWith = "ming.";
            if (EndsWith(str, endWith))
                Console.WriteLine(str + " ends with " + endWith);
            else
                Console.WriteLine(str + " does not end with " + endWith);


            // IndexOf
            Console.WriteLine("\nIndexOf");
            var ch = 'm';
            int index = IndexOf(str, ch, false);
            if (index == -1)
                Console.WriteLine(str + " does not contain " + ch);
            else
                Console.WriteLine("Index of '" + ch + "' in '" + str + "' is " + index);


            // LastIndexOf
            Console.WriteLine("\nLastIndexOf");
            ch = 'm';
            index = LastIndexOf(str, ch, true);
            if (index == -1)
                Console.WriteLine(str + " does not contain " + ch);
            else
                Console.WriteLine("Last index of '" + ch + "' in '" + str + "' is " + index);


            // Equals
            Console.WriteLine("\nEquals");
            var str2 = "I love C# programMing.";
            if (Equals2(str, str2, true))
                Console.WriteLine("'" + str + "\' equals \'" + str2 + "'");
            else
                Console.WriteLine("'" + str + "\' does not equal \'" + str2 + "'");


            // Insert character
            Console.WriteLine("\nInsert character");
            ch = 'X';
            var indexToInsert = 0;
            InsertCharacter(str, indexToInsert, ch);

            // Remove a character at an index
            Console.WriteLine("\nRemove a character at an index");
            index = str.Length;
            RemoveCharacterByIndex(str, index);
        }

        private static void RemoveCharacterByIndex(string str, int index)
        {
            // Çözüm-1: 1. parçayı al, karakteri atla 2. parçayı al, 1.parça + 2.parça olarak ekrana bastır
            // Çözüm-2: 1. parçayı al, karakteri atla, 2.parçayı 1. parçaya ekle

            // Çözüm-1
            var part1 = "";
            var part2 = "";
            for (int i = 0; i < index; i++)
                part1 += str.ElementAt(i);

            for (int i = index + 1; i < str.Length; i++)
                part2 += str.ElementAt(i);

            var removedString = part1 + part2;
            Console.WriteLine("Removed string: " + removedString);
        }

        private static void InsertCharacter(string str, int indexToInsert, char ch)
        {
            // Çözüm-1: 1. parçayı al, 2. parçayı al 1.parça + ch + 2.parça olarak ekrana bastır
            // Çözüm-2: 1. parçayı al, karakteri ekle, 2.parçayı karakter eklenmiş stringe ekle

            // Çözüm-1
            var part1 = "";
            var part2 = "";
            for (int i = 0; i < indexToInsert; i++)
                part1 += str.ElementAt(i);

            for (int i = indexToInsert; i < str.Length; i++)
                part2 += str.ElementAt(i);

            var insertedStr = part1 + ch + part2;
            Console.WriteLine("inserted string: " + insertedStr);
        }

        private static bool Equals2(string str, string str2, bool caseSensitive)
        {
            if (str.Length != str2.Length)
                return false;

            if (!caseSensitive)
            {
                str = str.ToLower();
                str2 = str2.ToLower();
            }

            var result = true;
            char ch1, ch2;
            for (int i = 0; i < str.Length; i++)
            {
                ch1 = str.ElementAt(i);
                ch2 = str2.ElementAt(i);
                if (!ch1.Equals(ch2))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        private static int LastIndexOf(string str, char ch, bool caseSensitive)
        {
            if (!caseSensitive)
            {
                str = str.ToLower();
                ch = Char.ToLower(ch);
            }

            var index = -1;
            char currentChar;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                currentChar = str.ElementAt(i);
                if (currentChar.Equals(ch))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        private static int IndexOf(string str, char ch, bool caseSensitive)
        {
            if (!caseSensitive)
            {
                str = str.ToLower();
                ch = Char.ToLower(ch);
            }

            var index = -1;
            char currentChar;
            for (int i = 0; i < str.Length; i++)
            {
                currentChar = str.ElementAt(i);
                if (currentChar.Equals(ch))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        private static bool EndsWith(string str, string endWith)
        {
            if (endWith.Length > str.Length)
                return false;

            var result = true;
            char ch1, ch2;
            var i = str.Length - 1;
            var j = endWith.Length - 1;
            // İki string için ortak döngü açılıyorsa kısa olan string kısıtlayıcı olmalı. Bundan sebep j değişkenine
            // göre döngü çalışmaya devam etmeli
            while (j >= 0)
            {
                ch1 = str.ElementAt(i);
                ch2 = endWith.ElementAt(j);
                if (!ch1.Equals(ch2))
                {
                    result = false;
                    break;
                }

                i--;
                j--;
            }

            return result;
        }

        private static bool StartsWith(string str, string startWith)
        {
            if (startWith.Length > str.Length)
                return false;

            var result = true;
            char ch1, ch2;
            // İki string için ortak döngü açılıyorsa kısa olan string kısıtlayıcı olmalı. Bundan sebep döngü kısa 
            // stringin boyu kadar çalışır. 
            for (var i = 0; i < startWith.Length; i++)
            {
                ch1 = str.ElementAt(i);
                ch2 = startWith.ElementAt(i);
                if (!ch1.Equals(ch2))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        private static string Substring(string str, int startIndex, int endIndex)
        {
            startIndex = (startIndex < 0) ? 0 : startIndex;
            endIndex = (endIndex >= str.Length) ? str.Length : endIndex;
            var substr = "";
            for (int i = startIndex; i < endIndex; i++)
                substr += str.ElementAt(i);


            return substr;
        }

        // private static void substring(string str, int startIndex, int endIndex)
        // {
        //     throw new System.NotImplementedException();
        // }
    }
}