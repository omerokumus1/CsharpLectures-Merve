using System;
using System.Text;

namespace Ch2_6_SwitchStatements
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 1- Intro
            int selector = 6;
            switch (selector)
            {
                case 0:
                    Console.WriteLine("case 0");
                    break;
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            // 2- break statement
            selector = 1;
            switch (selector)
            {
                case 0:
                case 1:
                    Console.WriteLine("case 0-1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            // tek basamaklı asal sayıları ve çift sayıları seçen switch statement
            selector = 0;
            switch (selector)
            {
                case 2:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("Prime numbers");
                    break;
                case 0:
                case 4:
                case 6:
                case 8:
                    Console.WriteLine("Even numbers");
                    break;
            }
            
            // 3- Ne zaman switch?: Olayları/durumları sayılarla isimlendirebiliyorsak switch kullanımı daha iyidir
            selector = 65;
            switch (selector)
            {
                case 0: Console.WriteLine("zero");
                    break;
                case 1: Console.WriteLine("one");
                    break;
                case 2: Console.WriteLine("two");
                    break;
                case 3: Console.WriteLine("three");
                    break;
                case 4: Console.WriteLine("four");
                    break;
                case 5: Console.WriteLine("five");
                    break;
                case 6: Console.WriteLine("six");
                    break;
                case 7: Console.WriteLine("seven");
                    break;
                case 8: Console.WriteLine("eight");
                    break;
                case 9: Console.WriteLine("nine");
                    break;
                default: Console.WriteLine("Should be between 0-9");
                    break;
            }
            
            



        }
    }
}