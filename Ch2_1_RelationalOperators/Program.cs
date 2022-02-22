using System;

namespace Ch2_1_RelationalOperators
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Control flow
            // bool data type
            bool b = true; // ya da false
            
            // Relational Operators -> boolean sonuç üretir. double, int, char, boolean veri tiplerini kıyaslamak amaçlı kullanılırlar
            // <, <=, >, >=, ==, !=

            bool b2 = 3 > 2;  // true
            bool b3 = -3 >= 4; // false
            bool b4 = 3 == 3; // true 
            bool b5 = 3.3 != 4; // true
            bool b6 = 'a' > 'c'; // false -> alfabetik sıralama yapar
            bool b7 = true != false;
            Console.WriteLine("bool b2 = 3 > 2;" + b2);
            Console.WriteLine("bool b3 = -3 >= 4;" + b3);
            Console.WriteLine("bool b4 = 3 == 3;" + b4);
            Console.WriteLine("bool b5 = 3 != 4;" + b5);
            Console.WriteLine("bool b6 = 'a' > 'c';" + b6);

            // iki boolean değişkenin eşitliği kontrol edilebilir
            bool b8 = b6 == b7;
            bool b9 = b2 != b4;

            // Caution: == ile = farklı şeyler!

            // relational operatorün sağına veya soluna expression (function veya matematiksel işlem) eklenebilir
            bool b10 = 3 + 2 != 2 + 3;
            bool b11 = Math.Round(3.12) == 3;

        }
    }
}