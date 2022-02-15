using System;

namespace Strings
{
    internal class Strings
    {
        public static void Main(string[] args)
        {
            // 1- string concatenation: string birleştirme
            string str1 = "I learn";
            string str2 = " C# programming.";
            string str3 = str1 + str2;
            Console.WriteLine(str3);

            // 2- string + number/char/boolean etc
            double result = Math.Pow(3, 4);
            Console.WriteLine("3 raised to the power of 4 is " + result);

            char firstLetter = 'a';
            Console.WriteLine("the first letter in alphabet is " + firstLetter);


            // 3- String operations
            string s1 = "C# is fun.";
            string s1Upper = s1.ToUpper();
            Console.WriteLine("s1Upper: " + s1Upper);

            Console.WriteLine(s1 + ", length: " + s1.Length);

            Console.WriteLine("s1 contains C#: " + s1.Contains("C#"));
            Console.WriteLine("s1 contains Java: " + s1.Contains("Java"));

            string s2 = "C# is fun.";
            string s3 = "Java is fun.";
            Console.WriteLine("s1 equals s2: " + s1.Equals(s2));
            Console.WriteLine("s1 equals s3: " + s1.Equals(s3));
            
            // I_love_java -> index 0'dan başlar. I -> 0. index, _ -> 1. index, l -> 2. index gibi gibi
            Console.WriteLine("substring starting from 0: " + s1.Substring(0));
            Console.WriteLine("substring starting from 4: " + s1.Substring(4));
            Console.WriteLine("substring starting from 0, length 3: " + s1.Substring(0, 3));
            Console.WriteLine("substring starting from 4, length 4: " + s1.Substring(4, 4));

            Console.WriteLine("index of #: " + s1.IndexOf('#'));
            Console.WriteLine("index of .: " + s1.IndexOf('.'));

            Console.WriteLine("araba vs bina:" + "araba".CompareTo("bina"));
            Console.WriteLine("araba vs araba:" + "araba".CompareTo("araba"));
            Console.WriteLine("bina vs araba:" + "bina".CompareTo("araba"));
            
            Console.WriteLine("s1 starts with C#: " + s1.StartsWith("C#"));
            Console.WriteLine("s1 starts with Java: " + s1.StartsWith("Java"));
            
        }
    }
}