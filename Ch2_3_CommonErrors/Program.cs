using System;

namespace Ch2_3_CommonErrors
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Errors
            // 1- Forgetting Necessary Braces
            double radius = -2.3;
            double area = -1;
            if (radius >= 0)
                area = 3.14 * radius * radius;
                Console.WriteLine("area is " + area);

                
            // 2- Wrong semicolon at the end of if
            if (2 < 3) ;
            
            
            // 3- Redundant boolean value testing
            bool b = 2 < 3;
            if (b == true)
            {
                
            }

            if (b)
            {
                
            }
            
            // use case
            if ("a".Equals("b"))
            {   
                
            }
            
            
            // 5- Equality test in floating point numbers
            if (10000000000.0 - 0.0000001 == 9999999999.9999999 ) // kötü sonuçlar doğurabilir :)
            {
                Console.WriteLine("xxxx");
            }
            
            
            // Pitfalls
            // 1- Simplifying if else statements
            int number = 4;
            if (number % 2 == 0) // number % 2 == 0 true is b true olur
            {                   
                b = true;
            }
            else // number % 2 == 0 false ise b false olur
            {
                b = false;
            }

            // IF'in içi b'nin alacağı değer ile aynı ise bu şekilde sadeleştirilir
            b = number % 2 == 0; // yukarıdaki if else ile aynı şey

            if (number % 2 == 0)
            {
                b = false;
            }
            else
            {
                b = true;
            }

            // IF'in içi b'nin alacağı değerin tersi ise bu şekilde tersini b'ye atayarak sadeleştirme yapılabilir.
            b = number % 2 != 0;
            b = !(number % 2 == 0);
            
            
            
            // 2- Code duplication
            int salary;
            if (b)
            {
                salary = 1000;
                Console.WriteLine("salary: " + salary); // duplicated
            }
            else
            {
                salary = 1500;
                Console.WriteLine("salary: " + salary); // duplicated
            }
            
            // düzeltmesi: duplicated satırlar her koşulda çalıştığından ötürü if-else yapısının dışına alınır
            if (b)
            {
                salary = 1000;
            }
            else
            {
                salary = 1500;
            }
            Console.WriteLine("salary: " + salary); 

            
            

        }
    }
}