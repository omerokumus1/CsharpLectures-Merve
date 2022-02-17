using System;

namespace Ch1_Exercise2
{
    internal class Exercise2
    {
        public static void Main(string[] args)
        {
            /*
             * (Convert Celsius to Fahrenheit) Write a program that reads a Celsius degree in
                a double value from the console, then converts it to Fahrenheit and displays the
                result. The formula for the conversion is as follows:
                fahrenheit = (9 / 5) * celsius + 32
             */
            
            Console.WriteLine("Welcome to Celsius to Fahrenheit converter");
            Console.Write("Enter a value for Celsius: ");
            double celsius;
            Double.TryParse(Console.ReadLine(), out celsius);
            double fahrenheit = (9.0 / 5) * celsius + 32;
            Console.WriteLine("fahrenheit: " + fahrenheit);

        }
    }
}