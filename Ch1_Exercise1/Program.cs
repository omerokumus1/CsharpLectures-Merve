using System;

namespace Ch1_Exercise1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Dikdörtgen alan ve çevre hesabı
            Console.WriteLine("Enter short edge: ");
            double shortEdge;
            Double.TryParse(Console.ReadLine(), out shortEdge);
            
            Console.WriteLine("Enter long edge: ");
            double longEdge;
            Double.TryParse(Console.ReadLine(), out longEdge);

            double area = longEdge * shortEdge;
            double perimeter = 2 * (longEdge + shortEdge);
            
            Console.WriteLine("Area of the rectangle: " + area);
            Console.WriteLine("Perimeter of the rectangle: " + perimeter);
        }
    }
}