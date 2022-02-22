using System;

namespace Ch1_Exercise5_MinuteConverter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * (Find the number of years) Write a program that prompts the user to enter the
                minutes (e.g., 1 billion), and displays the number of years and days for the minutes.
                For simplicity, assume a year has 365 days.
             */
            
            /*  TODO:
             *      1. Read minute value in integer
             *          1.1. Convert input to integer
             *      2. Convert minute to hour, day, and year
             *          2.1. from minute to hour, use remainder and integer division
             *          2.2. from hour to day and from day to year use the same
             */
            
            // 1. Read minute value in integer
            Console.WriteLine("Enter minute value in integer");
            int minute;
            Int32.TryParse(Console.ReadLine(), out minute); // 1.1. Convert input to integer
            
            // 2. Convert minute to hour, day, and year
            int hour, day, year;
                // find minute and hour
            hour = minute / 60;
            minute %= 60;
                // find hour and day
            day = hour / 24;
            hour %= 24;
            
                // find day and year
            year = day / 365;
            day %= 365;
            
            Console.WriteLine("minute: " + minute + "\nhour: " + hour + "\nday: " + day + "\nyear: " + year);

        }
    }
}