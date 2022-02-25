using System;

namespace Ch2_Exercise3_RootCalc
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*  TODO:
             *      1. Kullanıcıdan a, b, c değerlerini al
             *      2. Discriminant hesapla: D = b^2 - 4ac
             *      3. D > 0 ise 2 kök
             *      4. D = 0 ise 1 kök
             *      5. D < 0 ise 0 kök
             */

            // 1. Kullanıcıdan a, b, c değerlerini al
            int a, b, c;
            Console.Write("Enter a: ");
            Int32.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter b: ");
            Int32.TryParse(Console.ReadLine(), out b);
            Console.Write("Enter c: ");
            Int32.TryParse(Console.ReadLine(), out c);
            
            // 2. Discriminant hesapla: D = b^2 - 4ac
            int disc = (int)Math.Pow(b, 2) - 4 * a * c;
            if (disc > 0)
            {
                double r1 = (-b + Math.Sqrt(disc)) / (2 * a);
                double r2 = (-b - Math.Sqrt(disc)) / (2 * a);
                Console.WriteLine("Root 1: " + Math.Round(r1, 6));
                Console.WriteLine("Root 2: " + Math.Round(r2, 6));
            }
            else if (disc == 0)
            {
                double r = -b / (double) (2 * a);
                Console.WriteLine("Root: " + Math.Round(r, 6));
            }
            else
                Console.WriteLine("No real roots.");
        }
    }
}