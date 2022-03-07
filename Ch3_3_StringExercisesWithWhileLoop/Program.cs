using System;
using System.Linq;

namespace Ch3_3_StringExercisesWithWhileLoop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // count uppercase letters 
            string str = "C# Programming.";
            int i = 0;
            int upperLetters = 0;
            char currentChar;
            while (i < str.Length)
            {
                currentChar = str.ElementAt(i);
                if (Char.IsUpper(currentChar))
                    upperLetters++;
                i++;
            }
            Console.WriteLine("upper case letter count: " + upperLetters);
            
            
            // string içerisindeki sayıları say
            str = "1. C#\n2. Java\n3. C++";
            i = 0;
            int digitCount = 0;
            while (i < str.Length)
            {
                currentChar = str.ElementAt(i);
                if (Char.IsDigit(currentChar))
                    digitCount++;
                i++;
            }
            Console.WriteLine("digit count: " + digitCount);
            
            
            // string içerisindeki kelimeleri say
            str = "I love C# programming.";
            i = 0;
            int spaceCount = 0;
            while (i < str.Length)
            {
                currentChar = str.ElementAt(i);
                if (currentChar == ' ')
                    spaceCount++;
                i++;
            }
            int wordCount = spaceCount + 1;
            Console.WriteLine("number of words: " + wordCount);
        }
    }
}