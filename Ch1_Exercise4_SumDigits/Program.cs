using System;

namespace Ch1_Exercise4_SumDigits
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * (Sum the digits in an integer) Write a program that reads an integer between 0 and
                1000 and adds all the digits in the integer. For example, if an integer is 932, the
                sum of all its digits is 14.
             */
            
            /*  TODO:
             *      1. Read an integer from the console
             *          1.1. Convert input to integer
             *      2. Parse the input into its digits (use integer division and remainder)
             * 
             */
            
            // 1. Read an integer from the console
            Console.WriteLine("Enter an integer between 0-1000");
            int number;
            Int32.TryParse(Console.ReadLine(), out number); // 1.1. Convert input to integer
            
            // 2. Parse the input into its digits (use integer division and remainder)
            // 982 / 10 -> 98 -> 9 -> 0
            // 982 % 10 = 2, 98 % 10 = 8, 9 % 10 = 9, 0 % 10 = 0

            // 982 
            // 21 % 10 = 1, 21 / 10 = 2
            // 2 % 10 = 2, 2 / 10 = 0
            // 0 % 10 = 0, 0 / 10 = 0
            
            int sum = 0;
            int digit;
            // birler basamağını al
            digit = number % 10;
            sum += digit; // üzerine eklediğimiz için += kullandık, sum = sum + digit anlamına gelir
            
            // onlar basamağını al
            number /= 10; // onlar basamağını birler basamağına kaydırmak için, 982 / 10 = 98, 8'i birler basamağına kaydırdık
            digit = number % 10;
            sum += digit; // sum'ın eski değerine digit'i ekledik. 

            // yüzler basamağını al
            number /= 10; // 98/10 = 9
            digit = number % 10;
            sum += digit;

            Console.WriteLine("sum: " + sum);
        }
    }
}