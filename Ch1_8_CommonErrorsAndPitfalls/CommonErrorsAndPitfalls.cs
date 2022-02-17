using System;

namespace Ch1_8_CommonErrorsAndPitfalls
{
    internal class CommonErrorsAndPitfalls
    {
        public static void Main(string[] args)
        {
            // Common Error 1: Undeclared/Uninitialized Variables and Unused Variables
            int i; // declared but uninitialized -> assign edilmemiş
            i = 3;
            Console.WriteLine(i);
            int i2; // soluk -> unused/kullanılmamış

            
            // Common Error 3: Round-off Errors: çok büyük sayıdan küçük bir sayı çıkarsa büyük sayı sonucu domine edebilir
            Console.WriteLine(10000000000.0 - 0.0000001); // sonuç -> 10000000000.0,
            
            
            // Common Error 4: Unintended Integer Division
            Console.WriteLine(Math.Pow(64, 1/3)); // 64^0 = 1
            
            
        }
    }
}