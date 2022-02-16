using System;

namespace Ch1_6_AugmentedOperators
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 1- Augmented operators
            int i1 = 5, i2 = 3;
            i1 = i1 + i2;
            i1 += i2; // augmented operator +=, i1 = i1 + i2; anlamına gelir
            i1 -= i2;
            i1 *= i2;
            i1 /= i2; // int division
            double d1 = 3, d2 = 6;
            d1 /= d2; // double division

            int i3 = 11, i4 = 5;
            i3 %= i4;
            
            // 2- Post increment/decrement
            int i5 = 6;
            i5++; // post increment, 1 arttır
            i5--; // post decrement, 1 azalt
            
            // 3- Pre increment/decrement
            int i6 = 7;
            ++i6; // pre increment, 1 arttır
            --i6; // pre decrement, 1 azalt
            
            // 4- Post vs pre
            // post: önce kullan sonra arttır/azalt
            // pre: önce arttır/azalt sonra kullan
            int i7 = 8;
            int i8 = i7++;
            Console.WriteLine("post increment");
            Console.WriteLine("i8:" + i8);
            Console.WriteLine("i7:" + i7);

            i7 = 8;
            i8 = ++i7;
            Console.WriteLine("pre increment");
            Console.WriteLine("i8:" + i8);
            Console.WriteLine("i7:" + i7);

            i7 = 8;
            i8 = i7++ + 3;
            Console.WriteLine("i8:" + i8);
            Console.WriteLine("i7:" + i7);
            
            i7 = 8;
            i8 = ++i7 + 3;
            Console.WriteLine("i8:" + i8);
            Console.WriteLine("i7:" + i7);
            
            // *** Hiçbir zaman post/pre increment/decrement bu şekilde kullanma!!
            // Nasıl kullanılmalı? -> tek başına kullanılmalı
            // i++;
            // i--;
            // ++i;
            // --i;
        }
    }
}