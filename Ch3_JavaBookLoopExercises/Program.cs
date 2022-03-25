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
            for (int i = 1; i < 200; i += 2)
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
                tuition += tuition * increaseRate;
                Console.WriteLine((i + 1) + ".\t" + Math.Round(tuition, 2));
            }

            double totalCost = 0;
            int year = 4;
            for (int i = 0; i < year; i++) // sonraki 4 yıl
            {
                tuition += tuition * increaseRate;
                totalCost += tuition;
            }

            Console.WriteLine("Total cost is " + Math.Round(totalCost, 2));

            /*
                *5.14 Compute the greatest common divisor of two numbers
                    Örn; ebob(9,12) = 3, ebob(10,50) = 10, ebob(5,9) = 1
                    9 12    | 1+
                    9 12    | 2 
                    9 6     | 2 
                    9 3     | 3+ 
                    3 1     | 3
                    1 1     |
            */

            int n1 = 5;
            int n2 = 9;
            int min = Math.Min(n1, n2);
            int ebob = 1;
            for (int divider = 1; divider <= min; divider++)
            {
                if (n1 % divider == 0 && n2 % divider == 0)
                    ebob = divider;
            }

            Console.WriteLine("Exercise 5.14, ebob(" + n1 + ", " + n2 + ") = " + ebob);


            /*
             * Compute lowest common multiplier
             * ekok(5,9) = 45, ekok(9,12) = 36, ekok(10,50) = 50
                    9 12    | 1+
                    9 12    | 2+    ekok = 2
                    9 6     | 2+    ekok = 4
                    9 3     | 3+    ekok = 12   
                    3 1     | 3+    ekok = 36
                    1 1     |
             */
            int n1Orj = 10;
            int n2Orj = 50;
            n1 = n1Orj;
            n2 = n2Orj;
            int ekok = 1;
            int div = 2;
            while (!(n1 == 1 && n2 == 1))
            {
                if (n1 % div == 0 && n2 % div == 0)
                {
                    n1 /= div;
                    n2 /= div;
                    ekok *= div;
                }
                else
                {
                    if (n1 % div == 0)
                    {
                        n1 /= div;
                        ekok *= div;
                    }
                    if (n2 % div == 0)
                    {
                        n2 /= div;
                        ekok *= div;
                    }
                }

                if (n1 % div != 0 && n2 % div != 0)
                    div++;
            }
            Console.WriteLine("Exercise 5.14-2, ekok(" + n1Orj + ", " + n2Orj + ") = " + ekok);
        }
    }
}