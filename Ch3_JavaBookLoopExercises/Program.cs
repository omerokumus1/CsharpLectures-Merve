using System;

namespace Ch3_JavaBookLoopExercises
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
                5.1 (Count positive and negative numbers and compute the average of numbers) Write
                a program that reads an unspecified number of integers, determines how many
                positive and negative values have been read, and computes the total and average of
                the input values (not counting zeros). Your program ends with the input 0. Display
                the average as a floating-point number.
             */
            // Console.WriteLine("5.1 Count positive and negative numbers and compute the average of numbers");
            // int number;
            // int positiveCount = 0, negativeCount = 0;
            // int sum = 0;
            // while (true)
            // {
            //     Console.Write("Enter a value: ");
            //     Int32.TryParse(Console.ReadLine(), out number);
            //     if (number == 0)
            //         break;
            //
            //     if (number > 0)
            //         positiveCount++;
            //
            //     else
            //         negativeCount++;
            //
            //     sum += number;
            // }
            //
            // int totalElements = (positiveCount + negativeCount);
            // double average = (double) sum / totalElements;
            // Console.WriteLine("The number of positives is " + positiveCount);
            // Console.WriteLine("The number of negatives is " + negativeCount);
            // Console.WriteLine("The total is " + sum);
            // Console.WriteLine("The average is " + average);
            
            /*
                5.3 (Conversion from kilograms to pounds) Write a program that displays the following
                table (note that 1 kilogram is 2.2 pounds): 
             */
            Console.WriteLine("5.3 Conversion from kilograms to pounds");
            Console.WriteLine("Kilograms\tPounds");
            double pound;
            for (int i = 1; i < 200; i+=2)
            {
                pound = i * 2.2;
                Console.WriteLine(i + "\t\t" + pound);
            }
            
            /*
                **5.7 (Financial application: compute future tuition) Suppose that the tuition for a university
                is $10,000 this year and increases 5% every year. In one year, the tuition
                will be $10,500. Write a program that computes the tuition in ten years and the
                total cost of four years’ worth of tuition after the tenth year.
             */
            Console.WriteLine("5.7 Financial application: compute future tuition");
            double tuition = 10000;
            double increaseRate = 0.05;
            Console.WriteLine("Year\tTution");
            for (int i = 0; i < 10; i++) // ilk 10 yıl
            {
                tuition += tuition*increaseRate;
                Console.WriteLine((i+1) + ".\t" + Math.Round(tuition, 2));
            }

            double totalCost = 0;
            int year = 4;
            for (int i = 0; i < year; i++) // sonraki 4 yıl
            {
                tuition += tuition * increaseRate;
                totalCost += tuition;
            }
            Console.WriteLine("Total cost is " + Math.Round(totalCost, 2));
        }
    }
}