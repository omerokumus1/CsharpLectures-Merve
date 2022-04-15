
using System;

namespace Ch4_2_MethodDefinitionAndCalling
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*  Fonksiyon tipleri:
             *      1- Çağıran kişiye (fonksiyon) bir şey geri vermeyen
             *          Bu fonksiyonlar sadece işinin bittiğinin haberini kendisi çağırana verir
             *      2- Çağıran kişiye (fonksiyon) bir şey geri veren
             *          Bu fonksiyonlar hem işinin bittiğinin haberini hem de kendisini çağırana bir şey verir
             */
            
            /*  Fonksiyon tanımlama formülü
             *      1- Çağıran kişiye (fonksiyon) bir şey geri vermeyen
             *          public static void FonksiyonAdı(parametreListesi)
             *          {
             *              fonksiyon body'si (function body) kodların bulunduğu yer
             *          }
             *
             *      2- Çağıran kişiye (fonksiyon) bir şey geri veren
             *          public static returnType FonksiyonAdı(parametreListesi)
             *          {
             *              fonksiyon body'si (function body) kodların bulunduğu yer
             *          }
             */
            
            // Function call/invocation
            AddTwoIntegers(2, 3); // 2, 3 sayılarına arguman denir 
            AbsoluteValue(-3);
            AbsoluteValue(8);
            SubtractThreeIntegers(10, 3, 5);

            int sum = AddTwoIntegers2(10, 4);
            Console.WriteLine("sum2: " + sum);

            int res = SubtractThreeIntegers2(5, 1, 1);
            Console.WriteLine("subtract: " + res);

            int abs = AbsoluteValue2(-11);
            Console.WriteLine("abs: " + abs);
            
            Console.WriteLine("abs: " + AbsoluteValue2(-77));
        }
        
        // 1- Çağıran kişiye (fonksiyon) bir şey geri vermeyen
        public static void AddTwoIntegers(int n1, int n2) // n1, n2 değişkenlerine parametre denir
        {
            int sum = n1 + n2;
            Console.WriteLine("sum: " + sum);
        }
        
        // 2- Çağıran kişiye (fonksiyon) bir şey geri veren
        public static int AddTwoIntegers2(int n1, int n2)
        {
            int sum = n1 + n2;
            return sum;
        }
        public static void SubtractThreeIntegers(int n1, int n2, int n3)
        {
            int res = n1 - n2 - n3;
            Console.WriteLine("result: " + res);
        }

        public static int SubtractThreeIntegers2(int n1, int n2, int n3)
        {
            int res = n1 - n2 - n3;
            return res;
        }

        public static void AbsoluteValue(int n)
        {
            int res = (n < 0) ? -n : n;
            Console.WriteLine("Absolute value of " + n + " is " + res);
        }

        public static int AbsoluteValue2(int n)
        {
            int res = (n < 0) ? -n : n;
            return res;
        }

    }
}