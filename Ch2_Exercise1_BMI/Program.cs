using System;

namespace Ch2_Exercise1_BMI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
                BMI < 18.5 Underweight
                18.5 ≤ BMI < 25.0 Normal
                25.0 ≤ BMI < 30.0 Overweight
                30.0 ≤ BMI Obese
             */
            
            /* TODO:
             *      1. Kullanıcan kilo ve boy değerlerini al: kilo kg cinsinden, boy metre cinsinden
             *      2. BMI Hesapla: kilo / (boy * boy)
             *      3. BMI değerine göre sonucu ekrana bastır
             */

            // 1. Kullanıcan kilo ve boy değerlerini al: kilo kg cinsinden, boy metre cinsinden
            Console.WriteLine("Enter weight in kg");
            double weight;
            Double.TryParse(Console.ReadLine(), out weight);
            
            Console.WriteLine("Enter height in meters");
            double height;
            Double.TryParse(Console.ReadLine(), out height);
            
            // 2. BMI Hesapla: kilo / (boy * boy)
            double bmi = weight / (height * height);
            // double bmi = weight / Math.Pow(height, 2); // 2. yöntem
    
            // 3. BMI değerine göre sonucu ekrana bastır
            Console.WriteLine("BMI: " + Math.Round(bmi, 2));
            if (bmi < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (bmi < 30)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            }

        }
    }
}