using System;

namespace Ch1_7_ReadingInputFromConsole
{
    internal class ReadingInputFromConsole
    {
        public static void Main(string[] args)
        {
            // 1- Console.ReadLine(): string verir
            // Console.WriteLine("Enter your name"); // prompt user
            // string name = Console.ReadLine();
            //
            // Console.WriteLine("Greetings " + name);


            // Console.Write("Enter your name: ");
            // string name = Console.ReadLine();
            //
            // Console.Write("Enter your surname: ");
            // string surname = Console.ReadLine();
            // Console.Write("Enter your age: ");
            // string age = Console.ReadLine();
            // Console.Write("Enter your school: ");
            // string school = Console.ReadLine();
            //
            // Console.WriteLine("Hi, my name is " + name + " " + surname + ". I am " + age + " years old."
            //                   + " I am studying at " + school + ".");
            
            
            
            // 2- Reading numbers by Convert
            // reading int
            // Console.WriteLine("Enter an integer");
            // // string s1 = Console.ReadLine();
            // // int i1 = Convert.ToInt32(s1);
            // int i1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("You have entered " + i1);
            
            // reading double
            // Console.WriteLine("Enter an double");
            // double d1 = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("You have entered " + d1);
            
            
            
            // 3- Reading numbers by parsing
            // reading int
            // Console.WriteLine("Enter an integer");
            // int i1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("You have entered " + i1);
            
            // reading double -> double.Parse(Console.ReadLine());
            
            
            
            // 4- Reading numbers conditionally
            // Avantaj: Hatalı inputlarda program çökmez (crash etmez)
            
            // reading int
            Console.WriteLine("Enter an integer");
            int i1;
            bool success = Int32.TryParse(Console.ReadLine(), out i1);
            Console.WriteLine("Parsing is " + success);

            int i2;
            Int32.TryParse(Console.ReadLine(), out i2);

            int i3;
            string s = "11";
            Int32.TryParse(s, out i3);
            
            // string'in hatalı olmadığından eminsen Convert ile dönüşüm yapabilirsin. Eğer değilsen TryParse kullan.

        }
    }
}