using System;

namespace Ch1_Exercise3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * (Convert pounds into kilograms) Write a program that converts pounds into kilograms.
                The program prompts the user to enter a number in pounds, converts it
                to kilograms, and displays the result. One pound is 0.454 kilograms.
             */
            
            /* TODO:
             *      1. Prompt the user
             *      2. Read pound value from the console
             *          2.1. Convert pound value into double
             *          2.2. Read pound value conditionally (Use TryParse)
             *      3. Convert pound value to kg
             *      4. Display the result
             *
             *      Appendix: One pound is 0.454 kilograms
             */
            
            // 1. Prompt the user
            Console.Write("Enter pound value: ");
            
            // 2. Read pound value from the console
            double pound;
                // 2.1. Convert pound value into double
            Double.TryParse(Console.ReadLine(), out pound); // 2.2. Read pound value conditionally (Use TryParse)

            // 3. Convert pound value to kg
            double kg = pound * 0.454;
            
            // 4. Display the result
            Console.WriteLine("kilograms: " + kg);

        }
    }
}